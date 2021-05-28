using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21maiAnton
{
    class Figure
    {
        protected List<Point> pList; //modifikator dostupa protected


        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }

}
