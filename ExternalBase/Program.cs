using ExternalBase.Features;
using ExternalBase.Utility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExternalBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Process process = Process.GetProcessesByName("csgo").FirstOrDefault(); //get csgo process

            if (process == null) // if csgo is not running, close
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("CS:GO is not running");
                Thread.Sleep(3000);
                Environment.Exit(0); // exit
            }

            if (Mem.Memory.Setup(process)) //setup handles to csgo to read and write memory to
                Mem.Modules.Initialize(process); //get modules such as client.dll and engine.dll once the handle has been setup

            Console.WriteLine($"Process Handle: 0x{Mem.Variables.ProcessHandle.ToString("X")}");

            StartThreads();
            StartMenu();
        }

        static void StartThreads() //start all threads from here
        {
            Thread updater = new Thread(Updater.Run);
            updater.Start();

            Thread bhop = new Thread(Bunnyhop.Run);
            bhop.Start();

            Thread trigger = new Thread(Triggerbot.Run);
            trigger.Start();
        }

        static void StartMenu() //starts the menu form (duh)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
