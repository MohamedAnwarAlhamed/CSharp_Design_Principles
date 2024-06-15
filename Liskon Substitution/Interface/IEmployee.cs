
namespace SOLID_PROJECT.Interface
{
    interface IEmployee
    {
        int ID { get; set; }
        string Name { get; set; }
        decimal GetMinimumSalary();
    }
}
