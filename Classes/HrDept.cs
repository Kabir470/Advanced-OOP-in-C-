using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerConsoleApp.Classes
{
    internal class HrDept : AdminMember
    {
        public HrDept(string namecheck, string admincheck, int agecheck) : base(namecheck, admincheck, agecheck)
        {
            Console.WriteLine($"HR Department Member Created: Name Check: {namecheck}, Admin Check: {admincheck}, Age Check: {agecheck}");
        }
    }
}
