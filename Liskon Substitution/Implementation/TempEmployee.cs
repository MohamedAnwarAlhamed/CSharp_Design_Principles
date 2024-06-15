
namespace SOLID_PROJECT.Implementation
{
    class TempEmployee : Employee
    {

        public TempEmployee(int id, string name) : base(id, name)
        { }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }

        public override decimal GetMinimumSalary()
        {
            return 5000;
        }
    }
}
