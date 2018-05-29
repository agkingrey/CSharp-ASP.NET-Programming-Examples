using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April11thHomework
{
    class ProductionWorker : Employee
    {
        //fields
        private int _shiftNumber;
        private double _hourlyPayRate;

        //construcotr
        public ProductionWorker()
        {
            ShiftNumber = 0;
            HourlyPayRate = 0;
        }

        //getters and setters
        public int ShiftNumber
        {
            get
            {
                return _shiftNumber;
            }

            set
            {
                _shiftNumber = value;
            }
        }

        public double HourlyPayRate
        {
            get
            {
                return _hourlyPayRate;
            }

            set
            {
                _hourlyPayRate = value;
            }
        }
    }
}
