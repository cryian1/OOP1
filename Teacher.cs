using OOP111;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP111
{
	public class Prepod : Person
	{
		public string Subject { get; set; }
		public string Qualification { get; set; }

		public Prepod(string fullName, int birthYear, int id, string subject, string qualification)
			: base(fullName, birthYear, id)
		{
			Subject = subject;
			Qualification = qualification;
		}

		public override void Print()
		{
			base.Print();
			Console.WriteLine($"Предмет: {Subject}, Квалификация: {Qualification}");
			Console.WriteLine(new string('-', 25));
		}

		public override void Study()
		{
			Console.WriteLine($"Преподаватель {FullName} (ID: {Id}) ведёт предмет '{Subject}'. Квалификация: {Qualification}");
		}
	}
}