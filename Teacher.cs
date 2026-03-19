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
		private string _subject;
		private string _qualification;

		public string subject
		{
			get => _subject;
			set => _subject = value;
		}

		public string qualification
		{
			get => _qualification;
			set => _qualification = value;
		}

		public Prepod(string fullName, int birthYear, int id, string subject, string qualification)
			: base(fullName, birthYear, id)
		{
			_subject = subject;
			_qualification = qualification;
		}

		public override void Print()
		{
			base.Print();
			Console.WriteLine($"subject: {subject}");
			Console.WriteLine($"qualification: {qualification}");
			Console.WriteLine(new string('-', 25));
		}

		public override void Study()
		{
			Console.WriteLine($"Преподаватель {fullName} (ID: {_id}) ведёт предмет '{subject}'. Квалификация: {qualification}");
		}
	}
}