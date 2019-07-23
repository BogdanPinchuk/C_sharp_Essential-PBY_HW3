using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0
{
    /// <summary>
    /// Принтер (похідний клас)
    /// </summary>
    class DerivedPrinter : Printer
    {
        /// <summary>
        /// Колір тексту - випадковий;
        /// from class DerivedPrinter
        /// </summary>
        protected static new ConsoleColor TextColor { get; private set; }
        /// <summary>
        /// Колір фону - випадковий;
        /// from class DerivedPrinter
        /// </summary>
        protected new ConsoleColor BackgroundColor { get; private set; }

        public DerivedPrinter() : base()
        {
            SetColor();
        }

        /// <summary>
        /// Уставновка кольору
        /// </summary>
        protected new void SetColor()
        {
            TextColor = ChangeColor.RandomColor(Printer.TextColor, base.BackgroundColor);
            BackgroundColor = ChangeColor.RandomColor(Printer.TextColor, base.BackgroundColor, TextColor);
        }

        /// <summary>
        /// Друк
        /// </summary>
        /// <param name="value"></param>
        public new void Print(string value)
        {
            //c

            Console.ForegroundColor = TextColor;
            Console.BackgroundColor = BackgroundColor;
            Console.WriteLine($"\n\t" + value + "\n");
            // Підпис
            Console.WriteLine("\tHandwriting: " + this.ToString());
            Console.ResetColor();
            Console.WriteLine(TextColor);
            Console.WriteLine(BackgroundColor);
        }

    }
}
