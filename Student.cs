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


	public static bool operator ==(Student a, Student b)
	{
		if (ReferenceEquals(a, b)) return true;
		if (a is null || b is null) return false;
		return a.Group == b.Group && a.AverageGrade == b.AverageGrade;
	}

	public static bool operator !=(Student a, Student b) => !(a == b);


	public static bool operator true(Student s) => s?.AverageGrade >= 4.0;
	public static bool operator false(Student s) => s?.AverageGrade < 4.0;

	public override bool Equals(object obj) => obj is Student other && this == other;
	public override int GetHashCode() => HashCode.Combine(Group, AverageGrade);
}