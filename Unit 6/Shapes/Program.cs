using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int runsts = 1;
            Shapes main = new Shapes();

            Console.Write(@"
                            Welcome to:
             ______     __  __     ______     ______   ______     ______    
            /\  ___\   /\ \_\ \   /\  __ \   /\  == \ /\  ___\   /\  ___\   
            \ \___  \  \ \  __ \  \ \  __ \  \ \  _-/ \ \  __\   \ \___  \  
             \/\_____\  \ \_\ \_\  \ \_\ \_\  \ \_\    \ \_____\  \/\_____\ 
              \/_____/   \/_/\/_/   \/_/\/_/   \/_/     \/_____/   \/_____/


");
            Console.WriteLine("Type help for list of commands and function.");
            Console.WriteLine("Type exit to quit the program");

            while (runsts != 0)
            {
                Console.Write("Command:");
                input = Console.ReadLine();

                if (input == "Help" | input == "help" | input == "h")
                {
                    main.help();
                }
                else if(input == "Rec" | input == "rec")
                {
                    main.rec();
                }
                else if(input == "Cir" | input == "cir")
                {
                    main.cir();
                }
                else if(input == "Tri" | input == "tri")
                {
                    main.tri();
                }
                else if(input == "trap" | input == "trap")
                {
                    main.trap();
                }
                else if(input == "Exit" | input == "exit" | input == "e")
                {
                    runsts = 0;
                }
                else
                {
                    Console.WriteLine("Command is not recongized. Type help if a command is unclear.");
                }
            }
        }
    }
}
