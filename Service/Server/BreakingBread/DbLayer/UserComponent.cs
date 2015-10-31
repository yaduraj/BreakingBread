using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace BreakingBread.Service
{
    public class UserComponent
    {
        public void AddUser(User user)
        {
            IDBManager dbManager = new DBManager(DataProvider.SqlServer);
            dbManager.ConnectionString = ConfigurationSettings.AppSettings["ConnectionString"].ToString();
            try
            {
                dbManager.Open();
                dbManager.CreateParameters(3);
                dbManager.AddParameters(0, "@userId", user.UserId);
                dbManager.AddParameters(1, "@name", user.Name);
                dbManager.AddParameters(2, "@mobile", user.MobileNumber);
                dbManager.ExecuteNonQuery(CommandType.StoredProcedure, "prc_AddUser");
            }
            catch (Exception ex)
            {
                //Usual code              
            }
            finally
            {
                dbManager.Dispose();
            }
        }

    }
}