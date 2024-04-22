using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class bus_Department
    {
        public static DataTable getAllData()
        {
            return dal_Department.getAllData();
        }
        public static DataTable TM_Department_Check_ID(string DepartmentID)
        {
            return dal_Department.TM_Department_Check_ID(DepartmentID);
        }
        public static void TM_Departments_Insert(dto_Department dto_Department)
        {
            dal_Department.TM_Departments_Insert(dto_Department);
        }
        public static void TM_Deparment_Update(dto_Department dto_Department)
        {
            dal_Department.TM_Deparment_Update(dto_Department);
        }
        public static void TM_Department_Delete(string Department)
        {
            dal_Department.TM_Department_Delete(Department);
        }
    }
}
