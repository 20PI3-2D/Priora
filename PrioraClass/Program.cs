using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrioraClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Приора москвич = new Приора(100, 5000, 60);

            москвич.ЗавестиМашину();
            москвич.ПоменятьПередачу(1);
            москвич.НажатьГаз();
            москвич.НажатьГаз();
            москвич.Притормозить();
            москвич.Притормозить();
            москвич.ЗаглушитьМашину();

            Console.ReadKey();
        }
    }
}
