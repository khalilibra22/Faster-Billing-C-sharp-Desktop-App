using Facturation.Config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturation.Service
{
    public class SuppliersService
    {
        OleDbConnection conn;

        public SuppliersService()
        {
            try
            {
                conn = new OleDbConnection(database.getConnectionString());
            }
            catch { }
        }

        public async Task<bool> createNewSupplier
            (String supplierId, String supplierName, String address, String wilaya, String phone, String email)
        {
            try
            {
                String query = String.Format(
                    "INSERT INTO Supplier ( supplierID , supplierName , supplierAddress , supplierWilaya ,supplierPhone, supplierEmail , suppDette) VALUES ( '{0}' ,'{1}' ,'{2}' , '{3}','{4}','{5}',0);",
                    supplierId, supplierName, address, wilaya, phone, email);


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

        public async Task<DataTable> getAllSuppliers()
        {
            try
            {

                String query = "SELECT * FROM Supplier ;";
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

        public async Task<DataTable> getSearchedSuppliers(String name)
        {
            try
            {

                String query = String.Format( "SELECT * FROM Supplier WHERE supplierName LIKE '%{0}%'  ;",name);
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

        public async Task<bool> deleteSupplier(String supplierID)
        {
            try
            {
                String query = String.Format("DELETE FROM Supplier WHERE supplierID = '{0}' ;", supplierID);

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

        public async Task<bool> updateSupplier
            (String supplierId, String supplierName, String address, String wilaya, String phone, String email)
        {
            try
            {
                String query = String.Format("UPDATE Supplier SET supplierName = '{0}' , supplierAddress = '{1}' , supplierWilaya = '{2}' , supplierPhone = '{3}' , supplierEmail = '{4}'  WHERE supplierID = '{5}' ;",
                     supplierName, address, wilaya, phone, email, supplierId);
               
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

        public async Task<double> getSupplierDette(String supplierID)
        {

            try
            {
                double total = 0.0;
                String query = String.Format(
                    "SELECT suppDette FROM Supplier WHERE supplierID = '{0}' ;",
                    supplierID);
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

        public async Task<bool> updateSuppliertDette
            (String supplierID, double amount)
        {
            try
            {
                String query = String.Format("UPDATE Supplier SET suppDette = {0}  WHERE supplierID = '{1}' ;",
                    amount.ToString().Replace(',', '.'), supplierID);
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

        public async Task<bool> makeOutPayment(String supplierID, double amount)
        {
            try
            {
                String verssementClient = String.Format("INSERT INTO outVerssements (supplierID , amount,verssementDate) VALUES ( '{0}' ,{1} ,'{2}') ", supplierID, amount.ToString().Replace(',', '.'), DateTime.Now);
                OleDbCommand vessementCmd = new OleDbCommand(verssementClient, conn);
                await conn.OpenAsync();
                await vessementCmd.ExecuteNonQueryAsync();
                conn.Close();

                return true;
            }
            catch
            {
                return false;
            }

        }


        // POUR LES ACHAT

        public async Task<bool> createNewInvoice
            (String InvoiceId, String invoiceDate, String supplierId, DataTable products)
        {
            try
            {
                String InvoiceQuery = String.Format(
                    "INSERT INTO Buying ( buyingNum , buyDate , supplierID ) VALUES ( '{0}' ,'{1}' ,'{2}' );",
                    InvoiceId, invoiceDate, supplierId);


                OleDbCommand InviiceCmd = new OleDbCommand(InvoiceQuery, conn);
                await conn.OpenAsync();
                await InviiceCmd.ExecuteNonQueryAsync();
                conn.Close();
                await addProductsToInvoice(InvoiceId, products);


                return true;
            }
            catch
            {
                return false;
            }

        }

        private async Task addProductsToInvoice(String invoiceId, DataTable products)
        {
            try
            {
                for (int i = 0; i < products.Rows.Count; i++)
                {
                    String InvoiceProductsQuery = String.Format(
                    "INSERT INTO Buyedprods ( buyingNum , productRef , buyPrice ,buyQuantity ) VALUES ( '{0}' ,'{1}' ,{2} , {3} );",
                    invoiceId, products.Rows[i][0], products.Rows[i][1].ToString().Replace(',', '.'), products.Rows[i][2]);

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


        public async Task<bool> getBuyingProducts(String buyingId, DataTable dt)
        {

            try
            {
                String query = String.Format("SELECT Buyedprods.buyingNum, Buyedprods.productRef, Buyedprods.buyPrice, Buyedprods.buyQuantity, Product.productName FROM (Buyedprods INNER JOIN Product ON Buyedprods.productRef = Product.productRef ) WHERE Buyedprods.buyingNum = '{0}'", buyingId);
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

        public async Task<bool> getBuyingInfo(String buyingId, DataTable dt)
        {

            try
            {
                String query = String.Format("SELECT Buying.supplierID, Buying.buyDate, Buying.buyingNum, Supplier.supplierName, Supplier.supplierAddress, Supplier.supplierWilaya FROM (Buying INNER JOIN Supplier ON Buying.supplierID = Supplier.supplierID ) WHERE Buying.buyingNum = '{0}'", buyingId);
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

        public async Task<bool> getAllDette(DataTable dt)
        {

            try
            {
                String queryClient = "SELECT SUM(Client.dette) AS clientDette FROM Client;";
                String querySupplier = "SELECT SUM(Supplier.suppDette) AS supplierDette FROM Supplier;";
                OleDbCommand getInfoClilent = new OleDbCommand(queryClient, conn);
                OleDbCommand getInfoSupplier = new OleDbCommand(querySupplier, conn);
                await conn.OpenAsync();
                var dataClient = await getInfoClilent.ExecuteReaderAsync();
                var dataSupplier = await getInfoSupplier.ExecuteReaderAsync();
                dt.Load(dataClient);
                while (dataSupplier.Read())
                {
                    dt.Rows[0][1] = dataSupplier.GetValue(0);
                }

                
                return true;
        }
            catch
            {
                return false;
            }

        }

        public async Task<bool> getAllDettePerSupplier(DataTable dt)
        {

            try
            {
                String query = "SELECT supplierName, suppDette FROM Supplier WHERE suppDette";
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



    }
}













