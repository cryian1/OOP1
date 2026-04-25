using OOP111;
using System;

var dep1 = new UniversityDepartment<Person>();
dep1.AddMember(new Student("Иванов Иван", 2003, 101, "А-21", 4.5));
dep1.AddMember(new Prepod("Смирнов Алексей", 1980, 201, "Математика", "Высшая"));

var dep2 = new UniversityDepartment<Person>();
dep2.AddMember(new Student("Петрова Мария", 2004, 102, "Б-22", 4.8));
dep2.AddMember(new Prepod("Кузнецова Елена", 1975, 202, "Физика", "Кандидат наук"));


var united = dep1 + dep2;
Console.WriteLine("--- Объединённая кафедра --- ");
united.PrintAll();


Console.WriteLine("\n--- Поиск по имени Иван ---");
var found = united.FindByName("Иван");
foreach (var p in found)
{
	Console.WriteLine(p.GetFullInfo());
}


Console.WriteLine($"\n--- Общее количество членов кафедры (всех) ---");
Console.WriteLine(UniversityDepartment<Person>.TotalMembersCount);


Console.WriteLine("\n--- Проверка успеваемости ---");
var student = new Student("Сидоров Петр", 2002, 103, "В-23", 3.9);
if (student)
	Console.WriteLine($"{student.FullName} - успевает");
else
	Console.WriteLine($"{student.FullName} – не успевает");


Console.WriteLine("\n--- Сравнение студентов ---");
var s1 = new Student("Анна", 2003, 104, "А-21", 4.5);
var s2 = new Student("Анна", 2003, 105, "А-21", 4.5);
Console.WriteLine($"s1 == s2: {s1 == s2} (группа и балл совпадают)");
Console.WriteLine($"s1 != s2: {s1 != s2}");


var united = dep1 + dep2;
Console.WriteLine("--- Объединённая кафедра --- ");
united.PrintAll();


Console.WriteLine("\n--- Поиск по имени Иван ---");
var found = united.FindByName("Иван");
foreach (var p in found)
{
	Console.WriteLine(p.GetFullInfo());
}


Console.WriteLine($"\n--- Общее количество членов кафедры (всех) ---");
Console.WriteLine(UniversityDepartment<Person>.TotalMembersCount);


Console.WriteLine("\n--- Проверка успеваемости ---");
var student = new Student("Сидоров Петр", 2002, 103, "В-23", 3.9);
if (student)
	Console.WriteLine($"{student.FullName} - успевает");
else
	Console.WriteLine($"{student.FullName} – не успевает");


Console.WriteLine("\n--- Сравнение студентов ---");
var s1 = new Student("Анна", 2003, 104, "А-21", 4.5);
var s2 = new Student("Анна", 2003, 105, "А-21", 4.5);
Console.WriteLine($"s1 == s2: {s1 == s2} (группа и балл совпадают)");
Console.WriteLine($"s1 != s2: {s1 != s2}");