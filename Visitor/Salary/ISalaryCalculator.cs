

using Info;

namespace Salary
{
    public interface ISalaryCalculator
    {
        long GetSalaryForDoctor(Doctor doctor);
        long GetSalaryForNurse(Nurse nurse);
    }

    public class SalaryCalculator : ISalaryCalculator
    {
        private const long GROUND_SALARY = 1500; 
        public long GetSalaryForDoctor(Doctor doctor)
        {
            return (long)(1.5 * SalaryCalculator.GROUND_SALARY);     
        }

        public long GetSalaryForNurse(Nurse nurse)
        {
            return nurse.DaysOfWork * 300;
        }
    }
}