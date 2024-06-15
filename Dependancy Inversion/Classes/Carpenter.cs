
namespace SOLID_PROJECT.Classes
{
    class Carpenter : IWorker
    {
        public void DoWork()
        {
            FixWindows();
        }

        public void FixWindows() 
        {
            Console.WriteLine("Fix Windows");
        }
    }
}
