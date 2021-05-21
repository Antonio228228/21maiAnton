using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21maiAnton
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(); //ekzemplar classa point
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            Draw(p1.x, p1.y, p1.sym); //vqvodim na ekran
            /*p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            Draw(p1.x, p1.y, p1.sym);*/

            Point p2 = new Point(); //vtoroi ekzemplar classa point
            /*int x1 = 1; //int hranit celie 4isla
            int y1 = 3;
            char sym1 = '*';  //char hranit symbols
            Draw(x1, y1, sym1);*/

            int x2 = 4;
            int y2 = 5;
            char sym2 = '#';
            Draw(x2, y2, sym2);

            Console.ReadLine();
        }

        static void Draw(int x, int y, char sym) 
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
