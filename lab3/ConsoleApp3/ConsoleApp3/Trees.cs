using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_Lab2
{

    public class Bigtree
    {
        public int id;
        public int heigth;
        public string name;
    }
    interface BigTree
    {
        string printBigTree();
    }

    interface SmallTree
    {
        string printSmallTree();
    }

    class Trees : Plants, BigTree, SmallTree
    {
        const int max_heigth_meters = 100;
        public string color;
        public bool coniferous;
        public readonly string name1;
        public static string namee;
        //public int age;

        public List<Bigtree> bigtrees = new List<Bigtree> { new Bigtree { id = 1 , heigth = 100, name = "sequoia" } };

        static Trees()
        {
            //Console.WriteLine("static ctor for trees was called");
            namee = CreateOak();
        }

        public Trees(bool coniferous, string color, string name1, int age)
        {
            //Console.WriteLine("default trees constructor called");
            this.underwater = false;
            this.coniferous = coniferous;
            this.color = color;
            this.name1 = name1;
            this.age = age;
        }

        private static string CreateOak()
        {
            return "oak";
        }

        private static string CreateSequoia()
        {
            return "sequoia";
        }

        string BigTree.printBigTree()
        {
            Console.WriteLine("Big tree given(sequoia)");
            return CreateSequoia();
        }

        string SmallTree.printSmallTree()
        {
            Console.WriteLine("Small tree given(oak)");
            return CreateOak();
        }


        public override void SeeWhatPlant()
        {
            Console.WriteLine("This is a tree its called " + name1);
        }

        public void showBig()
        {
            Console.WriteLine("Big trees u have in list");
            foreach ( Bigtree tree_ in bigtrees)
            {
                Console.WriteLine(tree_.id+" "+ tree_.heigth + " "+tree_.name);
            }
        }

        public void addBig(Bigtree tree)
        {
            bigtrees.Add(tree);
        }

        public void deleteBig(Bigtree tree)
        {
            bigtrees.Remove(tree);
        }
        public Bigtree findBig(int id)
        {
            Bigtree tree_ = new Bigtree { };
            foreach (Bigtree tree__ in bigtrees)
            {
                if (tree__.id == id)
                {
                    tree_ = tree__;
                    return tree_;
                }
            }
            return null;
        }
    }
}
