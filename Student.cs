using OOP111;

public class Student : Person
{
	public string Group { get; set; }
	public double AverageGrade { get; set; }

	public Student(string fullName, int birthYear, int id, string group, double averageGrade)
		: base(fullName, birthYear, id)
	{
		Group = group;
		AverageGrade = averageGrade;
	}

	public override void Print()
	{
		base.Print();
		Console.WriteLine($"Группа: {Group}, Средний балл: {AverageGrade:F2}");
		Console.WriteLine(new string('-', 25));
	}

	public override void Study()
	{
		Console.WriteLine($"Студент {FullName} (ID: {Id}) учится в группе {Group}. Балл: {AverageGrade:F2}");
	}



}