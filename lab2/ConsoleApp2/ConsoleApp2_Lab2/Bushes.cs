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
        const double max_heigth_meters = 3.5;
        public string type_of_fruit { get; set; }
        public string color { get; private set; }

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

        //public delegate void PlantABushEventHandler(object source, BushEventArgs args);

        public event EventHandler<BushEventArgs> PlantABush;     // same as delegate

        public void plantBush(Seed seed)
        {
            Console.WriteLine("\n\n Planting a bush  " + seed.nameOfBush);
            this.type_of_fruit = seed.nameOfBush;

            OnPlantABush(seed);
        }

        protected virtual void OnPlantABush(Seed seed )
        {
            if (PlantABush != null)
                PlantABush(this, new BushEventArgs() { Seed = seed});
            
        }
    }
}
