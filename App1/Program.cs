using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пример работы арифметической прогрессии (начальное значение 10, шаг 2)");
            ArithProgression arithProgr = new ArithProgression();
            arithProgr.SetStart(10);
            arithProgr.SetStep(2);
            Console.WriteLine(arithProgr.GetNext());
            Console.WriteLine(arithProgr.GetNext());
            Console.WriteLine(arithProgr.GetNext());
            Console.WriteLine(arithProgr.GetNext());
            Console.WriteLine("Сброс к начальному значению и повтор сначала:");
            arithProgr.Reset();
            Console.WriteLine(arithProgr.GetNext());
            Console.WriteLine(arithProgr.GetNext());

            Console.WriteLine("Пример работы геометрической прогрессии (начальное значение 10, шаг 2)");
            GeomProgression geomProgr = new GeomProgression();
            geomProgr.SetStart(10);
            geomProgr.SetStep(2);
            Console.WriteLine(geomProgr.GetNext());
            Console.WriteLine(geomProgr.GetNext());
            Console.WriteLine(geomProgr.GetNext());
            Console.WriteLine("Сброс к начальному значению и повтор сначала:");
            geomProgr.Reset();
            Console.WriteLine(geomProgr.GetNext());
            Console.WriteLine(geomProgr.GetNext());
            Console.ReadKey();
        }
    }
}
