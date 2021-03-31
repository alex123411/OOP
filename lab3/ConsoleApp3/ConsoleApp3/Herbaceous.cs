using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_Lab2
{
    class Herbaceous : Plants
    {
        private string plant_to_create;
        public override string Create_a_plant
        {
            get
            {
                return plant_to_create;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    plant_to_create = value;
                    Console.WriteLine(plant_to_create + " bush was created");
                }
                else
                {
                    plant_to_create = "Please make sure u input everything correct";
                }
            }
        }
        const double max_heigth_meters = 1.5;
        public string color;
        public bool predatory;

        public Herbaceous(string color, bool predatory, string plant_to_create, int age, bool underwater, int number_of_leafes) : base(age, underwater, number_of_leafes)
        {
            this.color = color;
            this.predatory = predatory;
            this.Create_a_plant = plant_to_create;
        }

        public void show_created_plant()
        {
            Console.WriteLine(" CREATED!! " + plant_to_create);
        }

        public override void SeeWhatPlant()
        {
            Console.WriteLine("This is a Herbaceous its color is " + color);
        }
    }
}
