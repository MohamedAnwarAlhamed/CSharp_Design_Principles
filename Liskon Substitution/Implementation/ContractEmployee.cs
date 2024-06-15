
namespace SOLID_PROJECT.Implementation
{
    class ContractEmployee : IEmployee
    {
        public ContractEmployee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public int ID { get ; set; }
        public string Name { get; set; }

        public decimal GetMinimumSalary()
        {
            return 1000;
        }
    }
}
