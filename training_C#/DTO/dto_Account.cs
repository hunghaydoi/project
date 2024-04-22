using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dto_Account
    {
        private string _employeeID;
        private string _password;
        private string _permission;
        public string EmployeeID { get { return _employeeID;} set { _employeeID = value; } }
        public string Password { get { return _password;} set { _password = value; } }
        public string Permission { get { return _permission;} set { _permission = value; } }    
        public dto_Account(string employeeID, string password, string permission)
        {
            this._employeeID = employeeID;
            this._password = password;
            this._permission = permission;
        }
    }
}
