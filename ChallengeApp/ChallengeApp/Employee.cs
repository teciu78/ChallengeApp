namespace ChallengeApp
{
    public class Employee : Person
    {

        private List<float> grades = new List<float>();

        public bool result = false;

        public Employee(string? name, string? surname, int? age, char sex) 
            : base(name, surname, age, sex)
        {

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

        public void AddGrade(long grade)
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
            var statistics = new Statistics()
            {
                Average = 0,
                Max = float.MinValue,
                Min = float.MaxValue,
                Sum = 0
            }; 

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
                statistics.Sum += grade;
            }

            statistics.Average = statistics.Average / this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average > 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average > 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average > 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average > 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }
    }
}
