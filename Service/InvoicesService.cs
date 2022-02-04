using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Threading.Tasks;
using Facturation.Config;

namespace Facturation.Service
{
    class InvoicesService
    {
        OleDbConnection conn;

        public InvoicesService()
        {
            try
            {
                conn = new OleDbConnection(database.getConnectionString());
            }
            catch { }
            
        }

        public async Task<bool> createNewInvoice
            (String InvoiceId, String invoiceDate, String note, String clientId,DataTable products,String tva , String username)
        {
            try
            {
                String InvoiceQuery = String.Format(
                    "INSERT INTO Invoice ( factID , factDate , delai ,clientID ,tva) VALUES ( '{0}' ,'{1}' ,'{2}' , '{3}',{4} );",
                    InvoiceId , invoiceDate , note , clientId, tva  );

                String InvoiceHistory = String.Format("INSERT INTO invoiceHisto (factID , username,opDate , op) VALUES ( '{0}' ,'{1}' ,'{2}' , {3} ) ", InvoiceId, username, DateTime.Now, 1);

                OleDbCommand InviiceCmd = new OleDbCommand(InvoiceQuery, conn);
                OleDbCommand historyCmd = new OleDbCommand(InvoiceHistory, conn);
                await conn.OpenAsync();
                await InviiceCmd.ExecuteNonQueryAsync();
                await historyCmd.ExecuteNonQueryAsync();
                conn.Close();
                await addProductsToInvoice(InvoiceId, products);


                return true;
            }
            catch
            {
                return false;
            }

        }

        private async Task addProductsToInvoice (String invoiceId , DataTable products)
        {
            try
            {
                for(int i = 0; i < products.Rows.Count; i++)
                {
                    String InvoiceProductsQuery = String.Format(
                    "INSERT INTO InvoiceProds ( factID , productRef , selledQnt ,sellPrice , colis ) VALUES ( '{0}' ,'{1}' ,{2} , {3} , {4} );",
                    invoiceId, products.Rows[i][0], products.Rows[i][1], products.Rows[i][2].ToString().Replace(',', '.'), products.Rows[i][3]);

                    OleDbCommand cmd = new OleDbCommand(InvoiceProductsQuery, conn);
                    await conn.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    conn.Close();
                }
               
            }
            catch
            {
                
            }

        }

        public async Task<bool> getInvoiceProducts(String invoiceId , DataTable dt)
        {

            try
            {
                String query = String.Format("SELECT InvoiceProds.productRef, InvoiceProds.selledQnt, InvoiceProds.sellPrice, InvoiceProds.colis, Product.productName "+
                                             "FROM(InvoiceProds INNER JOIN "+
                                             "Product ON InvoiceProds.productRef = Product.productRef) "+
                                             "WHERE(InvoiceProds.factID = '{0}')",invoiceId);
                OleDbCommand getInfo = new OleDbCommand(query, conn);
                await conn.OpenAsync();
                var data = await getInfo.ExecuteReaderAsync();
                
                dt.Load(data);
                return true;
                
            }
            catch
            {
                return false;
            }

        }

