using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Trees oak = new Trees(false, "green", "oak", 50);
            Console.WriteLine(oak.name1);

            Console.WriteLine(Trees.add_num_of_trees());

            Console.WriteLine(Algaes.return_num_of_trees());

            Algaes alg = new Algaes("light-green", "Pacific ocean", "Undaria");
            alg.plant_smthing("Corals");

            Herbaceous bush = new Herbaceous("yellow", false, "sunflower", 2, false, 25);

            Bushes b = Bushes.GetBush("Africa"); //private ctor gotten

            var seed = new Seed("StrawBerry") ;
            var bush_ = new Bushes("Blackberry", "purple");   //publisher
            var planter = new Planter();    //subscriber
            var messageService = new MessageService(); //subscriber

            bush_.PlantABush += planter.OnPlantABush;
            bush_.PlantABush += messageService.OnPlantABush;
            bush_.plantBush(seed);
        
            Axe axe = new Axe("SmallAxe"); //catch an Exception          
            TreeCut t = new TreeCut ();
            Console.WriteLine("\n");

            try
            {
                t.CutATree(oak, axe);
            } catch (TreeCutException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Need a bigger axe, you have: {ex.Axe}");
            }
        }
    }
    
}
