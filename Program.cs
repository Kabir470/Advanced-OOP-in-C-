using EmployeeManagerConsoleApp.Classes;

namespace EmployeeManagerConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<AdminMember>admin= new List<AdminMember>();
            Documents document = new Documents();
            Employee employee = new Employee();
            //HrDept hr = new HrDept("hr namecheck", "hr admincheck", 0);
            NoticeBoard noticeBoard = new NoticeBoard();

            
            Console.Write("Enter the number of admin members: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter details for admin member {i + 1}:");
                Console.Write($"Enter name for check {i + 1}: ");
                string? namecheck= Console.ReadLine();
                Console.Write($"Enter admin for check {i + 1}: ");
                string? admincheck = Console.ReadLine();
                Console.Write($"Enter age for check {i + 1}: ");
                int agecheck = Convert.ToInt32(Console.ReadLine());
                admin.Add(new AdminMember(namecheck, admincheck, agecheck));
            }



            //print the list of admin members
            Console.WriteLine("List of Admin Members:");
            
            foreach (var amem in admin)
            {
                amem.printcheck();
            }
            //admin.salary = 50000;
            //for (int i = 0; i < 3; i++)
            //{

            //    //deteils
            //    Console.WriteLine($"Admin Name: {admin.AdminName}");
            //    Console.WriteLine("\nDetails below:");
            //    Console.Write("enter the name: ");
            //    admin.Name = Console.ReadLine();
            //    admin.employeeID = i + 1;
            //    Console.Write("enter the position: ");
            //    admin.Position = Console.ReadLine();
            //    admin.ShowInfo();
            //    noticeBoard.ReadNotice($"{admin.employeeID} --Holiday Notice");
            //    document.CreateDocument($"{admin.employeeID} {admin.Name} --create a docs");

            //    //salary calculation
            //    Console.WriteLine("salary calculation: ");
            //    Console.Write($"enter the salary: {admin.salary}");
            //    int bonus = admin.CalculateBonus();
            //    admin.salary = bonus+ admin.salary;
            //    Console.WriteLine($"\nbonus: {admin.CalculateBonus()}");
            //   // admin.salary = admin.salary + admin.CalculateBonus();
            //    int MainSalary = admin.CalculateSalary(i+1, admin.salary);
            //    Console.WriteLine($"main salary: {MainSalary}\n");

            //}
        }
    }
}
