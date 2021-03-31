using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_Lab2
{
    public class MyGCCollectClass
    {
        private const int maxGarbage = 1000;

        public static void MakeSomeGarbage()
        {
            Version vt;

            // Create objects and release them to fill up memory with unused objects.
            for (int i = 0; i < maxGarbage; i++)
            {
                vt = new Version();
            }
        }
    }

    class MyFinalizeObject
    {
        public static MyFinalizeObject currentInstance = null;
        private bool hasFinalized = false;

        ~MyFinalizeObject()
        {
            if (hasFinalized == false)
            {
                Console.WriteLine("First finalization");

                // Put this object back into a root by creating
                // a reference to it.
                MyFinalizeObject.currentInstance = this;

                // Indicate that this instance has finalized once.
                hasFinalized = true;

                // Place a reference to this object back in the
                // finalization queue.
                GC.ReRegisterForFinalize(this);
            }
            else
            {
                Console.WriteLine("Second finalization");
            }
        }
    }
    class MyFinalizeObject2
    {
        // Make this number very large to cause the finalizer to
        // do more work.
        private const int maxIterations = 10000;

        ~MyFinalizeObject2()
        {
            Console.WriteLine("Finalizing a MyFinalizeObject");

            // Do some work.
            for (int i = 0; i < maxIterations; i++)
            {
                // This method performs no operation on i, but prevents
                // the JIT compiler from optimizing away the code inside
                // the loop.
                GC.KeepAlive(i);
            }
        }
    }
}
