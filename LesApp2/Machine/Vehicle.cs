using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// тобто координати? координати транспорту, де продається?
// тому що краще б сказати розміри або конструктивні параметри

namespace LesApp2.Machine
{
    /// <summary>
    /// Транспортний засіб
    /// </summary>
    class Vehicle
    {
        /// <summary>
        /// Дата створення авто, на даному етапі немає смислу
        /// задаватися точним днем, бо його ж ще потрібно правильно ввести
        /// </summary>
        private int dateCreate;
        /// <summary>
        /// ціна
        /// </summary>
        private double price;

        /// <summary>
        /// Широта в градусах або радінах
        /// </summary>
        public double Latitude { get; set; }
        /// <summary>
        /// Довгота в градусах або радінах
        /// </summary>
        public double Longitude { get; set; }
        /// <summary>
        /// Ціна
        /// </summary>
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("\n\tНереальна ціна.");
                }
                else
                {
                    price = value;
                }
            }
        }
        /// <summary>
        /// Швидкість км/год або м/с
        /// можна припустити, що від'ємна швидкість - це задній хід
        /// </summary>
        public int Speed { get; set; }
        /// <summary>
        /// Рік випуску 
        /// </summary>
        public virtual int DateCreate
        {
            get { return dateCreate; }
            // 1905 https://uk.wikipedia.org/wiki/Історія_автомобіля
            // 1885 https://uk.wikipedia.org/wiki/Літак
            // 1855 https://uk.wikipedia.org/wiki/Корабель
            set
            {
                if (1855 <= value &&
                    value <= DateTime.Now.Year)
                {
                    dateCreate = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tПомилка введення дати.");
                    Console.ResetColor();
                }
            }
        }

        /// <summary>
        /// Відображає інформацію про транспортний засіб
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine($"\nТранспортний засіб: {this.GetType().Name}\n");
            Console.WriteLine($"\tLatitude: {Latitude:N2}");
            Console.WriteLine($"\tLongitude: {Longitude:N2}");
            Console.WriteLine($"\tPrice: {Price:N2}");
            Console.WriteLine($"\tSpeed: {Speed:N0}");
            Console.WriteLine($"\tYear of create: {DateCreate}");
        }

        public virtual void ShowInfo2()
        {
            Console.WriteLine($"\nТранспортний засіб: {this.GetType().Name}\n");
            Console.WriteLine($"\tLatitude: {Latitude:N2}");
            Console.WriteLine($"\tLongitude: {Longitude:N2}");
            Console.WriteLine($"\tPrice: {Price:N2}");
            Console.WriteLine($"\tSpeed: {Speed:N0}");
            Console.WriteLine($"\tYear of create: {DateCreate}");
        }

    }
}
