using OOP111;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP111
{

    public abstract class Person : ILearnable
	{
		public string FullName { get; set; }
		public int BirthYear { get; set; }
		protected int Id { get; set; }

		public Person(string fullName, int birthYear, int id)
		{
			FullName = fullName;
			BirthYear = birthYear;
			Id = id;
		}

		public virtual void Print()
		{
			Console.WriteLine($"ФИО: {FullName}, Год рождения: {BirthYear}");
		}

		public abstract void Study();
	}
}