using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_Lab2
{
    public class BushEventArgs : EventArgs
    {
        public Seed Seed { get; set; }
    }

    class Bushes : Plants
    {
        public  double max_heigth_meters = 3.5;
        public string type_of_fruit { get; set; }
        public string color { get; private set; }
        private bool is_planted;


        public Bushes(string type_of_fruit, string color)
        {
            this.type_of_fruit = type_of_fruit;
            this.color = color;
        }

        private Bushes()
        {
            Console.WriteLine("private ctor 4 bushes was called");
            type_of_fruit = "raspberry";
            color = "purple";
            this.underwater = false;
        }

        ~Bushes()
        {
            Console.WriteLine("Bushes destructor");
        }

        public static Bushes GetBush(string LocationOfBush)
        {
            if (LocationOfBush != "Africa")
            {
                Console.WriteLine("Bush was planted in " + LocationOfBush);
                return new Bushes();
            }
            else
            {
                Console.WriteLine("U can`t plant a bush in " + LocationOfBush);
                return null;
            }

        }

        public override void SeeWhatPlant()
        {
            Console.WriteLine("This is a bush its color is " + color);
        }

        
        //anon
        public delegate string PLantABush(string type_of_fruit);
        public static PLantABush TryPLantABush(double max_heigth)
        {
            if (max_heigth == 3.5)
            {
                PLantABush can_ = delegate (string type_of_fruit)
                {
                    return "Grats! U can plant "+ type_of_fruit;
                };
                return can_;
            }
            else 
            {
                PLantABush cant_ = delegate (string type_of_fruit)
                {
                    return "Sry u can`t plan " + type_of_fruit;
                };
                return cant_;
            }   
        }

        //lambda
        public static PLantABush lambdaTryPLantABush(double max_heigth)
        {
            if (max_heigth == 3.5) { PLantABush can_ =  (string type_of_fruit) =>{ return "Grats! U can plant " + type_of_fruit; }; return can_;}
            else { PLantABush cant_ = (string type_of_fruit) =>{ return "Sry u can`t plan " + type_of_fruit;}; return cant_;}
        }
        //action 
        public static PLantABush ActionTryPLantABush(double max_heigth)
        {
            if (max_heigth == 3.5)
            {
                Action<string> tryPlant = TryPLantABush_yes;
                return null;
            }
            else
            {
                Action<string> cantPlant = TryPLantABush_no;
                return null;
            }
        }
        static void TryPLantABush_yes(string type_of_fruit)
        {
            Console.WriteLine("Grats! U can plant " + type_of_fruit);
        }
        static void TryPLantABush_no(string type_of_fruit)
        {
            Console.WriteLine("Sry u can`t plan " + type_of_fruit);
        }

        //func 
        public static PLantABush FuncTryPLantABush(double max_heigth)
        {
            if (max_heigth == 3.5)
            {
                Func<string, string> tryPlant = TryPLantABush_yes2;
                string message = TryPLantABush_yes2(max_heigth.ToString());
                Console.WriteLine(message);
                return null;
            }
            else
            {
                Func<string, string> cantPlant = TryPLantABush_no2;
                string message = TryPLantABush_no2(max_heigth.ToString());
                Console.WriteLine(message);
                return null;
            }
        }
        static string TryPLantABush_yes2(string max_heigth)
        {
            return ("FUNC:\nGrats! U can plant it is only" + max_heigth + " meters high!");
        }
        static string TryPLantABush_no2(string max_heigth)
        {
            return ("FUNC:\nSry u can`t plan it is only" + max_heigth + " meters high!");
        }
    }
}
