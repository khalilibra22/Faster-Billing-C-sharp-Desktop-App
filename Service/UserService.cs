using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturation.Config;
using System.Data;
using System.Data.OleDb;

namespace Facturation.Service
{
    public class UserService
    {
        OleDbConnection conn;
        public UserService()
        {
            try
            {
                conn = new OleDbConnection(database.getConnectionString());
            }
            catch { }
        }

        public async Task<bool> createNewUser(String username, String pass, int isSupervisor, DateTime loginTime)
        {
            try
            {
                String query = String.Format(
                    "INSERT INTO Admin ( username , pass , isSupervisor , lastLogin ) VALUES ( '{0}' ,'{1}' ,{2} , '{3}' );",
                    username, pass, isSupervisor, loginTime);

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

        public async Task<bool> login(String username, String password)
        {
            try
            {
                String query = String.Format("SELECT pass FROM Admin WHERE  username = '{0}' ;", username);
                OleDbCommand getPassword = new OleDbCommand(query, conn);
                await conn.OpenAsync();
                var data = await getPassword.ExecuteReaderAsync();
                DataTable dt = new DataTable();
                dt.Load(data);
                conn.Close();
                if (dt.Rows.Count == 0) return false;
                if (dt.Rows[0][0].ToString() == password) return true;
                return false;
            }
            catch
            {
                return false;
            }

        }

        public async Task<DataTable> getUserInfo(String username)
        {
            try
            {
                String query = String.Format("SELECT * FROM Admin WHERE  username = '{0}' ;", username);
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

        public async Task<bool> updateLastlogin(DateTime lastlogin,String username)
        {
            try{

                String query = String.Format("UPDATE Admin SET lastLogin = '{0}' WHERE username = '{1}'", lastlogin, username);

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

        public async Task<bool> updatePassword(String newPassword, String username)
        {
            try
            {

                String query = String.Format("UPDATE Admin SET pass = '{0}' WHERE username = '{1}'", newPassword, username);

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
