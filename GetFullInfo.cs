using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP111
{
	public static class PersonExtensions
	{
		public static string GetFullInfo(this Person person)
		{
			if (person is Student student)
				return $"Студент: {student.FullName}, {student.BirthYear}, группа {student.Group}, балл {student.AverageGrade:F2}";
			if (person is Prepod teacher)
				return $"Преподаватель: {teacher.FullName}, {teacher.BirthYear}, предмет {teacher.Subject}, {teacher.Qualification}";
			return $"{person.FullName}, {person.BirthYear}";
		}
	}
}
