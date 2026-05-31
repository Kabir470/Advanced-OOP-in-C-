using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerConsoleApp.Interfaces
{
    interface IAddEmployee
    {
        int employeeID { get; set; }
        string Name { get; set; }
        string Position { get; set; }
        int Salary { get; set; }
        
    }
}
