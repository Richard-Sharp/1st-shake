using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point1
    {
        public int x;
        public int y;
        public char sym;

        public Point1(int f, int _y, Char _sym)
        {
            x = f;
            y = _y;
            sym = _sym;
        }
        
        public void Draw()
        {
         Console.SetCursorPosition(x, y);
         Console.WriteLine(sym);
        }
    }
}
