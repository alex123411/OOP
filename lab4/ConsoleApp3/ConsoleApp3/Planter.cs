using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_Lab2
{
    public class Planter
    {
        public void OnPlantABush(object source, BushEventArgs e)
        {
            bool exception_check = false;
            int num;
            while (exception_check == false)
            {
                Console.WriteLine("Enter how many seeds should gardener plant");
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    exception_check = true;
                    Console.WriteLine("Planter: gardener just  planted a bush - " + e.Seed.nameOfBush + " " + num + " times ");

                }
                catch (FormatException)
                {
                    Console.WriteLine("Format Exeption, please input correct data (number)");
                    exception_check = false;
                }
            }


        }
    }
}
