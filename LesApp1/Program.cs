using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassRoom = LesApp1.School.ClassRoom;
using Pupil = LesApp1.School.Pupil;
using School = LesApp1.School;

namespace LesApp1
{
    class Program
    {
        static void Main()
        {
            // підклчюення Unicode
            Console.OutputEncoding = Encoding.Unicode;

            #region Формування класу
            // так як учны можуть бути різними по знаннях
            // доречно зробити рандом
            Random rnd = new Random();

            // спочатку задамо випадковий вибір учнів від 1 до 4
            // аналіз методу рандому показав, що остання число 
            // не включається в діапазон вибору, тому зробимо діапазон [1, 5)
            int pupilCount = rnd.Next(1, 5);

            // так як учнів є 3 типи, то необхідно зробити вібірку із 3
            // створюємо масив який містить всі типи учнів
            Pupil[] pupilInfo = new Pupil[]
            {
                new School.ExcelentPupil(),
                new School.GoodPupil(),
                new School.BadPupil()
            };

            // створюємо клас на pupilCount кількість місць
            Pupil[] room = new Pupil[pupilCount];

            // випадкове формування класу
            for (int i = 0; i < room.Length; i++)
            {
                // зліва кімната в якій бронюються місця
                // справа іде жеребкування якого типу із 3-х
                // попадетьсся учень на відповідне місце
                // аналогічно враховуємо особливості рандому [0, 3) => [0, 2]
                room[i] = pupilInfo[rnd.Next(0, 3)];
            }
            #endregion

            // знайомимо учнів з класом, заводимо їх в клас
            ClassRoom @class = new ClassRoom(room);

            // тепер вчитель читає характеристику кожного із учнів
            Console.WriteLine($"В класі {room.Length} учнів");
            @class.AnaliseClass();

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
