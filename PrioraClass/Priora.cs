using System;

namespace PrioraClass
{
    public class Приора
    {
        public int ЛошадиныеСилы { get; }
        public int Вес { get; }
        public int МаксСкорость { get; }



        public int ТекущаяСкорость { get; private set; } = 0;
        public int ТекущаяПередача { get; private set; } = 0;
        public string Цвет { get; set; } = "Белая";
        public string Название { get; set; } = "Приора";
        public bool РаботаетЛиДвигатель { get; private set; } = false;

        public Приора(int лошадиныеСилы, int вес, int максСкорость)
        {
            ЛошадиныеСилы = лошадиныеСилы;
            Вес = вес;
            МаксСкорость = максСкорость;
        }

        public void ЗавестиМашину()
        {
            if (ТекущаяПередача != 0)
            {
                Console.WriteLine("Машина заглохла");
                throw new Exception("Машина заглохла");
            }
            РаботаетЛиДвигатель = true;
            Console.WriteLine("Машина запущена");
        }

        public void ПоменятьПередачу(int выбираемаяПередача)
        {
            if (выбираемаяПередача + 1 == ТекущаяПередача || выбираемаяПередача - 1 == ТекущаяПередача)
            {
                ТекущаяПередача = выбираемаяПередача;
                Console.WriteLine($"Передача машины изменена, сейчас она {ТекущаяПередача}");
                return;
            }
            throw new Exception("Машина заглохла");
        }

        public void ЗаглушитьМашину()
        {
            РаботаетЛиДвигатель = false;
            Console.WriteLine("Машина заглушена");
        }

        public void НажатьГаз()
        {
            ТекущаяСкорость += 10;
            Console.WriteLine($"Машина увеличила скорость: сейчас она {ТекущаяСкорость} км/ч");
        }

        public void Притормозить()
        {
            ТекущаяСкорость -= 10;
            Console.WriteLine($"Машина уменьшила скорость: сейчас она {ТекущаяСкорость} км/ч");
        }

    }
}
