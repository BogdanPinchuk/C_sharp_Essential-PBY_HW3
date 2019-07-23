using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1.School
{
    /// <summary>
    /// Хорошисти
    /// </summary>
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("\n\tІз імовірністю в 75-85% сам займається самоосвітою, " +
                "\nтобто щось додатково читає, пробує вивести і довести.");
        }

        public override void Learn()
        {
            Console.WriteLine("\n\tДобре навчається, предмети які йому цікаві вивчає більш детально," +
                "\nа інші менш важливі і не цікаві виконує для галочки.");
        }

        public override void Read()
        {
            Console.WriteLine("\n\tЧитає, в першу чергу, те що цікаво, а інше по бажанню і якщо є час.");
        }

        public override void Write()
        {
            Console.WriteLine("\n\tВиконує письмово, в першу чергу, те що цікаво, а інше по бажанню або для галочки.");
        }

        public override void Relax()
        {
            Console.WriteLine("\n\tБалансує між навчанням і відпочинком. " +
                "\nВисока оцінка по нецікавому предмету не важливіша за здоров'я.");
        }
    }
}
