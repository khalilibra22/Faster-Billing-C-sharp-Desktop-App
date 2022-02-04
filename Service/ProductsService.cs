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
    public class ProductsService
    {
        OleDbConnection conn;

        public ProductsService()
        {
            try
            {
                conn = new OleDbConnection(database.getConnectionString());
            }
            catch { }
        }

        public async Task<bool> createNewProduct
            (String prodRef, String prodNmae, double defaultPrice, int stockQuantity, int qntNotifLimit, double buyPrice, String username)
        {
            try
            {
                String query = String.Format(
                    "INSERT INTO Product ( productRef , productName , prodDefaultPrice ,QntInStock, QntNotifLimit ,prodBuyPrice) VALUES ( '{0}' ,'{1}' ,{2} , {3} , {4},{5});",
                    prodRef , prodNmae , defaultPrice.ToString().Replace(',','.'),stockQuantity, qntNotifLimit, buyPrice.ToString().Replace(',', '.'));

                String productHistory = String.Format("INSERT INTO productHisto (productRef , username,opDate , op) VALUES ( '{0}' ,'{1}' ,'{2}' , {3} ) ",prodRef, username, DateTime.Now, 1);

                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbCommand historyCmd = new OleDbCommand(productHistory, conn);
                await conn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
                await historyCmd.ExecuteNonQueryAsync();
                conn.Close();

                return true;
            }
            catch
            {
                return false;
            }

        }

        public async Task<DataTable> getAllProducts()
        {
            try
            {

                String query = "SELECT * FROM Product ;";
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

        public async Task<bool> deleteCProduct(String prodRef, String username)
        {
            try
            {
                String query = String.Format("DELETE FROM Product WHERE productRef = '{0}' ;", prodRef);

                String productHistory = String.Format("INSERT INTO productHisto (productRef , username,opDate , op) VALUES ( '{0}' ,'{1}' ,'{2}' , {3} ) ", prodRef, username, DateTime.Now, 3);

                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbCommand historyCmd = new OleDbCommand(productHistory, conn);
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

        public async Task<bool> updateProduct
            (String prodRef, String prodNmae, double defaultPrice, int stockQuantity, int qntNotifLimit,double buyPrice ,String username)
        {
            try
            {
                String query = String.Format("UPDATE Product SET productName = '{0}' , prodDefaultPrice = {1} , QntInStock = {2} , QntNotifLimit = {3},prodBuyPrice = {4}  WHERE productRef = '{5}' ;",
                     prodNmae, defaultPrice.ToString().Replace(',', '.') , stockQuantity, qntNotifLimit, buyPrice.ToString().Replace(',', '.'), prodRef);

                String productHistory = String.Format("INSERT INTO productHisto (productRef , username,opDate , op) VALUES ( '{0}' ,'{1}' ,'{2}' , {3} ) ", prodRef, username, DateTime.Now, 2);

                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbCommand historyCmd = new OleDbCommand(productHistory, conn);
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

        public async Task<DataTable> getSearchedProducts(String searchedItem)
        {

            try
            {
                String query = String.Format("SELECT * FROM Product WHERE productName LIKE '%{0}%' ;", searchedItem);
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

        public async Task<int> getProductsStockQuantity(String productRefrence)
        {

            try
            {
                String query = String.Format("SELECT QntInStock FROM Product WHERE productRef = '{0}' ;", productRefrence);
                OleDbCommand getInfo = new OleDbCommand(query, conn);
                await conn.OpenAsync();
                var data = await getInfo.ExecuteReaderAsync();
                DataTable dt = new DataTable();
                dt.Load(data);
                int quantity = Convert.ToInt32(dt.Rows[0][0]);
                return quantity;
            }
            catch
            {
                return -1;
            }

        }

        public async Task<bool> updateProductsQuantities(Dictionary<string,int> productsQuantities)
        {
            try
            {
                foreach(KeyValuePair<string,int> item in productsQuantities)
                {
                    String InvoiceProductsQuery = String.Format(
                    "UPDATE Product SET QntInStock = {0} WHERE productRef = '{1}'  ;" , item.Value, item.Key);
                    OleDbCommand cmd = new OleDbCommand(InvoiceProductsQuery, conn);
                    await conn.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    conn.Close();
                }

                return true;

            }
            catch
            {
                return false;
            }

        }

        public async Task<DataTable> getInvoiceProductsQuantities(String invoiceNum)
        {

            try
            {
                String query = String.Format(
                    "SELECT  Product.productRef, Product.QntInStock, InvoiceProds.selledQnt FROM Product INNER JOIN InvoiceProds ON Product.productRef = InvoiceProds.productRef WHERE (((InvoiceProds.factID)='{0}'));", invoiceNum);
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



    }
}
