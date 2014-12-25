using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEmployeeApp
{
    class salaryClass
    {
        public string employeeName;
        public double basicAmount;
        public double medicalAmount;
        public double houseRent;

        public double totalFunction()
        {
            double temp = (medicalAmount/100)*basicAmount + (houseRent/100)*basicAmount;
            return temp + basicAmount;
        }

    }
}
