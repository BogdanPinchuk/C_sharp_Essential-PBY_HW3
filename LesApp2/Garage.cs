using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle = LesApp2.Machine.Vehicle;

namespace LesApp2
{
    /// <summary>
    /// Гараж або ж база даних транспорту
    /// </summary>
    class Garage
    {
        /// <summary>
        /// Транспорт в гаражі
        /// </summary>
        public Vehicle[] vehicles;

        /// <summary>
        /// Занесення транспорту в базу даних
        /// </summary>
        /// <param name="vehicles">транспорт</param>
        public Garage(params Vehicle[] vehicles)
        {
            if (vehicles.Length < 1)
            {
                Console.WriteLine("\n\tУ Вас немає транспорту, немає що ставити в гараж.");
            }
            else
            {
                // заносимо учнів в клас (в міні базу даних)
                this.vehicles = vehicles;
            }
        }

        /// <summary>
        /// Аналіз всього транспорту
        /// </summary>
        public void AnaliseClass()
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                // аналіз транспорту в гаражі
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nТранспорт №{i + 1}\n");
                Console.ResetColor();
            }
        }

    }
}
