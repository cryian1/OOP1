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
		private string _fullName;
		private int _birthYear;
		protected int _id;

		public string fullName
		{
			get => _fullName;
			set => _fullName = value;
		}

		public int birthYear
		{
			get => _birthYear;
			set
			{
				if (value > 1900 && value <= DateTime.Now.Year)
					_birthYear = value;
				else
					throw new ArgumentException("Некорректный год рождения");
			}
		}

		public Person(string fullName, int birthYear, int id)
		{
			_fullName = fullName;
			_birthYear = birthYear;
			_id = id;
		}

		public virtual void Print()
		{
			Console.WriteLine($"fullName: {fullName}");
			Console.WriteLine($"birthYear: {birthYear}");
		}

		public abstract void Study();
	}
}