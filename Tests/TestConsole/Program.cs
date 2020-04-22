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

            //Player player1 = new Player("Empty", new DateTime(1996, 07, 28));

            //Console.Write("Input Surname: ");
            //player1.Name = Console.ReadLine();


            //Console.WriteLine(player1.Name);
            Vector2D v1 = new Vector2D(5,7);
            Vector2D v2 = new Vector2D(-7,2);
            Vector2D v3 = v1 + v2;
            Vector2D v4 = v3 + 3.141592;

            double pi = 3.1415;
            int i = (int)pi;

            double length = v4;  
            Console.ReadLine();
        }
    }
}
