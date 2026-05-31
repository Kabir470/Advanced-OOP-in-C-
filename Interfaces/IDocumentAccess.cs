using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerConsoleApp.Interfaces
{
    public interface IDocumentAdminAccess
    {
        string CreateDocument(string documentName);
        void DeleteDocument();
        void UpdateDocument();
        void ReadDocument();

    }
    public interface IDocumentAccessEmployeeAccess
    {
        void ReadDocumentEmployee();

    }
}
