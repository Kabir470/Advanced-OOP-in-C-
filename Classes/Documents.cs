using EmployeeManagerConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerConsoleApp.Classes
{
    internal class Documents : IDocumentAdminAccess, IDocumentAccessEmpolyeeAccess
    {
        public void CreateDocument()
        {
            Console.WriteLine("admin created a document");
        }

        public void DeleteDocument()
        {
            Console.WriteLine("admin deleted a document");
        }

        public void ReadDocument()
        {
            Console.WriteLine("admin read a document");
        }

        public void ReadDocumentEmployee()
        {
            Console.WriteLine("employee read a document");
        }

        public void UpdateDocument()
        {
            Console.WriteLine("admin updated a document");
        }
    }
}
