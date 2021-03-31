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
        class MyWaitForPendingFinalizersClass
        {
            // You can increase this number to fill up more memory.
            const int numMfos = 1000;
            // You can increase this number to cause more
            // post-finalization work to be done.
            const int maxIterations = 100;
            static void Main(string[] args)
            {
                Trees tree = new Trees(false, "blue", "rose", 1);
                Console.WriteLine($"Generation: { GC.GetGeneration(tree)}");
                GC.Collect(0);
                Console.WriteLine($"Generation: { GC.GetGeneration(tree)}");
                GC.Collect(1);
                Console.WriteLine($"Generation: { GC.GetGeneration(tree)}");
                GC.Collect(2);
                Console.WriteLine($"Generation: { GC.GetGeneration(tree)}");
                Console.WriteLine("");

                MyGCCollectClass.MakeSomeGarbage();
                Console.WriteLine("Memory used before collection:       {0:N0}",
                                  GC.GetTotalMemory(false));
                // Collect all generations of memory.
                GC.Collect();
                Console.WriteLine("Memory used after full collection:   {0:N0}",
                                  GC.GetTotalMemory(true));

                //ReRegisterForFinalize
                MyFinalizeObject mfo = new MyFinalizeObject();
                mfo = null;
                GC.Collect();
                MyFinalizeObject.currentInstance = null;
                GC.Collect();

                //WaitingFoPendingFinilize

                MyFinalizeObject2 mfo2 = null;
                for (int j = 0; j < numMfos; j++)
                {
                    mfo2 = new MyFinalizeObject2();
                }
                mfo2 = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
                for (int i = 0; i < maxIterations; i++)
                {
                    Console.WriteLine("Doing some post-finalize work");
                }

                //Console.ReadKey();


                Console.WriteLine("  ");
                rand_class rand_ = new rand_class();
                WeakReference wr = new WeakReference(rand_);

                rand_ = null;
                Console.WriteLine(wr.GetType());
                Console.WriteLine(rand_);
                GC.Collect(2);
                Console.WriteLine(wr.GetType());


                Console.WriteLine("  ");
                Console.ReadKey();
            }
        }
        class rand_class 
            { }

    }


}
