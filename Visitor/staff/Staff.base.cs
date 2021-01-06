using System;
using Salary;

namespace Info {

    public interface ISalaryOwner
    {
        long GetSalary(ISalaryCalculator c);
    }

    public interface IStaff : ISalaryOwner
    { 
        void GetInfo();
    }

    public abstract class OfficialStaff : IStaff {

        protected string name;
        protected string gender;
        protected DateTime dateOfBirth;

        public string Name {
            get => this.name;
        }

        public OfficialStaff(string name, string gender, DateTime dateOfBirth) {
            this.name = name;
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
        }

        public abstract void GetInfo();

        public abstract long GetSalary(ISalaryCalculator c);
    }
}