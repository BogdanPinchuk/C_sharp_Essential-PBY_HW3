using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp3
{
    /// <summary>
    /// Редактор документів - демо
    /// </summary>
    class DocumentWorker
    {
        /// <summary>
        /// Відкриття документа
        /// </summary>
        protected void OpenDocument()
        {
            Console.WriteLine("Документ відкритий.");
        }

        /// <summary>
        /// Корегування документа
        /// </summary>
        protected void EditDocument()
        {
            Console.WriteLine("Редагування документа доступно у версії Про");
        }

        /// <summary>
        /// Збереження документа
        /// </summary>
        protected void SaveDocument()
        {
            Console.WriteLine("Зберігання документа доступно у версії Про");
        }

        public virtual void ShowResult()
        {
            OpenDocument();
            EditDocument();
            SaveDocument();
        }

    }
}
