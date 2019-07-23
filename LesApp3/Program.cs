using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp3
{
    class Program
    {
        static void Main()
        {
            // Підтримка Unicode
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("\nВведіть ключ доступу: ");
            string key = Console.ReadLine();

            // чистка консолі після введення ключа
            Console.Clear();

            // "каркас" програми
            DocumentWorker proga = new ExpertDocumentWorker();

            // надання доступу згідно ключа
            //// я вирішив облекшити життя користувачам і убрав прив'язку до регістру букв
            if (key.ToLower() == "exp")
            {
                Console.WriteLine("\nЛаскаво просимо у версію програми експерт.\n");
                proga = new ExpertDocumentWorker();
            }
            else if (key.ToLower() == "pro")
            {
                Console.WriteLine("\nЛаскаво просимо у професійну версію програми.\n");
                proga = new ProDocumentWorker();
            }
            else
            {
                Console.WriteLine("\nКлючі доступу невірні. Вам доступна лише демо-версія.\n");
                proga = new DocumentWorker();
            }

            proga.ShowResult();

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
                Main();
                //без використання рекурсії
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
