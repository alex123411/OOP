using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
namespace ConsoleApp2_Lab2
{
    [Serializable]
    public class Seeds : IEnumerable, IEnumerator, IDisposable
    {
        public Seed_[] seeds;

        [NonSerialized]
        int pos = -1;
        int count = 0;
        public Seed_ this[string index]
        {
            get
            {
                foreach (Seed_ w in seeds)
                {
                    if (w.Get_plant_name() == index) return w;
                }
                return null;
            }
            set { this[index] = value; }
        }

        public IEnumerator GetEnumerator() { return (IEnumerator)this; }
        public bool MoveNext()
        {
            if (pos < seeds.Length - 1)
            {
                pos++;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            pos = -1;
        }

        public object Current
        {
            get { return seeds[pos]; }
        }

        public Seeds(int n)
        {
            seeds = new Seed_[n];
            this.count = n;
            for (int i = 0; i < n; i++)
            {
                seeds[i] = new Seed_("Seed #" + i.ToString());
                seeds[i].Id = n - i;
                Console.WriteLine("{0} seed is {1} , {2} years ", i, seeds[i].Get_plant_name(), seeds[i].Id);
            }
        }
        public void XmlSerialize()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Seed_[]));
            using (FileStream stream = new FileStream("data.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, seeds);
                Console.WriteLine(" XML serialized!");
            }
        }
        public void XmlSerializeGet()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Seed_[]));

            // Declare an object variable of the type to be deserialized.
            Seed_[] i;

            using (Stream reader = new FileStream("data.xml", FileMode.Open))
            {
                // Call the Deserialize method to restore the object's state.
                i = (Seed_[])serializer.Deserialize(reader);
                Console.WriteLine("XML DEserialized!");
            }
            
            seeds = i;
        }
        public void BinarySerialize()
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("data.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, seeds);

                Console.WriteLine("Binary Serialized!");
            }
        }

        public void BinaryDeserialize()
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("data.bin", FileMode.OpenOrCreate))
            {
                seeds = (Seed_[])formatter.Deserialize(fs);
                Console.WriteLine("Binary DeSerialized!");
            }
        }
        public void Dispose()
        {
            foreach (Seed_ w in seeds)
                w.Dispose();
        }

        ~Seeds()
        {
            Dispose();
        }
    }
    public static class SeedsExtention
    {
        public static int CharCount(this Seeds seed, char c)
        {
            int counter = 0;

            return counter;
        }
        public static Seeds Sort(this Seeds seed)
        {
            Array.Sort(seed.seeds);
            seed.Reset();
            return seed;
        }
    }
}   
