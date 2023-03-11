using System;

namespace MACHINELEARNINGHWM
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while(running)
            
            {
                Console.WriteLine("Welcome");
                Console.WriteLine("This program uses the following commands");
                Console.WriteLine("run -test     RUN TO TEST THE ALGORITHM IN THE GIVEN DATASET");
                Console.WriteLine("run -train    RUN TO TRAIN THE ALGORITHM IN THE GIVEN DATASET");
                Console.WriteLine("print -test   PRINTS A PICTURE OF A TEST LETTER TO FILE");
                Console.WriteLine("print -train  PRINTS A PICTURE OF A TRAINING LETTER TO FILE");
                Console.WriteLine("clear         CLEARS THE CONSOLE");
                Console.WriteLine("stop          STOPS THE PROGRAM");

            string command = Console.ReadLine();
            switch (command)
            {
                default:
                    Console.WriteLine("Command not found ({0})", command );
                    break;
                
                case "run -test":
                    Console.WriteLine("Running command {0}", command);
                break; 

                case "run -train":
                    Console.WriteLine("Running command {0}", command);
                break; 

                case "print -test":
                    Console.WriteLine("Running command {0}", command);
                break; 

                case "print train":
                    Console.WriteLine("Running command {0}", command);
                break; 
                
                case "clear":
                    Console.Clear();
                break; 

                case "stop":
                    running = false;
                break; 

               

            }
            }
          



        }
    }
}
