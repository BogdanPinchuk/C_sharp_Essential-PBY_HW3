using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2.Machine
{
    /// <summary>
    /// Автомобіль
    /// </summary>
    class Car : Vehicle
    {
        /// <summary>
        /// Дата створення авто, на даному етапі немає смислу
        /// задаватися точним днем, бо його ж ще потрібно правильно ввести
        /// </summary>
        private int dateCreate;

        /// <summary>
        /// Рік випуску 
        /// </summary>
        public override int DateCreate
        {
            get { return dateCreate; }
            // автомобіль не може бути створений майбутньою датою
            // на якому уже можна їздити, а також доцільно захопити
            // бронзову або едвардіанську епоху, припустивши, що
            // продається дороге антикварне авто
            // 1905 https://uk.wikipedia.org/wiki/Історія_автомобіля
            set
            {
                if (1905 <= value &&
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

        public override void ShowInfo2()
        {
            base.ShowInfo2();
        }
    }
}
