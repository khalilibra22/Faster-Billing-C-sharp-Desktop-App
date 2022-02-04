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
    public class DeplacementService
    {
        OleDbConnection conn;

        public DeplacementService()
        {
            try
            {
                conn = new OleDbConnection(database.getConnectionString());
            }
            catch { }
        }

        public async Task<bool> createNewDeplacement
           (String deplacementNum, String dplcName, String dplcPhone, String dplcAddress)
        {
            try
            {
                String query = String.Format(
                    "INSERT INTO Deplacement ( deplacementNum , dplcName , dplcPhone , dplcAddress ) VALUES ( '{0}' ,'{1}' ,'{2}' , '{3}');",
                    deplacementNum, dplcName, dplcPhone, dplcAddress);


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

        public async Task<DataTable> getAllDeplacements()
        {
            try
            {

                String query = "SELECT * FROM Deplacement ;";
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

        public async Task<bool> ProdDeplacement
           (String deplacementNum, String ProdRef, int Qnt, String deplcDate)
        {
            try
            {
                String query = String.Format(
                    "INSERT INTO ProdPlacement (productRef, deplacementNum , delapecedQuantity , deplcDate) VALUES ( '{0}' ,'{1}' , {2} , '{3}');",
                    ProdRef,deplacementNum, Qnt, deplcDate);

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

        public async Task<DataTable> getAllProdDeplacements()
        {
            try
            {

                String query = "SELECT Product.productRef, Product.productName, Deplacement.dplcName, ProdPlacement.delapecedQuantity,ProdPlacement.deplcDate ,Deplacement.dplcPhone FROM Product INNER JOIN (Deplacement INNER JOIN ProdPlacement ON Deplacement.deplacementNum = ProdPlacement.deplacementNum) ON Product.productRef = ProdPlacement.productRef ORDER BY ProdPlacement.deplcDate DESC;";
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
