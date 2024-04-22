using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class bus_Account
    {
        public static DataTable TM_Account_GetAll()
        {
            return dal_Account.TM_Account_GetAll();
        }
        public static DataTable Login(dto_Account dto_Account)
        {
            return dal_Account.Login(dto_Account);
        }
        public static DataTable TM_Account_Check_ID(string employeeID)
        {
            return dal_Account.TM_Account_Check_ID(employeeID);
        }
        public static void TM_Account_Insert(dto_Account dto_Account)
        {
            dal_Account.TM_Account_Insert(dto_Account);
        }
        public static void TM_Account_Update(dto_Account dto_Account)
        {
            dal_Account.TM_Account_Update(dto_Account);
        }
        public static void TM_Account_Delete(string employeeID)
        {
            dal_Account.TM_Account_Delete(employeeID);

        }
    }
}
