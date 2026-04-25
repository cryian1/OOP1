using OOP111;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP111
{
	public class UniversityDepartment<T> where T : Person
	{
		private List<T> _members = new List<T>();
		private static int _totalMembersCount = 0;

		public static int TotalMembersCount => _totalMembersCount;

		public void AddMember(T person)
		{
			_members.Add(person);
			_totalMembersCount++;
		}


		public List<T> FindByName(string name)
		{
			List<T> result = new List<T>();
			string lowerName = name.ToLower();
			foreach (T person in _members)
			{
				if (person.FullName.ToLower().Contains(lowerName))
				{
					result.Add(person);
				}
			}
			return result;
		}

		public void PrintAll()
		{
			foreach (T person in _members)
			{
				person.Print();
			}
		}

	

	}
}
