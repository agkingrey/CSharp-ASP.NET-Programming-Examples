using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April11thHomework
{
    class Employee
    {
        //fields
        private String _employeeName;
        private int _employeeNumber;

        //constructor
        public Employee()
        {
            EmployeeName = "";
            EmployeeNumber = 0;
        }

        public string EmployeeName
        {
            get
            {
                return _employeeName;
            }

            set
            {
                _employeeName = value;
            }
        }

        public int EmployeeNumber
        {
            get
            {
                return _employeeNumber;
            }

            set
            {
                _employeeNumber = value;
            }
        }

        //setters and getters

    }
}
