using System;

namespace ConsoleApp1
{
    class Program
    {

            
        public static Boolean firstRun = true;
        static void Main(string[] args)
        {
            Starter();
        }
    


        static void Starter()
        {
            if (firstRun)
            {
                Console.WriteLine("Good Morning. What do you want to do? (type help for info)");
                firstRun = false;
            }
            else { Console.WriteLine("What can I do for you?"); }
            String task = Console.ReadLine();
            if (task == "bmi") { Bmicalc(); }
            if (task == "grader") { Grader(); }
            if (task == "day") { Console.WriteLine(DateTime.Now.DayOfWeek); Starter(); }
            if (task == "help")
            {
                Console.WriteLine("gradebook  = Gradebook App");
                Console.WriteLine(" bmi  = BMI Calculator");
                Console.WriteLine("help = infomrmation");
                Console.WriteLine("day = weekday");
         
                Starter();

            }
        }

        static void Bmicalc()
        {
            Console.WriteLine("Body Mass Index");
            Console.WriteLine("Your height in Meters:");
            String height = Console.ReadLine();
            Console.WriteLine("Your weight in Kilos:");
            String weight = Console.ReadLine();
            double w = Convert.ToDouble(weight);
            double h = Convert.ToDouble(height);
            double bmi = (w) / (Math.Pow(h, 2));
            String msg = "";
            if (bmi <= 25)
            {
                if (bmi <= 18.5)
                {
                    double i = bmi;
                    msg = "underweight";
                }
                else { msg = "normal weight"; }
            }
            if (bmi > 25 && bmi < 30) { msg = "overweight"; }
            if (bmi >= 30) { msg = "obese"; }
            Console.WriteLine("Youer Body Mass Index is " + (bmi) + ", that means you are " + msg + ".");
            Starter();

        }

   
            static void Grader()
            {
              

                Gradebook book = new Gradebook();
                book.AddGrade(91);
            Starter();
            }

          

            }

            }
        
        
