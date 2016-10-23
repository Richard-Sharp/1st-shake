using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Point1 p1 = new Point1(6, 4, '*');
            p1.Draw();

            Point1 p2 = new Point1(7, 10, '#');
            p2.Draw();
            Console.ReadLine();
          }
        }
    }
