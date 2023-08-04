using System.Diagnostics;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";

        public override event GradeAddedDelegate GradeAdded;

        public EmployeeInFile(string name, string surname) 
            : base(name, surname)
        {
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (Char.TryParse(grade, out char letter))
            {
                this.AddGrade(letter);
            }
            else
            {
                throw new Exception("Podana wartość jest nieprawidłowa");
            }
        }

        public override void AddGrade(float grade)
        {
            if (grade >= -100 && grade <= 100)
            {
                try
                {
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(grade);
                    }

                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"File error: {e}");
                }
            }
            else
            {
                throw new Exception($"\nPodana wartość ({grade}) jest nieprawidłowa. Podaj liczbę zmiennoprzecinkową w zakresie od -100 do 100.\n");
            }
        }

        public override void AddGrade(int grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(double grade)
        {
            this.AddGrade((float)grade);
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    Console.WriteLine("Dodano 100 punktów.");
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    Console.WriteLine("Dodano 80 punktów.");
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    Console.WriteLine("Dodano 60 punktów.");
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    Console.WriteLine("Dodano 40 punktów.");
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    Console.WriteLine("Dodano 20 punktów.");
                    break;
                default:
                    throw new Exception("Podana wartość jest nieprawidłowa");
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            try
            {
                using (var reader = File.OpenText(fileName))
                {
                    string? line;
                    int count = 0;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var number = float.Parse(line);
                        result.AddGrade(number);
                        count++;
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            return result;
        }
    }
}
