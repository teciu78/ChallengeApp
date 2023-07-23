namespace ChallengeApp
{
    public class Employee
    {
        public string? Name { get; private set; }
        public string? Surename { get; private set; }

        public int? Age { get; private set; }

        private List<float> grades = new List<float>();

        public bool result = false;

        public Employee(string? name, string? surename, int? age)
        {
            Name = name;
            Surename = surename;
            Age = age;
        }

        public void AddGrade(float grade)
        {
       
            if (grade >= -100 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Podana wartość ({grade}) jest nieprawidłowa! Podaj liczbę zmiennoprzecinkową w zakresie od -100 do 100.");
                Console.WriteLine();
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
                Console.WriteLine("Podana wartość jest nieprawidłowa!");
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

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Sum = 0;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
                statistics.Sum += grade;
            }

            statistics.Average = statistics.Average / this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsUsingForeach()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Sum = 0;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
                statistics.Sum += grade;
            }

            statistics.Average = statistics.Average / this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsUsingFor()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Sum = 0;

            for (int i = 0; i < this.grades.Count; i++)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[i]);
                statistics.Min = Math.Min(statistics.Min, this.grades[i]);
                statistics.Average += this.grades[i];
                statistics.Sum += this.grades[i];
            }

            statistics.Average = statistics.Average / this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsUsingDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Sum = 0;
            var index = 0;

            do
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                statistics.Sum += this.grades[index];
                index++;
            } while (index < this.grades.Count);

            statistics.Average = statistics.Average / this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsUsingWhile()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Sum = 0;
            var index = 0;

            while (index < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                statistics.Sum += this.grades[index];
                index++;
            }

            statistics.Average = statistics.Average / this.grades.Count;
            return statistics;
        }
    }
}
