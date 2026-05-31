using EmployeeManagerConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerConsoleApp.Classes
{
    public class NoticeBoard : INoticeRead
    {
        public void ReadNotice(string noticeName)
        {
            Console.WriteLine($"Reading notice: {noticeName}");
        }
    }
}
