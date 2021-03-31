using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_Lab2
{
    public class MessageService
    {
        public void OnPlantABush(object source, BushEventArgs args)
        {
            Console.WriteLine("MessageService: Sending an info about planted bush " + args.Seed.nameOfBush);
        }
    }
}
