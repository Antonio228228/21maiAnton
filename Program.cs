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
            Point p1 = new Point(1, 3, '*'); //ekzemplar classa point. Инкапсуляция
            /*p1.x = 1; //peremennqe kotorie hranyat vsju informaciju po povodu nashei novoi to4ki na ekrane
            p1.y = 3;
            p1.sym = '*';*/
            p1.Draw(); //vqvodim na ekran
            /*p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            Draw(p1.x, p1.y, p1.sym);*/

            Point p2 = new Point(4, 5, '#'); //vtoroi ekzemplar classa point. Инкапсуляция
            /*int x1 = 1; //int hranit celie 4isla
            int y1 = 3;
            char sym1 = '*';  //char hranit symbols
            Draw(x1, y1, sym1);*/
            /*p2.x = 4;
            p2.y = 5;
            p2.sym = '#';*/
            p2.Draw();



            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0]; //v peremennuju x zapisivaem zna4enie pervogo elementa spiska
            int y = numList[1];
            int z = numList[2];

            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }


            Console.ReadLine();
        }

        /*static void Draw(int x, int y, char sym) //funkcija budet vqvodit na ekran to4ku.
        {
            Console.SetCursorPosition(x, y); //ukazivaem koordinatq
            Console.Write(sym); //vqvodim v etoi pozicii symbol
        }*/
    }
}
