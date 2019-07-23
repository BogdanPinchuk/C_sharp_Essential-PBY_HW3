using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2.Machine
{
    /// <summary>
    /// Літак
    /// </summary>
    class Plane : Vehicle
    {
        /// <summary>
        /// Дата створення літака
        /// </summary>
        private int dateCreate;

        /// <summary>
        /// Максимальна висота в м на якій літає літак
        /// </summary>
        public double MaxHight { get; set; }

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
            // літак не може бути створений майбутньою датою
            // на якому уже можна літати
            // 1885 https://uk.wikipedia.org/wiki/Літак
            set
            {
                if (1885 <= value &&
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

            Console.WriteLine($"\tMax hight: {MaxHight:N2}");
            Console.WriteLine($"\tMax passengers: {MaxPassengers:N0}");
        }

        public override void ShowInfo2()
        {
            base.ShowInfo2();

            Console.WriteLine($"\tMax hight: {MaxHight:N2}");
            Console.WriteLine($"\tMax passengers: {MaxPassengers:N0}");
        }

    }
}
