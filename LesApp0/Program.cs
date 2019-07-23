using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

// Питання:
// що малось на увазі "обов'язково використайте приведення типів"?
// протестувати як поводитиме себе текст при приведенні типів,
// чи необхідно придумати інший алгоритм який би змінював текст 
// використовуючи який базується на приведенні типів?

namespace LesApp0
{
    class Program
    {
        static void Main()
        {
            // Підтримка Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // виведення на екран
            string text = "Якщо прийнято, що перша програма в звичайному програмуванні\n" +
                "має вивести \"Hello World!\", то що має вивести перша програма\n" +
                "яка написана як штучний інтелект для подальшого навчання?";

            // Примітка. Знизу додатково виведені кольори для аналізу поведінки програми.
            // Також, для глибшого аналізу було реалізовано вибір кольорів двома варіантами

#if true
            #region адекватне виконання з різними кольорами
            // upcast
            Printer printer = new DerivedPrinter();
            printer.Print(text);
            
            // downcast
            DerivedPrinter dprinter = (DerivedPrinter)printer;

            // вивід
            printer.Print(text);
            dprinter.Print(text);
            printer.Print(text);

            // висновки, при upcast і downcast програма поводить себе адекватно
            // немає зміни/впливу похіного класу на базовий
            #endregion
#endif

#if false
            // створення базовго класу
            Printer printer = new Printer();
            printer.Print(text);

            // створення похідного класу
            DerivedPrinter dprinter = new DerivedPrinter();

            // виведення результату
            printer.Print(text);
            dprinter.Print(text); 
            printer.Print(text);

            // висновки, при окремому створенні екземплярів класів, а особливо
            // в процесі створення похідного класу, якимось чином це
            // впливає на результати базового класу, хоча вони окрім наслідування
            // не мають мати якісь взаємодії
#endif

#if false
            // створення похідного класу
            DerivedPrinter dprinter = new DerivedPrinter();
            dprinter.Print(text);

            // створення базовго класу
            Printer printer = new Printer();

            // виведення результату
            dprinter.Print(text);
            printer.Print(text);
            dprinter.Print(text);

            // висновки, створення спочатку похідного класу а тоді базового
            // допускає, що в обох класах можуть бути однакові кольори
            // але впливу на похідний клас при створенні базового немає

#endif

            // repeat
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
                //Main();
                // без використання рекурсії
                Process.Start(Assembly.GetExecutingAssembly().Location);
                Environment.Exit(0);
            }
            else
            {
                // закриває консоль
                Environment.Exit(0);
            }
        }
    }
}
