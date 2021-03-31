using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Lab1
{
    class Bushes : Plants
    {
        const double max_heigth_meters = 3.5;
        public string type_of_fruit { get; set; }
        public string color  { get; private set; }
        

        private Bushes()
        {
            Console.WriteLine("private ctor 4 bushes was called");
            type_of_fruit = "raspberry";
            color = "purple";
            this.underwater = false;
        }

        public static Bushes GetBush(string LocationOfBush)
        {
            if (LocationOfBush != "Africa") {
                Console.WriteLine("Bush was planted in " + LocationOfBush);
                return new Bushes();
            }
            else
            {
                Console.WriteLine("U can`t plant a bush in " + LocationOfBush);
                return null;
            }
            
        }

        
    }
}
