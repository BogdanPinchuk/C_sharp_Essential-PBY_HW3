using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1.School
{
    /// <summary>
    /// Двіячники
    /// </summary>
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("\n\tМалоймовірно, що це можливо.");
        }

        public override void Learn()
        {
            Console.WriteLine("\n\tВчиться аби не вигнали з навчального закладу чи лишили на другий рік.");
        }

        public override void Read()
        {
            Console.WriteLine("\n\tМожливо щось читає, але не по навчальній програмі." +
                "\nА якщо і читає по програмі то не може це сприйняти.");
        }

        public override void Write()
        {
            Console.WriteLine("\n\tРідко виконує щось письмово із домашнього завдання.");
        }

        public override void Relax()
        {
            Console.WriteLine("\n\tЗазвичай найбільше часу відпочиває, або ж десь підробляє, " +
                "\nв залежності від ситуації. Частіше всього в цей момент налагоджує зв'язки/знайомства" +
                "\nз іншими важливими/впливовими людьми.");
        }
    }
}
