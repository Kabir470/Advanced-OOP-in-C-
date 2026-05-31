using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerConsoleApp.Classes
{
    abstract class SalaryAbstract
    {
        private int salary;
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public int CalculateBonus()
        {
            return Salary / 10;
        }
        public abstract void CalculateSalary();
    }
}
