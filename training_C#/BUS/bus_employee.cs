using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class bus_employee
    {
        public static DataTable getAllData()
        {
            return dal_employee.getAllData();
        }
        public static DataTable TM_Employees_Check_Employee(string employeeID)
        {
            return dal_employee.TM_Employees_Check_Employee(employeeID);
        }
        public static bool TM_Employees_Insert(dto_employee dto_Employee)
        {
            return dal_employee.TM_Employees_Insert(dto_Employee);
        }
        public static bool TM_Employees_Update(dto_employee dto_Employee)
        {
            return dal_employee.TM_Employees_Update(dto_Employee);
        }
        public static bool TM_Employees_Delete(string employee)
        {
            return dal_employee.TM_Employees_Delete(employee);
        }
        public static DataTable TM_Employees_Search_Employee(string employee)
        {
            return dal_employee.TM_Employees_Search_Employee(employee);
        }
        public static DataTable TM_Employees_Search_FullName(string fullname)
        {
            return dal_employee.TM_Employees_Search_FullName(fullname);

        }
        public static DataTable TM_Employees_Search_Gender(string gender)
        {
            return dal_employee.TM_Employees_Search_Gender(gender);
        }
    }
}
