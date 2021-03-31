using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_Lab2
{
    class TreeCutException : Exception
    {
        public string Axe { get; }
        public int InputAge { get; }
        public TreeCutException(string message, string axe, int input_age) : base(message)
        {
            Axe = axe;
            InputAge = input_age;
        }
    }

    class Axe
    {
        public string axe_type;
        public Axe(string axe_type)
        {
            this.axe_type = axe_type;
        }
    }

    class TreeCut
    {
        public TreeCut() { }
        public void CutATree(Trees tree, Axe axe)
        {
            if (tree.age >= 20 && axe.axe_type == "SmallAxe") throw new TreeCutException("This axe doesn`t fit to cut this tree", axe.axe_type, tree.age);
            else Console.WriteLine("Tree was cut");
        }
    }
}
