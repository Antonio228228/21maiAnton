using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21maiAnton
{
    class Point //class eto tip dannqh
    {
        public int x; //peremennqe kotorie zadajut koordinatq to4ki po osi x
        public int y;
        public char sym;

        public Point() //konstruktor nikogda ne vozvrawaet
        {
            Console.WriteLine("Создается новая точка");
        }

        public Point(int _x, int _y, char _sym) //funkcija kotoraja ponimaet koordinatq
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public void Draw()  //metod narisovat to4ku. Void ozna4aet 4to ni4ego ne nado vozvrawat
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }

}
