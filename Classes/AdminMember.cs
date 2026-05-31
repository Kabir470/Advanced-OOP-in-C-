using EmployeeManagerConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerConsoleApp.Classes
{
    public class AdminMember : SalaryAbstract, IDocumentAdminAccess, IAddEmployee 
    {
        public int employeeID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Salary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void CalculateSalary()
        {
            Console.WriteLine("calculating salary");
        }

        public void CreateDocument()
        {
            Console.WriteLine("Documents created");
        }

        public void DeleteDocument()
        {
            Console.WriteLine("Documents deleted");
        }

        public void ReadDocument()
        {
            Console.WriteLine("Documents read");
        }

        public void UpdateDocument()
        {
            Console.WriteLine("Documents updated");
        }
    }
}
