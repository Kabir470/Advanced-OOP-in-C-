using EmployeeManagerConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerConsoleApp.Classes
{
    public class Employee : IDocumentAccessEmpolyeeAccess
    {
        private string? documentName;

        public string ReadDocument(string documentName)
        {
            this.documentName = documentName;
            return this.documentName;
        }
    }
}
