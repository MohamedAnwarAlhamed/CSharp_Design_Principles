﻿
namespace SOLID_PROJECT.Implementation
{
    class PermanentEmployee : Employee
    {

        public PermanentEmployee(int id, string name) : base(id, name)
        { }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }

        public override decimal GetMinimumSalary()
        {
            return 15000;
        }
    }
}
