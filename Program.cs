using OOP111;
using System.Collections.Generic;

List<Person> people = new List<Person>();

people.Add(new Student("Иванов Иван", 2003, 101, "А-21", 4.5));
people.Add(new Student("Петрова Мария", 2004, 102, "Б-22", 4.8));
people.Add(new Prepod("Смирнов Алексей", 1980, 201, "Математика", "Высшая"));
people.Add(new Prepod("Кузнецова Елена", 1975, 202, "Физика", "Кандидат наук"));

foreach (Person p in people)
{
	p.Study();
	p.Print();
}