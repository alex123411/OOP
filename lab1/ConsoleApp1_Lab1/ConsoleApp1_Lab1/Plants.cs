using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Lab1
{
    public abstract class Plants
    {
        public int age;         //int
        public bool underwater; //boolean  
        private static int number_of_Trees_species = 0; //int
        private static int number_of_Bushes_species = 0; //int
        protected int number_of_leafes;
        public static string addgrass;

        public Plants()
        {
            age = 1;
            underwater = false;
            number_of_leafes = 0;
            Console.WriteLine("default Plants ctor was called");
        }
        public Plants(int age, bool underwater, int number_of_leafes)  
        {
            this.age = age;
            this.underwater = underwater;
            this.number_of_leafes = number_of_leafes;
            Console.WriteLine("Plants ctor with prmetrs was called");
        }

        static Plants()
        {
            Console.WriteLine("static ctor for plant was called");
            addgrass = CreateGrass();
        }

        public static string add_num_of_trees()
        {
            ++number_of_Trees_species;
            return "added a tree species";
        }
        
        public static int  return_num_of_trees()
        {
            return number_of_Trees_species;
        }

        private static string CreateGrass()
        {
            return "grass";
        }

        virtual public void plant_smthing(string smthing)
        {
            Console.WriteLine("Planted " + smthing + " !!!");
        }

        public virtual string Create_a_plant { get; set; }
    } 
}

