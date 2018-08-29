using System;

namespace welcomescreen
{
    class Program
    {
        static void Main(string[] args)
        {       
            var clr = Console.ForegroundColor;     
            Console.ForegroundColor=ConsoleColor.Yellow;   
            string title = @" /\ /\| |__  _   _ _ __ | |_ _   _      /\ \ \/__\/__   \   / __\___  _ __ ___ 
/ / \ \ '_ \| | | | '_ \| __| | | |    /  \/ /_\    / /\/  / /  / _ \| '__/ _ \
\ \_/ / |_) | |_| | | | | |_| |_| |  _/ /\  //__   / /    / /__| (_) | | |  __/
 \___/|_.__/ \__,_|_| |_|\__|\__,_| (_)_\ \/\__/   \/     \____/\___/|_|  \___|";

        System.Console.WriteLine(title);
        Console.ForegroundColor=clr;
        System.Console.WriteLine("Vijaya Sekhar Gullapalli. sekhargullapalli@gmail.com");
        }
    }
}
