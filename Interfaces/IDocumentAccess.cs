using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerConsoleApp.Interfaces
{
    interface IDocumentAdminAccess
    {
        void CreateDocument();
        void DeleteDocument();
        void UpdateDocument();
        void ReadDocument();

    }
    interface IDocumentAccessEmpolyeeAccess
    {
        void ReadDocumentEmployee();

    }
}
