using OOP111;
using System;

class Program
{
	static void Main()
	{
		var department = new UniversityDepartment<Person>();

		department.AddMember(new Student("Иванов Иван", 2003, 101, "А-21", 4.5));
		department.AddMember(new Student("Петрова Мария", 2004, 102, "Б-22", 4.8));
		department.AddMember(new Prepod("Смирнов Алексей", 1980, 201, "Математика", "Высшая"));
		department.AddMember(new Prepod("Кузнецова Елена", 1975, 202, "Физика", "Кандидат наук"));

		Console.WriteLine("Все члены кафедры:");
		department.PrintAll();

		Console.WriteLine("\nПоиск по имени 'Иван':");
		var found = department.FindByName("Иван");
		foreach (var p in found)
		{
			p.Print();
		}

		Console.WriteLine($"\nОбщее количество членов кафедры: {UniversityDepartment<Person>.TotalMembersCount}");
	}
}