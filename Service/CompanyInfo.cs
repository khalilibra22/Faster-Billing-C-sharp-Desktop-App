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
    public class CompanyInfo
    {
        OleDbConnection conn;
        public CompanyInfo()
        {
            try
            {
                conn = new OleDbConnection(database.getConnectionString());
            }
            catch { }
        }

        public async Task<bool> updateInfo
            (String companyName,String activity,String address,String wilaya, String phone, String email,String nrc, String fiscalID, String bankInfo,String nis, String article)
        {
            try
            {

                String query = String.Format("UPDATE ownerInfo SET companyName = '{0}' , activity = '{1}' ,address = '{2}' , wilaya = '{3}', phone= '{4}' , email = '{5}', nrc = '{6}',idFiscal = '{7}',bankInfo = '{8}',nis = '{9}', articleNum = '{10}' ",
                    companyName , activity , address, wilaya , phone , email , nrc , fiscalID, bankInfo,nis,article);

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

        public async Task<DataTable> getOwnerInformation()
        {
            try
            {
                String query = "SELECT * FROM ownerInfo ;";
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

        public async Task<bool> getOwnerInfor2Repport(DataTable dt)
        {
            try
            {
                String query = "SELECT companyName, activity, address, wilaya, phone, email ,nrc, idFiscal , bankInfo , nis, articleNum FROM ownerInfo";
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
