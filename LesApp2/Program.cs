using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle = LesApp2.Machine.Vehicle;
using Plane = LesApp2.Machine.Plane;
using Ship = LesApp2.Machine.Ship;
using Car = LesApp2.Machine.Car;

namespace LesApp2
{
    class Program
    {
        static void Main()
        {
            // Підтримка Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // координати Києва https://uk.wikipedia.org/wiki/Київ
            // 50°27′00″ пн.ш. 30°31′25″ сх.д.
            // 50.45° пн.ш. 30.524° сх.д.

#if false    // варіант "все в ручну"

            // створення літака https://uk.wikipedia.org/wiki/Boeing_747
            Plane plane = new Plane()
            {
                // можна припустити, що в Києві офіс представництва компанії яка продає свій ТЗ
                Longitude = 30.524,
                Latitude = 50.45,
                MaxHight = 12000,
                MaxPassengers = 467,
                Speed = 1150,
                Price = 378.5 * Math.Pow(10, 6),    // https://www.avianews.com/airlines/advice/2016/01/14_airbus_boeing_prices.shtml
                DateCreate = 2010
            };

            // створення корабля
            Ship ship = new Ship()
            {
                Longitude = 30.524,
                Latitude = 50.45,
                Port = "Odessa",
                MaxPassengers = 3382,   // https://www.cruisegid.ru/Adventure-of-the-Seas.html
                Price = 500 * Math.Pow(10, 6),  // https://uk.wikipedia.org/wiki/Adventure_of_the_Seas
                Speed = 42,    // 22.5 вузла https://www.metric-conversions.org/uk/shvidkosti/vuzli-v-kilomietri-na-ghodinu.htm
                DateCreate = 2001
            };

            // створення авто
            Car car = new Car()
            {
                Longitude = 30.524,
                Latitude = 50.45,
                Price = 44000,  // https://www.autocentre.ua/ua/news/novinka/tesla-model-3-2018-vse-harakteristiki-i-tseny-novogo-elektrokara-tesla-371871.html
                Speed = 225,
                DateCreate = 2018
            };

            // вивід інформації
            plane.ShowInfo();
            ship.ShowInfo();
            car.ShowInfo();
#endif

#if true    // варіант "лінивий"

            // внесення даних
            Vehicle[] vehicles = new Vehicle[3]
            {
                new Plane()
                {
                    // можна припустити, що в Києві офіс представництва компанії яка продає свій ТЗ
                    Longitude = 30.524,
                    Latitude = 50.45,
                    MaxHight = 12000,
                    MaxPassengers = 467,
                    Speed = 1150,
                    Price = 378.5 * Math.Pow(10, 6),    // https://www.avianews.com/airlines/advice/2016/01/14_airbus_boeing_prices.shtml
                    DateCreate = 2010
                },
                new Ship()
                {
                    Longitude = 30.524,
                    Latitude = 50.45,
                    Port = "Odessa",
                    MaxPassengers = 3382,   // https://www.cruisegid.ru/Adventure-of-the-Seas.html
                    Price = 500 * Math.Pow(10, 6),  // https://uk.wikipedia.org/wiki/Adventure_of_the_Seas
                    Speed = 42,    // 22.5 вузла https://www.metric-conversions.org/uk/shvidkosti/vuzli-v-kilomietri-na-ghodinu.htm
                    DateCreate = 2001
                },
                new Car()
                {
                    Longitude = 30.524,
                    Latitude = 50.45,
                    Price = 44000,  // https://www.autocentre.ua/ua/news/novinka/tesla-model-3-2018-vse-harakteristiki-i-tseny-novogo-elektrokara-tesla-371871.html
                    Speed = 225,
                    DateCreate = 2018
                }
            };

            // вивід результатів
            for (int i = 0; i < vehicles.Length; i++)
            {
                vehicles[i].ShowInfo2();
            }
#endif

            //delay
            DoExitOrRepeat();
        }

        /// <summary>
        /// Метод виходу або повторення методу Main()
        /// </summary>
        static void DoExitOrRepeat()
        {
            Console.WriteLine("\n\nСпробувати ще раз: [т, н]");
            Console.Write("\t");
            var button = Console.ReadKey(true);

            if ((button.KeyChar.ToString().ToLower() == "т") ||
                (button.KeyChar.ToString().ToLower() == "n")) // можливо забули переключити розкладку клавіатури
            {
                Console.Clear();
                Main();
                // без використання рекурсії
                //Process.Start(Assembly.GetExecutingAssembly().Location);
                //Environment.Exit(0);
            }
            else
            {
                // закриває консоль
                Environment.Exit(0);
            }
        }
    }

}
