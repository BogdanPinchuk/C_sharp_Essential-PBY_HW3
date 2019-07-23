using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1.School
{
    /// <summary>
    /// Учень
    /// </summary>
    class Pupil
    {
        /// <summary>
        /// Вивчає, 
        /// хоча по ідеї study - це наукова діяльність,
        /// яка включає дослідження і це уже можна сказати на рівні Master
        /// магістра і вище, а от до цього моменту краще вживати learn тобто вчаться
        /// </summary>
        public virtual void Study() { }

        /// <summary>
        /// Вчиться
        /// </summary>
        public virtual void Learn() { }

        /// <summary>
        /// Читає
        /// </summary>
        public virtual void Read() { }

        /// <summary>
        /// Пише
        /// </summary>
        public virtual void Write() { }

        /// <summary>
        /// Відпочиває
        /// </summary>
        public virtual void Relax() { }
    }
}
