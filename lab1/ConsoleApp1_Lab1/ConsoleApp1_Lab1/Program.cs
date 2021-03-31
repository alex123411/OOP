using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Trees oak = new Trees(false, "green", "oak");
            Console.WriteLine(oak.name1);

            Console.WriteLine(Trees.add_num_of_trees());

            Console.WriteLine(Algaes.return_num_of_trees());

            Algaes alg = new Algaes("light-green", "Pacific ocean", "Undaria");
            alg.plant_smthing("Corals");

            Herbaceous bush = new Herbaceous("yellow", false, "sunflower", 2, false, 25);

            Bushes b = Bushes.GetBush("Africa"); //private ctor gotten
        }
    }
}

