using System;
using System.IO;

namespace MACHINELEARNINGHWM
{
    class Program
    {


        static int[] layers = {784, 16, 16, 10};
        static float[][] neurons;
        static float[][] biases;
        static float[][][] weights;
        static Random random = new Random();
        static bool load = false;
        static StreamReader srw = new StreamReader(@"Weights.csv");
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"mnist_train.csv");
            
            sr.ReadLine();
            bool running = true;
            while(running)

            
            //helping the user
            {
                Console.WriteLine("Welcome");
                Console.WriteLine("This program uses the following commands");
                Console.WriteLine("run -test     RUN TO TEST THE ALGORITHM IN THE GIVEN DATASET");
                Console.WriteLine("run -train    RUN TO TRAIN THE ALGORITHM IN THE GIVEN DATASET");
                Console.WriteLine("print -test   PRINTS A PICTURE OF A TEST LETTER TO FILE");
                Console.WriteLine("print -train  PRINTS A PICTURE OF A TRAINING LETTER TO FILE");
                Console.WriteLine("clear         CLEARS THE CONSOLE");
                Console.WriteLine("save          CLEARS THE CONSOLE");
                Console.WriteLine("exit          STOPS THE PROGRAM");

            string command = Console.ReadLine();
            //a swtich statement
            switch (command)
            {
                default:
                    Console.WriteLine("Command not found ({0})", command );
                    break;
                
                case "run -test":
                    Console.WriteLine("Running command {0}", command);
                    InitNetwork();
                break; 

                case "run -train":
                    Console.WriteLine("Running command {0}", command);
                    InitNetwork();

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
                case "save":
                    Console.Clear();
                    SaveWeights();
                break; 

                case "exit":
                    running = false;
                break; 

               

            }
            }
          

            

        }

        static void InitNetwork()
        {
                InitNeurons();
                InitWeights();
                InitBiases();



        }
        static void InitNeurons()
        {
                neurons = new float[layers.Length][];
                for (int i = 0; i < layers.Length; i++)
                {
                    neurons[i] = new float[layers[i]];
                }
        }
        static void InitBiases()
        {
            
             biases = new float[layers.Length][];
                for (int i = 0; i < layers.Length; i++)
                {
                    biases[i] = new float[layers[i]];
                }


                for (int i = 0; i < biases.Length; i++)
                {
                    for (int j = 0; j < biases[i].Length; j++)
                    {
                        biases[i][j] = random.NextSingle()*10-5;
                    }
                }
        }
        static void InitWeights()
        {
            weights = new float[layers.Length -1][][];
                for (int i = 0; i < weights.Length; i++)
                {
                    weights[i] = new float[layers[i+1]][];
                    for (int j = 0; j < layers[i+1]; j++)
                        weights[i][j] = new float[layers[i]];
                }

            if (!load)
            {
                for (int i = 0; i < weights.Length; i++)
                {
                   
                    for (int j = 0; j < weights[i].Length; j++)
                    {
                       
                        for (int k = 0; k < weights[i][j].Length; k++)
                        {

                            weights[i][j][k] = random.NextSingle()*10-5;
                        }
                    }
                }   
            }
            else
            {
                for (int i = 0; i < weights.Length; i++)
                {
                   
                    for (int j = 0; j < weights[i].Length; j++)
                    {
                        string[] temp = srw.ReadLine().Split(',');
                       
                        for (int k = 0; k < weights[i][j].Length; k++)
                        {
                            weights[i][j][k] = float.Parse(temp[k]);
                        }
                    }
                }   




            }
        }

        static void SaveWeights()
        {
            StreamWriter sw = new StreamWriter(@"Weights.csv");
            for (int i = 0; i < weights.Length; i++)
                    for (int j = 0; j < weights[i].Length; j++)
                    {
                        for (int k = 0; k < weights[i][j].Length-1; k++)
                            sw.Write("{0},",weights[i][j][k]);
                        sw.WriteLine(weights[i][j][weights[i][j].Length-1]);
                    }

                      sw.Close();  
                            
    
                   
                        
                       
                  




        }





























    }
}
