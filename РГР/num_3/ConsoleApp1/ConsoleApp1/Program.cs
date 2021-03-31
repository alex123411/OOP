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
            Ticket_creator crea = new Concert_ticket_creator(28, "Queen");
            Ticket ticket = crea.Create();
            Console.Read();
        }
    }
    abstract class Ticket_creator
    {
        public int place;
        public int row;
        public string concert;
        public int price;


        public Ticket_creator(int place, string concert)
        {
            this.place = place;
            this.row = place / 7;
            this.concert = concert;
            if (concert == "Queen") { price = 1000; }
            else { price = 900; }
        }
        // фабричний метод
        abstract public Ticket Create();
    }
    class Concert_ticket_creator : Ticket_creator
    {
        public Concert_ticket_creator(int place, string concert) : base(place, concert)
        { }

        public override Ticket Create()
        {
            return new Concert_ticket(row, place, concert, price);

        }
    }
    abstract class Ticket
    { }
    class Concert_ticket : Ticket
    {
        public Concert_ticket(int row, int place, string concert, int price)
        {
            Console.WriteLine("Your Ticket on " + concert + ":\nrow - " + row + "\nplace - " + place + "\nprice - " + price);
        }
    }

}