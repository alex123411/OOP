using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp2_Lab2
{
    
    public class Seed
    {
        public string nameOfBush;

        public Seed(string nameOfBush)
        {
            this.nameOfBush = nameOfBush;
        }
    }

    public interface IPlant
    {
        int Id
        { get; set; }

        string Get_plant_name();
    }

    [Serializable]
    public class Seed_ : IPlant, IComparable, IDisposable
    {
        public string Name { get; set; }

        public int id;
        private string plant_name;
        public Seed_(string plant_name)
        {
            this.id = 10;
            this.plant_name = plant_name;
        }

        public Seed_() : this("Default") { }

        [XmlIgnore]
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Get_plant_name()
        {
            return this.plant_name;
        }

        int IComparable.CompareTo(object o)
        {
            if (!(o is Seed_))
                throw new ArgumentException();

            Seed_ w = (Seed_)o;

            if (this.id > w.id) return 1;
            if (this.id < w.id) return -1;
            else return 0;
        }

        public void Dispose()
        {
            //
            GC.SuppressFinalize(this);
        }
    }
}