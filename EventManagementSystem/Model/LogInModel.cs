using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using EventManagementSystem.Controller;
using System.Data.SqlClient;

namespace EventManagementSystem.Model
{
    class LogInModel
    {

       
    
       
        

        public int CheckValidity(LogInController lc) {
            SakiDataSet ds = new SakiDataSet();
            string type="";
            string uName = lc.UserName;
            string pwd = lc.Password;
            switch (lc.TypeOfUser) {
                case 0: type = "RECEPTION";
                    break;

                case 1: type = "COORDINATOR";
                    break;

                case 2: type = "CASHIER";
                    break;

                case 3: type = "ADMINISTRATOR";
                    break;

            }

            
            DataTable dt = new DataTable();
            dt = ds.Tables["AccessControlTable"];
           
            DataRow[] result = dt.Select("AccessType like '%"+type+"%'");
            //DataRow[] result = dt.Select("UserName like '%"+uName+"%'");
            //DataRow[] result = dt.Select("Password like '%"+pwd+"%'");

            
            if (result.Length != 0)
                return 1;
            
            else
                return -1;
    }  

    }

        
    
}
