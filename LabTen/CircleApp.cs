using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTen
{
    class CircleApp
    {
        public List<Circle> Circles = new List<Circle>();
        
        public void Run()
        {
            bool run = true;

            while (run)
            {
                double input = 0;

                try
                {

                    Console.WriteLine("Input radius: ");
                    input = double.Parse(Console.ReadLine());
                    Console.WriteLine("");


                    if (input <= 0)
                    {
                        throw new Exception ("That was not a valid input, please try again.");
                    }
                    else
                    {
                        
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.GetType());
                }


                
                    Circle c2 = new Circle(input);
                    Circles.Add(c2);

                   PrintCircles();
                   Console.WriteLine(" ");


                    Console.WriteLine("Would you like to continue? (Y/N)");
                    string answer = Console.ReadLine();
                    answer= answer.ToLower();

                    if( answer =="y" || answer == "yes")
                    {
                     
                    }
                    else
                    {
                    run = false;
                    }
            }

            Console.WriteLine("Goodbye!");
            
        }
            public void PrintCircles()
            {

                for(int i =0; i< Circles.Count; i++)
                {
                  Circles[i].PrintInfo();
                Console.WriteLine("----------------");
                
                }

            }
        
        //In another class called : CircleApp, create a the following
        //Public List<Circle> Circles
        //Run() - which is void and starts a loop.At the start of this loop ask the user for a radius.If a valid double is input, create a circle and add it to Circles. At the end of each iteration, ask the user if they want to continue. 
        //PrintCircles() - which is void and calls PrintInfo() on each circle in the Circles list.
        //For the value of pi, use the PI constant in System.Math class.
    }
}

