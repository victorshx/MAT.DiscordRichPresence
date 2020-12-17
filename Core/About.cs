using System;
using System.Drawing;
using System.Threading;
using Console = Colorful.Console;

namespace MAT.DiscordRichPresence.Core
{
    class About
    {
        public static void PrintIntro()
        {
            Console.Clear();
            Console.WriteLine(@"

 __        __    _ _   _                __              __  __    _  _____     
 \ \      / /_ _(_) |_(_)_ __   __ _   / _| ___  _ __  |  \/  |  / \|_   _|    
  \ \ /\ / / _` | | __| | '_ \ / _` | | |_ / _ \| '__| | |\/| | / _ \ | |      
   \ V  V / (_| | | |_| | | | | (_| | |  _| (_) | |    | |  | |/ ___ \| |_ _ _ 
    \_/\_/ \__,_|_|\__|_|_| |_|\__, | |_|  \___/|_|    |_|  |_/_/   \_\_(_|_|_)
                               |___/                                           
                                                                               
", ColorTranslator.FromHtml("#8AFFEF"));
        }

        public static void PrintCredits()
        {
            Console.Clear();
            Console.WriteLine(@"
  ____                 _                      _   _            __     ___      _             
 |  _ \  _____   _____| | ___  _ __   ___  __| | | |__  _   _  \ \   / (_) ___| |_ ___  _ __ 
 | | | |/ _ \ \ / / _ \ |/ _ \| '_ \ / _ \/ _` | | '_ \| | | |  \ \ / /| |/ __| __/ _ \| '__|
 | |_| |  __/\ V /  __/ | (_) | |_) |  __/ (_| | | |_) | |_| |   \ V / | | (__| || (_) | |   
 |____/ \___| \_/ \___|_|\___/| .__/ \___|\__,_| |_.__/ \__, |    \_/  |_|\___|\__\___/|_|   
                              |_|                       |___/                                

", Color.OrangeRed);

            Console.Write("Credits: ", Color.Pink);
            Console.Write("Kai Zhe, ", Color.Yellow);
            Console.Write("Kuso", Color.LightGreen);
            Console.Write(Environment.NewLine);
            Console.WriteLine($"URL: {Const.GITHUB_REPO_URL}", Color.SkyBlue);
            Console.Write(Environment.NewLine);
        }

        public static void PrintSorry()
        {
            Console.Clear();
            Console.WriteLine(@"

  ____                             __
 / ___|  ___  _ __ _ __ _   _   _ / /
 \___ \ / _ \| '__| '__| | | | (_) | 
  ___) | (_) | |  | |  | |_| |  _| | 
 |____/ \___/|_|  |_|   \__, | (_) | 
                        |___/     \_\

", Color.DeepPink);

            Console.WriteLine("Multiple instances of MAT is not supported, exiting in 5 seconds.", Color.Red);
            Thread.Sleep(5000);
            Environment.Exit(0);
        }
    }
}
