using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dto_Department
    {
        private string _DepartmentID;
        private string _DepartmentName;
        public string DepartmentID { get { return _DepartmentID; } set { _DepartmentID = value; } }
        public string DepartmentName { get { return _DepartmentName; } set { _DepartmentName = value; } }

        public dto_Department(string departmentID, string departmentName)
        {
            this.DepartmentID = departmentID;
            this.DepartmentName = departmentName;
        }
    }
}
