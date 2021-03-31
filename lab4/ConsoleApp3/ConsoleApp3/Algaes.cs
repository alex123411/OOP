using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_Lab2
{
    public class Algaes : Plants
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
                    Console.WriteLine(plant_to_create + " algaes were created");
                }
                else
                {
                    plant_to_create = "Please make sure u input everything correct";
                }
            }
        }
        const double max_heigth_meters = 2.5;
        public string color;
        public string oceanORsea_where_lives;
        public Algaes(string color, string oceanORsea_where_lives, string plant_to_create) : base()
        {
            this.color = color;
            this.oceanORsea_where_lives = oceanORsea_where_lives;
            this.Create_a_plant = plant_to_create;
        }
        ~Algaes()
        {
            Console.WriteLine("Algaes destructor");
        }
        public void show_created_plant()
        {
            Console.WriteLine(" CREATED!! " + plant_to_create);
        }
        public override void plant_smthing(string smthing)
        {
            Console.WriteLine("starting planting");
            base.plant_smthing(smthing);
        }


        public override void SeeWhatPlant()
        {
            Console.WriteLine("This is a algae its location is " + oceanORsea_where_lives);
        }
    }
}
