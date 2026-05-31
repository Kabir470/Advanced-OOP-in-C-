using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerConsoleApp.Interfaces
{
    interface INoticeRead
    {
        public void ReadNotice(string noticeName)
        {
            Console.WriteLine($"Reading notice: {noticeName}");
        }
       
    }
}
