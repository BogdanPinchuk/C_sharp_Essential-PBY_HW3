using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2.Machine
{
    /// <summary>
    /// Човен
    /// </summary>
    class Ship : Vehicle
    {
        /// <summary>
        /// Дата створення корабля
        /// </summary>
        private int dateCreate;

        /// <summary>
        /// Порт приписки
        /// </summary>
        public string Port { get; set; }

        /// <summary>
        /// Максимальна кількість пасажирів
        /// </summary>
        public int MaxPassengers { get; set; }

        /// <summary>
        /// Рік випуску 
        /// </summary>
        public override int DateCreate
        {
            get { return dateCreate; }
            // корабль не може бути створений майбутньою датою
            // на якому уже можна плавати
            // 1855 https://uk.wikipedia.org/wiki/Корабель
            set
            {
                if (1855 <= value &&
                    value <= DateTime.Now.Year)
                {
                    dateCreate = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tПомилка введення дати.");
                    Console.ResetColor();
                }
            }
        }

        public new void ShowInfo()
        {
            base.ShowInfo();

            Console.WriteLine($"\tMax passengers: {MaxPassengers:N0}");
            Console.WriteLine($"\tPort: {Port:N2}");
        }

        public override void ShowInfo2()
        {
            base.ShowInfo2();

            Console.WriteLine($"\tMax passengers: {MaxPassengers:N0}");
            Console.WriteLine($"\tPort: {Port:N2}");
        }

    }
}
