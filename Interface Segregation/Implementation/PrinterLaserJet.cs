
namespace SOLID_PROJECT.Implementation
{
    class PrinterLaserJet : IPrintTasks, IFaxContet, IPhotoCopyContent, IA3Printer
    {

        public bool FaxContent(string content)
        {
            Console.WriteLine("Fax Done");
            return true;
        }

        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("PhotoCopy Done");
            return true;
        }

        public bool PrintA3Content(string content)
        {
            throw new NotImplementedException();
        }

        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done");
            return true;
        }

        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan Done");
            return true;
        }
    }
}
