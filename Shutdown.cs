// Made By xylo#6666

// Imports:
using System.Diagnostics;

class Shutdown
{
    static void Main(string[] args)
    {
        string filename = "shutdown.exe";
        string arg = "-s";
        var start = new ProcessStartInfo(filename, arg);
        Process.Start(start);
    }
}