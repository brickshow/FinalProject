﻿namespace INVENTORYSYSTEM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;  
            Console.WriteLine("\n\n\n");
            Console.WriteLine(@"
                                       ████████╗███████╗░█████╗░██╗░░██╗░██████╗████████╗░█████╗░░█████╗░██╗░░██╗
                                       ╚══██╔══╝██╔════╝██╔══██╗██║░░██║██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██║░██╔╝
                                       ░░░██║░░░█████╗░░██║░░╚═╝███████║╚█████╗░░░░██║░░░██║░░██║██║░░╚═╝█████═╝░
                                       ░░░██║░░░██╔══╝░░██║░░██╗██╔══██║░╚═══██╗░░░██║░░░██║░░██║██║░░██╗██╔═██╗░
                                       ░░░██║░░░███████╗╚█████╔╝██║░░██║██████╔╝░░░██║░░░╚█████╔╝╚█████╔╝██║░╚██╗
                                       ░░░╚═╝░░░╚══════╝░╚════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░░╚════╝░░╚════╝░╚═╝░░╚═╝");

            Console.WriteLine("\t\t\t =========================================================================================================");
            Console.WriteLine(@"
                        ░█▀▀█ █▀▀█ █▀▀█ ▀▀█▀▀ █▀▀ 　 ▀█▀ █▀▀▄ ▀█─█▀ █▀▀ █▀▀▄ ▀▀█▀▀ █▀▀█ █▀▀█ █  █ 　 ░█▀▀▀█ █  █ █▀▀ ▀▀█▀▀ █▀▀ █▀▄▀█ 
                        ░█▄▄█ █▄▄█ █▄▄▀   █   ▀▀█ 　 ░█  █  █  █▄█  █▀▀ █  █   █   █  █ █▄▄▀ █▄▄█ 　  ▀▀▀▄▄ █▄▄█ ▀▀█   █   █▀▀ █ ▀ █ 
                        ░█    ▀  ▀ ▀ ▀▀   ▀   ▀▀▀ 　 ▄█▄ ▀  ▀   ▀   ▀▀▀ ▀  ▀   ▀   ▀▀▀▀ ▀─▀▀ ▄▄▄█ 　 ░█▄▄▄█ ▄▄▄█ ▀▀▀   ▀   ▀▀▀ ▀   ▀");



            Console.WriteLine("\n\n\n\n\n\n\n");
            ProgressBar();
            Console.ReadKey();
        }



        public static void ProgressBar()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("█");
                System.Threading.Thread.Sleep(50);
            }
            
        }
    }
}