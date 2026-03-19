using OOP111;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP111
{
	public class Student : Person
	{
		private string _group;
		private double _averageGrade;

		public string group
		{
			get => _group;
			set => _group = value;
		}

		public double averageGrade
		{
			get => _averageGrade;
			set
			{
				if (value >= 0 && value <= 5)
					_averageGrade = value;
				else
					throw new ArgumentException("Средний балл должен быть от 0 до 5");
			}
		}

		public Student(string fullName, int birthYear, int id, string group, double averageGrade)
			: base(fullName, birthYear, id)
		{
			_group = group;
			_averageGrade = averageGrade;
		}

		public override void Print()
		{
			base.Print();
			Console.WriteLine($"group: {group}");
			Console.WriteLine($"averageGrade: {averageGrade:F2}");
			Console.WriteLine(new string('-', 25));
		}

		public override void Study()
		{
			Console.WriteLine($"Студент {fullName} (ID: {_id}) учится в группе {group}. Средний балл: {averageGrade:F2}");
		}
	}
}