using System;
using Info;
using Salary;

namespace Visitor
{
    class Program
    {
        static ISalaryCalculator calculator = new SalaryCalculator();
        static OfficialStaff[] listStaffs;
        static void Main(string[] args)
        {
            Program.listStaffs = new OfficialStaff[] {
                new Doctor("Doctor A", "Male", new DateTime(1990, 12, 1), "PhD"),
                new Doctor("Doctor A", "Female", new DateTime(1990, 12, 1), "PhD"),
                new Nurse("Nurse A", "Femaie", new DateTime(1990, 12, 1), 15),
                new Nurse("Nurse B", "Female", new DateTime(1990, 12, 1), 20),
                new Guard("Nurse B", "Female", new DateTime(1990, 12, 1), "Guard Agency"),
            };

            DisplayAllSalaries();
        }


        static void DisplayAllSalaries() {
            Console.WriteLine("DISPLAY SALARIES ===========");
            foreach(OfficialStaff staff in listStaffs) {
                long salary = staff.GetSalary(calculator);
                string strSalary = salary > 0 ? $"${salary}" : "Unknown";
                Console.WriteLine($"{staff.Name}: {strSalary}");
            }
        }
    }
}
