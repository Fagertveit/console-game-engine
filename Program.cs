using System.Diagnostics;
using System.Runtime.InteropServices;
using ConsoleGameEngine;



class Program
{
    [DllImport("libc")]
    static extern int system(string exec);

    public static void Main(string[] args)
    {
        system(@"printf '\e[8;60;180t]'");
        Core core = new Core();

        core.Init();
        core.Run();
    }
}
