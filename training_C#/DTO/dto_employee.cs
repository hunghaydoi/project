using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dto_employee
    {
        private string _EmployeeID;
        private string _FullName;
        private object _DateOfBirth;
        private string _Gender;
        private string _Address;
        private string _PhoneNumber;
        private string _Email;
        private string _DepartmentID;
        private string _PositionID;
        private object _StartDate;
        private object _EndDate;

        public string EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }
        public string FullName
        {
            get { return _FullName; }
            set { _FullName = value; }
        }
        public object DateOfBirth
        {
            get { return _DateOfBirth; }
            set { _DateOfBirth = value; }
        }
        public string Gender
        {
            get { return _Gender; }
            set {_Gender = value;  }
        }
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set { _PhoneNumber = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public string DepartmentID
        {
            get { return _DepartmentID; }
            set { _DepartmentID = value; }
        }
        public string PositionID
        {
            get { return _PositionID; }
            set { _PositionID = value; }
        }
        public object StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }
        public object EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }
        public dto_employee(string employeeID, string fullname, object dateOfBirth, string gender,string address,string phoneNumber,string email
         ,string departmentID
         ,string positionID
         , object startDate
         , object endDate)
        {
            this.EmployeeID= employeeID;
            this.FullName= fullname;
            this.DateOfBirth= dateOfBirth;
            this.Gender= gender;
            this.Address= address;
            this.PhoneNumber= phoneNumber;
            this.Email=email;
            this.DepartmentID= departmentID;
            this.PositionID= positionID;
            this.StartDate= startDate;
            this.EndDate= endDate;
        }
        
    }
}
