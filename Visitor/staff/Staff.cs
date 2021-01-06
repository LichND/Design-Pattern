
using System;
using Salary;

namespace Info {

    public class Doctor : OfficialStaff {

        protected string education;
        public Doctor(string name, string gender, DateTime dateOfBirth, string education) 
        : base(name, gender, dateOfBirth) {
            this.education = education;
        }

        public override void GetInfo() {
            Console.WriteLine("Info of doctor =========== ");
            Console.WriteLine($"Name: {this.name}");
            Console.WriteLine($"Gender: {this.gender}");
            Console.WriteLine($"DateOfBirth: {this.dateOfBirth.ToShortDateString()}");
        }

        public override long GetSalary(ISalaryCalculator e) {
            return e.GetSalaryForDoctor(this);
        }
    }

    public class Nurse : OfficialStaff {

        protected int daysOfWork;

        public int DaysOfWork { 
            get => this.daysOfWork;
        }

        public Nurse(string name, string gender, DateTime dateOfBirth, int daysOfWork) 
        : base(name, gender, dateOfBirth) {
            this.daysOfWork = daysOfWork;
        }

        public override void GetInfo() {
            Console.WriteLine("Info of nurse ============ ");
            Console.WriteLine($"Name: {this.name}");
            Console.WriteLine($"Gender: {this.gender}");
            Console.WriteLine($"DateOfBirth: {this.dateOfBirth.ToShortDateString()}");
        }

        public override long GetSalary(ISalaryCalculator e) {
            return e.GetSalaryForNurse(this);
        }
    }
    public class Guard : OfficialStaff {

        protected string company;
        public Guard(string name, string gender, DateTime dateOfBirth, string company) 
        : base(name, gender, dateOfBirth) {
            this.company = company;
        }

        public override void GetInfo() {
            Console.WriteLine("Info of guard ============ ");
            Console.WriteLine($"Name: {this.name}");
            Console.WriteLine($"Gender: {this.gender}");
            Console.WriteLine($"Date of birth: {this.dateOfBirth.ToShortDateString()}");
            Console.WriteLine($"Company: {this.company}");
        }

        public override long GetSalary(ISalaryCalculator e) {
            return -1;
        }
    }
}