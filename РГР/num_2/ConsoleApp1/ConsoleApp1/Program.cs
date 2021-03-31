using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.Change_plan();
        }
    }

    abstract class Command
    {
        abstract public void Execute();
        protected Receiver r;
        public Receiver R
        {
            set
            {
                r = value;
            }
        }
    }

    class ConcreteCommand : Command
    {
        override public void Execute()
        {
            Console.WriteLine("Command executed");
            string PUK_code = r.Change_plan();
            if (PUK_code != "1001")
            {
                Console.WriteLine("Sorry, your PUK-code is invalid");
            }
            else
            {
                Console.WriteLine("Tarrifs:\n- unlimit+ - 15$/m\n- vodafone redS - 10$/m\n- Vodafone nodeJ - 11$/m");
            }
        }
    }
    class Receiver
    {
        string PUK_code;
        public string Change_plan()
        {
            Console.WriteLine("Please input PUK-code");
            this.PUK_code = Console.ReadLine();
            Console.WriteLine("PUK-code recieved");
            return PUK_code;
        }
    }
    class Invoker
    {
        private Command command;
        public void StoreCommand(Command c)
        {
            command = c;
        }
        public void ExecuteCommand()
        {
            command.Execute();
        }
    }

    class Client
    {
        public string Change_plan()
        {
            Command c = new ConcreteCommand();
            Receiver r = new Receiver();
            c.R = r;
            Invoker i = new Invoker();
            i.StoreCommand(c);
            i.ExecuteCommand();
            return "OK";
        }
    }
}
