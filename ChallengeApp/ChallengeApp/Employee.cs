namespace ChallengeApp
{
    public class Employee : IEmployee //Person
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }

        private List<float> grades = new List<float>();

        public bool result = false;

        public event EmployeeBase.GradeAddedDelegate GradeAdded;

        public Employee(string? name, string? surname, int? age, char sex) 
            //: base(name, surname, age, sex)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public void AddGrade(float grade)
        {
       
            if (grade >= -100 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception($"\nPodana wartość ({grade}) jest nieprawidłowa. Podaj liczbę zmiennoprzecinkową w zakresie od -100 do 100.\n");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("Podana wartość jest nieprawidłowa");
            }
        }

        public void AddGrade(int grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(double grade)
        {
            this.AddGrade((float)grade);
        }
        
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Podana wartość jest nieprawidłowa");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }
    }
}
