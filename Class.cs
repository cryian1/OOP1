using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP111
{
    public class Teacher
    {
        public string FullName { get; set; }
        public string Degree { get; set; }
        public string Position { get; set; }

        public string[] Disciplines { get; set; }

        public Teacher(string fullName, string degree, string position, string[] disciplines)
        {
            FullName = fullName;
            Degree = degree;
            Position = position;
            Disciplines = disciplines ?? new string[0];
        }
        public Teacher()
        {
            FullName = "Иванов Иван";
            Degree = "Доцент";
            Position = "Доцент";
            Disciplines = new string[] { "Математика", "физика" };
        }
        public void AddDiscipline(string discipline)
        {
            if (string.IsNullOrWhiteSpace(discipline)) return;

            string[] newArray = new string[Disciplines.Length + 1];
            for (int i = 0; i < Disciplines.Length; i++)
                newArray[i] = Disciplines[i];

            newArray[Disciplines.Length] = discipline;
            Disciplines = newArray; 
        }

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
