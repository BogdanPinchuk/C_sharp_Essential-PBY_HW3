using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1.School
{
    /// <summary>
    /// Навчальний клас
    /// </summary>
    class ClassRoom
    {
        /// <summary>
        /// Кількість учнів в класі
        /// </summary>
        private int pupilCount = 4;

        /// <summary>
        /// Учні в класі
        /// </summary>
        public Pupil[] pupils;

        /// <summary>
        /// Занесення учнів в базу даних
        /// </summary>
        /// <param name="pupils">учні</param>
        public ClassRoom(params Pupil[] pupils)
        {
            if (pupils.Length < 1)
            {
                Console.WriteLine("\n\tВ класі немає учнів.");
            }
            else if (pupils.Length > pupilCount)
            {
                Console.WriteLine("\n\tВ класі не повинно бути більше 4-х учнів.");
            }
            else
            {
                // заносимо учнів в клас (в міні базу даних)
                this.pupils = pupils;
            }
        }

        /// <summary>
        /// Аналіз всіх учнів
        /// </summary>
        public void AnaliseClass()
        {
            for (int i = 0; i < pupils.Length; i++)
            {
                // аналіз навчання учнів
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nУчень №{i + 1}\n");
                Console.ResetColor();
                pupils[i].Learn();
                pupils[i].Study();
                pupils[i].Read();
                pupils[i].Write();
                pupils[i].Relax();
            }
        }
    }
}
