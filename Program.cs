using OOP111;

string fullName = "Иванов Иван Иванович";
string degree = "к.т.н.";
string position = "доцент";
string[] disciplines = new string[] { "Математика", "Физика" };

Teacher t = new Teacher(fullName, degree, position, disciplines);
t.Print();
Teacher teacher = new Teacher();
teacher.Print();
t.AddDiscipline("Информатика");
t.Print();