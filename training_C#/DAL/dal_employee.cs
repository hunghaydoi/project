using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
namespace DAL
{
    public class dal_employee
    {
        public static DataTable TM_Employees_Search_Employee(string employee)
        {
            SqlConnection conn = dal_ConnectDB.connect();
            SqlCommand cmd = new SqlCommand("TM_Employees_Search_Employee", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmployeeID", employee);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable TM_Employees_Search_FullName(string fullname)
        {
            SqlConnection conn = dal_ConnectDB.connect();
            SqlCommand cmd = new SqlCommand("TM_Employees_Search_FullName", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FullName", fullname);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable TM_Employees_Search_Gender(string gender)
        {
            SqlConnection conn = dal_ConnectDB.connect();
            SqlCommand cmd = new SqlCommand("TM_Employees_Search_Gender", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Gender", gender);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public static DataTable getAllData()
        {
            SqlConnection conn = dal_ConnectDB.connect();
            SqlDataAdapter da = new SqlDataAdapter("TM_Emplyees_GetAllData", conn);
            DataTable dt= new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable TM_Employees_Check_Employee(string employeeID)
        {
            SqlConnection conn = dal_ConnectDB.connect();
            SqlCommand cmd = new SqlCommand("TM_Employees_Check_Employee", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static bool TM_Employees_Insert(dto_employee dto_Employee)
        {
            SqlConnection conn= dal_ConnectDB.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("TM_Employees_Insert", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmployeeID", dto_Employee.EmployeeID);
            cmd.Parameters.AddWithValue("@FullName", dto_Employee.FullName);
            cmd.Parameters.AddWithValue("@DateOfBirth", dto_Employee.DateOfBirth);
            cmd.Parameters.AddWithValue("@Gender", dto_Employee.Gender);
            cmd.Parameters.AddWithValue("@Address", dto_Employee.Address);
            cmd.Parameters.AddWithValue("@PhoneNumber", dto_Employee.PhoneNumber);
            cmd.Parameters.AddWithValue("@Email", dto_Employee.Email);
            cmd.Parameters.AddWithValue("@DepartmentID", dto_Employee.DepartmentID);
            cmd.Parameters.AddWithValue("@PositionID", dto_Employee.PositionID);
            cmd.Parameters.AddWithValue("@StartDate", dto_Employee.StartDate);
            cmd.Parameters.AddWithValue("@EndDate", dto_Employee.EndDate);
            if (cmd.ExecuteNonQuery() > 0)
            {
                conn.Close();
                return true;
            }
            return false;

        }
        public static bool TM_Employees_Update(dto_employee dto_Employee)
        {
            SqlConnection conn = dal_ConnectDB.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("TM_Employees_Update", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmployeeID", dto_Employee.EmployeeID);
            cmd.Parameters.AddWithValue("@FullName", dto_Employee.FullName);
            cmd.Parameters.AddWithValue("@DateOfBirth", dto_Employee.DateOfBirth);
            cmd.Parameters.AddWithValue("@Gender", dto_Employee.Gender);
            cmd.Parameters.AddWithValue("@Address", dto_Employee.Address);
            cmd.Parameters.AddWithValue("@PhoneNumber", dto_Employee.PhoneNumber);
            cmd.Parameters.AddWithValue("@Email", dto_Employee.Email);
            cmd.Parameters.AddWithValue("@DepartmentID", dto_Employee.DepartmentID);
            cmd.Parameters.AddWithValue("@PositionID", dto_Employee.PositionID);
            cmd.Parameters.AddWithValue("@StartDate", dto_Employee.StartDate);
            cmd.Parameters.AddWithValue("@EndDate", dto_Employee.EndDate);
            if (cmd.ExecuteNonQuery() > 0)
            {
                conn.Close();
                return true;
            }
            return false;

        }
        public static bool TM_Employees_Delete(string employee)
        {
            SqlConnection conn = dal_ConnectDB.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("TM_Employees_Delete", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmployeeID", employee);
            if (cmd.ExecuteNonQuery() > 0)
            {
                conn.Close();
                return true;
            }
            return false;

        }

    }
}
