using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP111
{
    public class Teacher
    {
        // Автореализуемые свойства
        public string FullName { get; set; }
        public string Degree { get; set; }
        public string Position { get; set; }

        // Свойство только для чтения извне (закрытый set)
        public string[] Disciplines { get; private set; }

        // Конструктор
        public Teacher(string fullName, string degree, string position, string[] disciplines)
        {
            FullName = fullName;
            Degree = degree;
            Position = position;
            // Если передан null, создаём пустой массив
            Disciplines = disciplines ?? new string[0];
        }

        // Метод добавления новой дисциплины
        public void AddDiscipline(string discipline)
        {
            if (string.IsNullOrWhiteSpace(discipline)) return;

            // Создаём новый массив с дополнительным элементом
            string[] newArray = new string[Disciplines.Length + 1];
            for (int i = 0; i < Disciplines.Length; i++)
                newArray[i] = Disciplines[i];

            newArray[Disciplines.Length] = discipline;
            Disciplines = newArray; // присваиваем через private set
        }

        // Метод вывода информации
        public void Print()
        {
            Console.WriteLine($"ФИО: {FullName}");
            Console.WriteLine($"Учёная степень: {Degree}");
            Console.WriteLine($"Должность: {Position}");
            Console.Write("Дисциплины: ");
            if (Disciplines.Length == 0)
                Console.WriteLine("нет");
            else
            {
                for (int i = 0; i < Disciplines.Length; i++)
                {
                    Console.Write(Disciplines[i]);
                    if (i < Disciplines.Length - 1) Console.Write(", ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(new string('-', 30));
        }
    }
}
