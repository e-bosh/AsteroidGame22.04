using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Player player1 = new Player();
            //player1.Name = "Vlad";
            //player1.Birthday = new DateTime(1996,28,07,0,0,0);

            Player player1 = new Player("Empty", new DateTime(1996, 07, 28));

            Console.Write("Input Surname: ");
            player1.Name = Console.ReadLine();


            Console.WriteLine(player1.Name);
            Console.ReadLine();
        }
    }

    internal class Player
    {
        private string _Name;
        private DateTime _Birthday;

        public string GetName()
        {
            return _Name;

        }

        public void SetName(string Name)
        {
            _Name = Name;
        }

        public Player()
        {
            
        }
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }

        public string Surname { get; set; } = "qwe";

        public Player(string Name)
        {
            this._Name = Name;
            _Birthday = DateTime.Now;
        }

        public Player(string Name, DateTime Birthday)
            : this(Name)
        {
            //this.Name = Name;
            this._Birthday = Birthday;

        }
    }
}
