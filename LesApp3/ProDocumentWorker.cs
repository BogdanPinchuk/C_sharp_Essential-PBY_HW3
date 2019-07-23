using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp3
{
    /// <summary>
    /// Редактор документів - професійна версія
    /// </summary>
    class ProDocumentWorker : DocumentWorker
    {
        /// <summary>
        /// Корегування документа
        /// </summary>
        protected new void EditDocument()
        {
            Console.WriteLine("Документ відредагований.");
        }

        /// <summary>
        /// Збереження документа
        /// </summary>
        protected new void SaveDocument()
        {
            Console.WriteLine("Документ збережено в старому форматі.");
        }

        /// <summary>
        /// Збереження документа в іншому форматі
        /// </summary>
        protected void SaveAsDocument()
        {
            Console.WriteLine("Збереження в інших форматах доступно у версії Експерт.");
        }

        public override void ShowResult()
        {
            OpenDocument();
            EditDocument();
            SaveDocument();
            SaveAsDocument();
        }

    }
}
