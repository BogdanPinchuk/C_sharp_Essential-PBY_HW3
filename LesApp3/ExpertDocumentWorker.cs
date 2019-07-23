using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp3
{
    /// <summary>
    /// Редактор документів - версія експерт
    /// </summary>
    class ExpertDocumentWorker : ProDocumentWorker
    {
        /// <summary>
        /// Збереження документа в іншому форматі
        /// </summary>
        protected new void SaveAsDocument()
        {
            Console.WriteLine("Документ збережено в новому форматі.");
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
