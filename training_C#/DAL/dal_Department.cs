using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dal_Department
    {
        public static DataTable getAllData()
        {
            SqlDataAdapter da = new SqlDataAdapter("TM_Departments_GetAllData",dal_ConnectDB.connect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }//TM_Departments_Insert
        public static DataTable TM_Department_Check_ID(string DepartmentID)
        {
            SqlConnection conn = dal_ConnectDB.connect();
            SqlCommand cmd = new SqlCommand("TM_Department_Check_ID", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DepartmentID", DepartmentID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void  TM_Departments_Insert(dto_Department dto_Department)
        {
            SqlConnection conn = dal_ConnectDB.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("TM_Departments_Insert", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DepartmentID", dto_Department.DepartmentID);
            cmd.Parameters.AddWithValue("@DepartmentName", dto_Department.DepartmentName);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void TM_Deparment_Update(dto_Department dto_Department)
        {
            SqlConnection conn = dal_ConnectDB.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("TM_Deparment_Update", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DepartmentID", dto_Department.DepartmentID);
            cmd.Parameters.AddWithValue("@DepartmentName", dto_Department.DepartmentName);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void TM_Department_Delete(string DepartmentID)
        {
            SqlConnection conn = dal_ConnectDB.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("TM_Department_Delete", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DepartmentID", DepartmentID);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
