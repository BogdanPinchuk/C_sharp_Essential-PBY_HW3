using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1.School
{
    /// <summary>
    /// Відмінники
    /// </summary>
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("\n\tІз імовірністю в 5-10% можливо сам займається самоосвітою, " +
                "\nтобто щось додатково читає, пробує вивести і довести.");
        }

        public override void Learn()
        {
            Console.WriteLine("\n\tВідмінно вчиться, має чудову успішність.");
        }

        public override void Read()
        {
            Console.WriteLine("\n\tЧитає все, що задано на домашнє завдання і можливо щось додатково.");
        }

        public override void Write()
        {
            Console.WriteLine("\n\tВиконує письмово всі домашні завдання.");
        }

        public override void Relax()
        {
            Console.WriteLine("\n\tВідпочиває рідко але по максимуму.");
        }
    }
}
