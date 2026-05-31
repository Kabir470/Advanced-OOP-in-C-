using EmployeeManagerConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerConsoleApp.Classes
{
    public class AdminMember : SalaryAbstract, IDocumentAdminAccess, IAddEmployee
    {
        public string? testName;
        private string AName = "Kabir daddy";
        public string AdminName
        {
            get { return AName; }
            set { AName = value; }
        }

        public int employeeID { get ; set ; }
        public string? Name { get ; set ; }
        public string? Position { get ; set ; }
        public string? Bonus { get ; set ; }

        //public override void CalculateSalary()
        //{
        //    Console.WriteLine("calculating salary");
        //}
        //public int Salary { get; set; }

        public override int CalculateSalary(int ivalue, int salary)
        {

            return salary+(ivalue*salary);
            

        }

        public void ShowInfo()
        {
            Console.WriteLine($"Employee ID: {employeeID} Empoyee Name: {Name} Position: {Position}");
        }

        public void CreateDocument()
        {
            Console.WriteLine("Documents created");
        }

        public string CreateDocument(string documentName)
        {
            Console.WriteLine($"creating docs: {documentName}");
            return documentName;
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
