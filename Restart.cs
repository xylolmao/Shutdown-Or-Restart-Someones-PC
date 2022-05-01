// Made By xylo#6666

//Imports:
using System.Diagnostics;

class Restart
{
    static void Main(string[] args)
    {
        string filename = "shutdown.exe";
        string arg = "-r";
        var start = new ProcessStartInfo(filename, arg);
        Process.Start(start);
    }
}

