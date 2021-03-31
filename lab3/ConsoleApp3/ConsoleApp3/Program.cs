using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace ConsoleApp2_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Trees trees = new Trees(false, "green", "bigTrees" , 90);
            Bigtree bt = new Bigtree { id = 2, heigth = 99, name = "OAK" };
            trees.showBig();
            trees.addBig(bt);
            Bigtree bt_ = trees.findBig(2);
            Console.WriteLine("Look what we found in list \n "+bt_.id + " " + bt_.heigth + " " + bt_.name);
            trees.deleteBig(bt);
            trees.showBig();


            Seeds seeds__ = new Seeds (6);
            Seeds seeds__2 = new Seeds(8);
            foreach (Seed_ w in seeds__)
            {
                Console.WriteLine(w.Get_plant_name());
            }
            
            seeds__.CharCount('s');//!!!


            seeds__.Sort();
            seeds__.XmlSerialize();
            seeds__.BinarySerialize();

            seeds__2.XmlSerializeGet();

            seeds__2.BinaryDeserialize();

            foreach (Seed_ w in seeds__2)
            {
                Console.WriteLine(w.id);
            }
            Console.WriteLine("-----------");

            foreach (Seed_ w in seeds__)
            {
                Console.WriteLine(w.Get_plant_name());
            }
            Seed_ w1 = new Seed_() { Name = "Blueberry", Id = 20 };

            Console.WriteLine("-----------");

            Bushes bush = Bushes.GetBush("USA");      
            Bushes.PLantABush qwe = Bushes.TryPLantABush(bush.max_heigth_meters);
            string res = qwe(bush.type_of_fruit);
            Console.WriteLine(res);
            Console.WriteLine("-----------");

            bush.type_of_fruit = "blueberry";
            Bushes.PLantABush qwe2 = Bushes.lambdaTryPLantABush(bush.max_heigth_meters);
            string res2 = qwe2(bush.type_of_fruit);
            Console.WriteLine(res2);


            
            Bushes.PLantABush qwe3 = Bushes.FuncTryPLantABush(bush.max_heigth_meters);
            qwe3(bush.type_of_fruit);
            //Console.WriteLine(res3);

            Console.ReadKey();
        }
    }
}
