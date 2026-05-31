using EmployeeManagerConsoleApp.Classes;

namespace EmployeeManagerConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdminMember admin = new AdminMember();
            Documents document = new Documents();
            Employee employee = new Employee();
            HrDept hr = new HrDept();
            NoticeBoard noticeBoard = new NoticeBoard();




            admin.salary = 50000;
            for (int i = 0; i < 3; i++)
            {

                //deteils
                Console.WriteLine($"Admin Name: {admin.AdminName}");
                Console.WriteLine("\nDetails below:");
                Console.Write("enter the name: ");
                admin.Name = Console.ReadLine();
                admin.employeeID = i + 1;
                Console.Write("enter the position: ");
                admin.Position = Console.ReadLine();
                admin.ShowInfo();
                noticeBoard.ReadNotice($"{admin.employeeID} --Holiday Notice");
                document.CreateDocument($"{admin.employeeID} {admin.Name} --create a docs");

                //salary calculation
                Console.WriteLine("salary calculation: ");
                Console.Write($"enter the salary: {admin.salary}");
                int bonus = admin.CalculateBonus();
                admin.salary = bonus+ admin.salary;
                Console.WriteLine($"\nbonus: {admin.CalculateBonus()}");
               // admin.salary = admin.salary + admin.CalculateBonus();
                int MainSalary = admin.CalculateSalary(i+1, admin.salary);
                Console.WriteLine($"main salary: {MainSalary}\n");

            }
        }
    }
}
