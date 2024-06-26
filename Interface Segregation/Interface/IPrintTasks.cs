﻿
namespace SOLID_PROJECT.Interface
{
    public interface IPrintTasks
    {
        bool PrintContent(string content);
        bool ScanContent(string content);

     }

    public interface IFaxContet
    {
        bool FaxContent(string content);
    }

    public interface IA3Printer
    {
        bool PrintA3Content(string content);
    }

    public interface IPhotoCopyContent
    {
        bool PhotoCopyContent(string content);
    }
}
