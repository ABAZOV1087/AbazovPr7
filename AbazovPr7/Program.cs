using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbazovPr7
{
    class Program
    {
        /// <summary>
        /// Основной метод для демонстрации отладки строковых переменных.
        /// </summary>
        static void Main(string[] args)
        {
            char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h' };
            string name = "";

            for (int i = 0; i < letters.Length; i++)
            {
                name += letters[i];
                SendMessage(name);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Выводит текущее состояние строки в консоль.
        /// </summary>
        /// <param name="name">Текущее имя.</param>
        static void SendMessage(string name)
        {
            Console.WriteLine("Hello, " + name);
        }
    }
}