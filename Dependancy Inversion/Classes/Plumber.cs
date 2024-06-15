
namespace SOLID_PROJECT.Classes
{
    class Plumber :IWorker
    {
        public void DoWork()
        {
            FixBathroom();
        }

        public void FixBathroom()
        {
            Console.WriteLine("Fix Bathroom");
        }


       

    }
}
