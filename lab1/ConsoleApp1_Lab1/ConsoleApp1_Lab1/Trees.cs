using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Lab1
{
    class Trees : Plants
    {
        const int max_heigth_meters = 100;
        public string color;
        public bool coniferous;
        public readonly string name1;
        public static string namee;

        static Trees()
        {
            Console.WriteLine("static ctor for trees was called");
            namee = CreateOak();
        }

        public Trees(bool coniferous, string color, string name1) 
        {
            Console.WriteLine("default trees constructor called");
            this.underwater = false;
            this.coniferous = coniferous;
            this.color = color;
            this.name1 = name1;
        }

        private static string CreateOak()
        {
            return "oak";
        }
    }
    
}
 