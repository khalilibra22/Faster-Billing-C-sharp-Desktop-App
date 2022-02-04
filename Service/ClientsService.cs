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
    class ClientsService
    {
        OleDbConnection conn;
        public ClientsService()
        {
            try
            {
                conn = new OleDbConnection(database.getConnectionString());
            }
            catch { }
        }

        public async Task<bool> createNewClient
            (String clientId, String clientNmae, String address, String wilaya, String phone,String email,String username)
        {
            try
            {
                String query = String.Format(
                    "INSERT INTO Client ( clientID , clientName , clientAddress ,clientWilaya, clientPhone , clientEmail, dette ) VALUES ( '{0}' ,'{1}' ,'{2}' , '{3}','{4}','{5}',0);",
                    clientId, clientNmae, address, wilaya, phone, email);

                String historyClient = String.Format("INSERT INTO clientHisto (clientID , username,opDate , op) VALUES ( '{0}' ,'{1}' ,'{2}' , {3} ) ",clientId , username,DateTime.Now,1);

                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbCommand historyCmd = new OleDbCommand(historyClient, conn);
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

        public async Task<DataTable> getAllClients()
        {
            try
            {

                String query = "SELECT * FROM Client ;";
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

        public async Task<bool> deleteClient (String clientId , String username)
        {
            try
            {
                String query = String.Format("DELETE FROM Client WHERE clientID = '{0}' ;", clientId );

                String historyClient = String.Format("INSERT INTO clientHisto (clientID , username,opDate , op) VALUES ( '{0}' ,'{1}' ,'{2}' , {3} ) ", clientId, username, DateTime.Now, 3);

                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbCommand historyCmd = new OleDbCommand(historyClient, conn);
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

        public async Task<bool> updateClient
            (String clientId, String clientName, String address, String wilaya, String phone, String email, String username)
        {
            try
            {
                String query = String.Format("UPDATE Client SET clientName = '{0}' , clientAddress = '{1}' , clientWilaya = '{2}' , clientPhone = '{3}' , clientEmail = '{4}'  WHERE clientID = '{5}' ;",
                     clientName ,address,wilaya,phone,email,clientId);

                String historyClient = String.Format("INSERT INTO clientHisto (clientID , username,opDate , op) VALUES ( '{0}' ,'{1}' ,'{2}' , {3} ) ", clientId, username, DateTime.Now, 2);

                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbCommand historyCmd = new OleDbCommand(historyClient, conn);
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

        public async Task<DataTable> getSearchedClients(String searchedItem)
        {

            try
            {
                String query = String.Format("SELECT * FROM Client WHERE clientName LIKE '%{0}%' ;", searchedItem);

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

        public async Task<bool> updateClientDette
            (String clientID , double amount)
        {
            try
            {
                String query = String.Format("UPDATE Client SET dette = {0}  WHERE clientID = '{1}' ;",
                    amount.ToString().Replace(',', '.'), clientID);               
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

        public async Task<bool> makePayment (String clientID, double amount)
        {
            try
            {          
                String verssementClient = String.Format("INSERT INTO clientVerssements (clientID , amount,verssementDate) VALUES ( '{0}' ,{1} ,'{2}') ", clientID, amount.ToString().Replace(',', '.'), DateTime.Now);            
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



        public async Task<double> getClientDette(String clientID)
        {

            try
            {
                double total = 0.0;
                String query = String.Format(
                    "SELECT dette FROM Client WHERE clientID = '{0}' ;",
                    clientID);
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

        public async Task<bool> getAllDettePerClient(DataTable dt)
        {

            try
            {
                String query = "SELECT clientName, dette FROM Client WHERE dette > 0 ;";
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
