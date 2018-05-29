using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarKingrey
{
    class Car
    {
        private int _year;
        private String _make;
        private int _speed;

        public int Year
        {
            get
            {
                return _year;
            }

            set
            {
                _year = value;
            }
        }

        public string Make
        {
            get
            {
                return _make;
            }

            set
            {
                _make = value;
            }
        }

        public int Speed
        {
            get
            {
                return _speed;
            }

            set
            {
                _speed = value;
            }
        }

        //constructor
        public Car(int yr, String mk)
        {
            _year = yr;
            _make = mk;
            _speed = 0;
        }

        //accelerate method
        public void Accelerate()
        {
           _speed += 5;
        }

        public void Brake()
        {
            _speed -= 5;
        }
    }
}