        public async Task<bool> getInvoiceInfo(String invoiceId, DataTable dt)
        {

            try
            {
                String query = String.Format("SELECT Invoice.*, Client.clientName, Client.clientAddress, Client.clientWilaya " +
                         " FROM(Invoice INNER JOIN Client ON Invoice.clientID = Client.clientID) WHERE(Invoice.factID = '{0}' )", invoiceId);
                OleDbCommand getInfo = new OleDbCommand(query, conn);
                await conn.OpenAsync();
                var data = await getInfo.ExecuteReaderAsync();
                dt.Load(data);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public async Task<DataTable> getAllInvoices()
        {

            try
            {
                String query = "SELECT Invoice.factID,Invoice.factDate,Client.clientID,Client.clientName , isConfirmed FROM Client INNER JOIN Invoice ON Client.clientID = Invoice.clientID ORDER BY Invoice.factDate DESC;";
                OleDbCommand getInfo = new OleDbCommand(query, conn);
                await conn.OpenAsync();
                var data = await getInfo.ExecuteReaderAsync();
                DataTable dt = new DataTable();
                dt.Load(data);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public async Task<DataTable> getSearchedInvoicesByClientName(String clientName)
        {

            try
            {
                String query =String.Format(
                    "SELECT Invoice.factID,Invoice.factDate,Client.clientID ,Client.clientName , isConfirmed FROM Client INNER JOIN Invoice ON Client.clientID = Invoice.clientID WHERE Client.clientName LIKE '%{0}%'  ORDER BY Invoice.factDate DESC;",
                    clientName);
                OleDbCommand getInfo = new OleDbCommand(query, conn);
                await conn.OpenAsync();
                var data = await getInfo.ExecuteReaderAsync();
                DataTable dt = new DataTable();
                dt.Load(data);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public async Task<DataTable> getSearchedInvoicesByInvoiceNumOrDate(String invoiceNum , String invoiceDate)
        {

            try
            {
                String query = String.Format(
                    "SELECT Invoice.factID, Invoice.factDate,Client.clientID ,Client.clientName ,  isConfirmed FROM Client INNER JOIN Invoice ON Client.clientID = Invoice.clientID WHERE (((Invoice.factID)='{0}')) OR (((FORMAT(Invoice.factDate,\"Short Date\"))=#{1}#));",
                    invoiceNum , invoiceDate );        
                OleDbCommand getInfo = new OleDbCommand(query, conn);
                await conn.OpenAsync();
                var data = await getInfo.ExecuteReaderAsync();
                DataTable dt = new DataTable();
                dt.Load(data);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> deleteInvoice(String invoiceNum, String username)
        {
            try
            {
                String query = String.Format("DELETE FROM Invoice WHERE factID = '{0}' ;", invoiceNum);

                String historyInvoice = String.Format("INSERT INTO invoiceHisto (factID , username,opDate , op) VALUES ( '{0}' ,'{1}' ,'{2}' , {3} ) ", invoiceNum, username, DateTime.Now, 3);

                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbCommand historyCmd = new OleDbCommand(historyInvoice, conn);
                await conn.OpenAsync();
                await historyCmd.ExecuteNonQueryAsync();
                await cmd.ExecuteNonQueryAsync();
                conn.Close();

                return true;
            }
            catch
            {
                return false;
            }

        }

        public async Task<double> getInvoicesPeriodEearning(String initDate ,String endDate)
        {

            try
            {
                double total = 0.0;
                String query = String.Format(
                    "SELECT SUM( clientVerssements.amount) FROM clientVerssements WHERE FORMAT(clientVerssements.verssementDate,\"Short Date\")  BETWEEN #{0}# AND #{1}# ;",
                    initDate, endDate);
                OleDbCommand getInfo = new OleDbCommand(query, conn);
                await conn.OpenAsync();
                var data = await getInfo.ExecuteReaderAsync();
                DataTable dt = new DataTable();
                dt.Load(data);
                try
                {
                     total = Convert.ToDouble(dt.Rows[0][0]);
                }
                catch { }
                return  Math.Round(total, 2); ;
            }
            catch
            {
                return -1;
            }
        }

        public async Task<double> getInvoicesPeriodSpending(String initDate, String endDate)
        {

            try
            {
                double total = 0.0;
                String query = String.Format(
                    "SELECT SUM( outVerssements.amount) FROM outVerssements WHERE FORMAT( outVerssements.verssementDate,\"Short Date\")  BETWEEN #{0}# AND #{1}# ;",
                    initDate, endDate);
                OleDbCommand getInfo = new OleDbCommand(query, conn);
                await conn.OpenAsync();
                var data = await getInfo.ExecuteReaderAsync();
                DataTable dt = new DataTable();
                dt.Load(data);
                try
                {
                    total = Convert.ToDouble(dt.Rows[0][0]);
                }
                catch { }
                return Math.Round(total, 2); ;
            }
            catch
            {
                return -1;
            }
        }

        public async Task<int> getInvoicesPeriodNumber(String initDate, String endDate)
        {

            try
            {
                int total = 0;
                String query = String.Format(
                    "SELECT COUNT(factID) FROM Invoice  WHERE  FORMAT(Invoice.factDate,\"Short Date\") BETWEEN #{0}# AND #{1}# ;",
                    initDate, endDate);
                OleDbCommand getInfo = new OleDbCommand(query, conn);
                await conn.OpenAsync();
                var data = await getInfo.ExecuteReaderAsync();
                DataTable dt = new DataTable();
                dt.Load(data);
                try
                {
                    total = Convert.ToInt32(dt.Rows[0][0]);
                }
                catch { }
                return total;
            }
            catch
            {
                return -1;
            }
        }

        public async Task<DataTable> getInvoicesEearningPerDay(String initDate, String endDate)
        {

            try
            {

                String query = String.Format(
                    "SELECT SUM(clientVerssements.amount)  FROM clientVerssements WHERE clientVerssements.verssementDate BETWEEN #{0}# AND #{1}# GROUP BY FORMAT(clientVerssements.verssementDate,\"Short Date\");",
                    initDate, endDate);
                OleDbCommand getInfo = new OleDbCommand(query, conn);
                await conn.OpenAsync();
                var data = await getInfo.ExecuteReaderAsync();
                DataTable dt = new DataTable();
                dt.Load(data);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public async Task<DataTable> getInvoicesSpendingPerDay(String initDate, String endDate)
        {

            try
            {
                
                String query = String.Format(
                    "SELECT SUM(outVerssements.amount)  FROM outVerssements WHERE outVerssements.verssementDate BETWEEN #{0}# AND #{1}# GROUP BY FORMAT(outVerssements.verssementDate,\"Short Date\");",
                    initDate, endDate);
                OleDbCommand getInfo = new OleDbCommand(query, conn);
                await conn.OpenAsync();
                var data = await getInfo.ExecuteReaderAsync();
                DataTable dt = new DataTable();
                dt.Load(data);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> createFinalDocuments
            (String InvoiceId, String invoiceDate,String deleveryId , String finalInvoiceId )
        {
            try
            {
                String deleveryQuery = String.Format(
                    "INSERT INTO Delivery (deliveryNum,factID,deliveryDate ) VALUES ( '{0}' ,'{1}' ,'{2}' );",
                    deleveryId, InvoiceId, invoiceDate);

                String finalInvoiceQuery = String.Format("INSERT INTO officialInvoice (invoiceNum , deliveryNum,invoiceDate) VALUES ( '{0}' ,'{1}' ,'{2}') ",
                    finalInvoiceId, deleveryId, invoiceDate);

                OleDbCommand InviiceCmd = new OleDbCommand(deleveryQuery, conn);
                OleDbCommand historyCmd = new OleDbCommand(finalInvoiceQuery, conn);
                await conn.OpenAsync();
                await InviiceCmd.ExecuteNonQueryAsync();
                await historyCmd.ExecuteNonQueryAsync();
                conn.Close();
               


                return true;
            }
            catch
            {
                return false;
            }

        }

        public async Task<DataTable> getAllDeliveryDocuments()
        {

            try
            {

                String query = "SELECT Invoice.factID, Delivery.deliveryNum, Client.clientName, Delivery.deliveryDate FROM (Client INNER JOIN Invoice ON Client.clientID = Invoice.clientID) INNER JOIN Delivery ON Invoice.factID = Delivery.factID ORDER BY Delivery.deliveryDate DESC ;";
                OleDbCommand getInfo = new OleDbCommand(query, conn);
                await conn.OpenAsync();
                var data = await getInfo.ExecuteReaderAsync();
                DataTable dt = new DataTable();
                dt.Load(data);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public async Task<DataTable> getSearchedDeliveryDocuments(String cliientName)
        {

            try
            {

                String query =String.Format( 
                    "SELECT Invoice.factID, Delivery.deliveryNum, Client.clientName, Delivery.deliveryDate FROM (Client INNER JOIN Invoice ON Client.clientID = Invoice.clientID) INNER JOIN Delivery ON Invoice.factID = Delivery.factID WHERE  Client.clientName LIKE '%{0}%' ORDER BY Delivery.deliveryDate DESC ;",cliientName);
                OleDbCommand getInfo = new OleDbCommand(query, conn);
                await conn.OpenAsync();
                var data = await getInfo.ExecuteReaderAsync();
                DataTable dt = new DataTable();
                dt.Load(data);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public async Task<DataTable> getSearchedDeliveryDocumentsByDate(String ProformaId,String date)
        {

            try
            {

                String query = String.Format(
                    "SELECT Invoice.factID, Delivery.deliveryNum, Client.clientName, Delivery.deliveryDate FROM (Client INNER JOIN Invoice ON Client.clientID = Invoice.clientID) INNER JOIN Delivery ON Invoice.factID = Delivery.factID WHERE(((Invoice.factID)='{0}')) OR(((FORMAT(Delivery.deliveryDate,\"Short Date\"))=#{1}#)) ORDER BY Delivery.deliveryDate DESC ;", 
                    ProformaId,date);
                OleDbCommand getInfo = new OleDbCommand(query, conn);
                await conn.OpenAsync();
                var data = await getInfo.ExecuteReaderAsync();
                DataTable dt = new DataTable();
                dt.Load(data);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        

        public async Task<DataTable> getAllInvoicesDocuments()
        {

            try
            {

                String query = "SELECT Delivery.deliveryNum, officialInvoice.invoiceNum, Client.clientName, officialInvoice.invoiceDate FROM (Client INNER JOIN Invoice ON Client.clientID = Invoice.clientID) INNER JOIN (Delivery INNER JOIN officialInvoice ON Delivery.deliveryNum = officialInvoice.deliveryNum) ON Invoice.factID = Delivery.factID ORDER BY officialInvoice.invoiceDate DESC;";
                OleDbCommand getInfo = new OleDbCommand(query, conn);
                await conn.OpenAsync();
                var data = await getInfo.ExecuteReaderAsync();
                DataTable dt = new DataTable();
                dt.Load(data);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public async Task<DataTable> getSearchedInvoicesDocumentsByDate(String deliveryId,String date)
        {

            try
            {

                String query = String.Format(
                    "SELECT Delivery.deliveryNum, officialInvoice.invoiceNum, Client.clientName, officialInvoice.invoiceDate FROM (Client INNER JOIN Invoice ON Client.clientID = Invoice.clientID) INNER JOIN (Delivery INNER JOIN officialInvoice ON Delivery.deliveryNum = officialInvoice.deliveryNum) ON Invoice.factID = Delivery.factID WHERE(((Delivery.deliveryNum)='{0}')) OR(((FORMAT(officialInvoice.invoiceDate,\"Short Date\"))=#{1}#)) ORDER BY officialInvoice.invoiceDate DESC;",deliveryId,date);
                OleDbCommand getInfo = new OleDbCommand(query, conn);
                await conn.OpenAsync();
                var data = await getInfo.ExecuteReaderAsync();
                DataTable dt = new DataTable();
                dt.Load(data);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public async Task<DataTable> getSearchedInvoicesDocuments(String clientName)
        {

            try
            {

                String query = String.Format(
                    "SELECT Delivery.deliveryNum, officialInvoice.invoiceNum, Client.clientName, officialInvoice.invoiceDate FROM (Client INNER JOIN Invoice ON Client.clientID = Invoice.clientID) INNER JOIN (Delivery INNER JOIN officialInvoice ON Delivery.deliveryNum = officialInvoice.deliveryNum) ON Invoice.factID = Delivery.factID WHERE Client.clientName LIKE '%{0}%' ORDER BY officialInvoice.invoiceDate DESC;", clientName);
                OleDbCommand getInfo = new OleDbCommand(query, conn);
                await conn.OpenAsync();
                var data = await getInfo.ExecuteReaderAsync();
                DataTable dt = new DataTable();
                dt.Load(data);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public async Task<double> getInvoicesTotal(String invoiceID)
        {

            try
            {
                double total = 0.0;
                String query = String.Format(
                    "SELECT  SUM (((selledQnt * sellPrice) * ( tva / 100)) + (selledQnt * sellPrice) ) FROM Invoice INNER JOIN InvoiceProds ON Invoice.factID = InvoiceProds.factID  WHERE Invoice.factID = '{0}';",
                    invoiceID);
                OleDbCommand getInfo = new OleDbCommand(query, conn);
                await conn.OpenAsync();
                var data = await getInfo.ExecuteReaderAsync();
                DataTable dt = new DataTable();
                dt.Load(data);
                try
                {
                    total = Convert.ToDouble(dt.Rows[0][0]);
                }
                catch { }
                return Math.Round(total, 2); ;
            }
            catch
            {
                return -1;
            }
        }

        // Bon de livraison

        public async Task<bool> getDeliveryProducts(String deliveryId, DataTable dt)
        {

            try
            {
                String query = String.Format("SELECT InvoiceProds.productRef, InvoiceProds.selledQnt, InvoiceProds.sellPrice, InvoiceProds.colis, Product.productName " +
                                             "FROM Product INNER JOIN ((Invoice INNER JOIN Delivery ON Invoice.factID = Delivery.factID) " +
                                             " INNER JOIN InvoiceProds ON Invoice.factID = InvoiceProds.factID) ON Product.productRef = InvoiceProds.productRef " +
                                             " WHERE Delivery.deliveryNum = '{0}'", deliveryId);
                OleDbCommand getInfo = new OleDbCommand(query, conn);
                await conn.OpenAsync();
                var data = await getInfo.ExecuteReaderAsync();

                dt.Load(data);
                return true;

            }
            catch
            {
                return false;
            }

        }

        public async Task<bool> getDeliveryInfo(String deliveryId, DataTable dt)
        {

            try
            {
                String query = String.Format("SELECT Invoice.*, Client.clientName, Client.clientAddress, Client.clientWilaya " +
                         " FROM Client INNER JOIN (Invoice INNER JOIN Delivery ON Invoice.factID = Delivery.factID) ON Client.clientID = Invoice.clientID WHERE Delivery.deliveryNum = '{0}';", deliveryId);
                OleDbCommand getInfo = new OleDbCommand(query, conn);
                await conn.OpenAsync();
                var data = await getInfo.ExecuteReaderAsync();
                dt.Load(data);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public async Task<bool> updateInvoiceStatus
            (String invoiceID)
        {
            try
            {
                String query = String.Format("UPDATE Invoice SET isConfirmed = 1   WHERE factID = '{0}' ;", invoiceID);            
                OleDbCommand cmd = new OleDbCommand(query, conn);
                await conn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}