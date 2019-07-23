using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0
{
    /// <summary>
    /// Принтер (базовий клас)
    /// </summary>
    class Printer
    {
        /// <summary>
        /// Колір тексту - випадковий;
        /// from class Printer
        /// </summary>
        protected static ConsoleColor TextColor { get; private set; } //= ChangeColor.RandomColor();
        /// <summary>
        /// Колір фону - випадковий;
        /// from class Printer
        /// </summary>
        protected ConsoleColor BackgroundColor { get; private set; } //= ChangeColor.RandomColor(TextColor);

        public Printer()
        {
            SetColor();
        }

        /// <summary>
        /// Уставновка кольору
        /// </summary>
        protected void SetColor()
        {
            TextColor = ChangeColor.RandomColor();
            BackgroundColor = ChangeColor.RandomColor(TextColor);
        }

        /// <summary>
        /// Друк
        /// </summary>
        /// <param name="value"></param>
        internal void Print(string value)
        {
            //SetColor();

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
