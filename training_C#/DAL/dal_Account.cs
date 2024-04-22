using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dal_Account
    {
        public static DataTable TM_Account_GetAll()
        {
            SqlDataAdapter da = new SqlDataAdapter("TM_Account_GetAll", dal_ConnectDB.connect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable Login(dto_Account dto_Account)
        {
            SqlConnection conn= dal_ConnectDB.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("TM_Account_Login",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@employeeID",dto_Account.EmployeeID);
            cmd.Parameters.AddWithValue("@password", dto_Account.Password);
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            
        }
        public static DataTable TM_Account_Check_ID(string employeeID)
        {
            SqlConnection conn = dal_ConnectDB.connect();
            SqlCommand cmd = new SqlCommand("TM_Account_Check_ID", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@employeeID", employeeID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void TM_Account_Insert(dto_Account dto_Account)
        {
            SqlConnection conn = dal_ConnectDB.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("TM_Account_Insert", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@employeeID", dto_Account.EmployeeID);
            cmd.Parameters.AddWithValue("@password", dto_Account.Password);
            cmd.Parameters.AddWithValue("@permission", dto_Account.Permission);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void TM_Account_Update(dto_Account dto_Account)
        {
            SqlConnection conn = dal_ConnectDB.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("TM_Account_Update", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@employeeID", dto_Account.EmployeeID);
            cmd.Parameters.AddWithValue("@password", dto_Account.Password);
            cmd.Parameters.AddWithValue("@permission", dto_Account.Permission);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void TM_Account_Delete(string employeeID)
        {
            SqlConnection conn = dal_ConnectDB.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("TM_Account_Delete", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@employeeID", employeeID);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
