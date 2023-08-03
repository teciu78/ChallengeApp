namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        public string Name => "Franek";
        public string Surname => "Dzbanek";

        private List<float> grades = new List<float>();

        public event EmployeeBase.GradeAddedDelegate GradeAdded;

        public Supervisor() 
        { 
        }

        public void AddGrade(string grade)
        {
            float points = 0;
            var sign = "";

            if (grade.Contains('+') || !grade.Contains('-'))
            {
                if (grade.Contains('+')) 
                {
                    grade = grade.Replace("+", ""); 
                    sign = "+";
                }

                if (float.TryParse(grade, out float result))
                {

                    if (result >= 1 && result <= 6)
                    {
                        switch (result)
                        {
                            case 1:
                                break;
                            case 2:
                                points = 25;
                                break;
                            case 3:
                                points = 40;
                                break;
                            case 4:
                                points = 60;
                                break;
                            case 5:
                                points = 80;
                                break;
                            case 6:
                                points = 100;
                                break;
                        }
                    }
                    else
                    {
                        throw new Exception("Podana wartość jest nieprawidłowa");
                    }
                }
                else
                {
                    throw new Exception("Podana wartość jest nieprawidłowa");
                }
            }
            if (grade.Contains('-'))
            {
                grade = grade.Replace("-", "");

                sign = "-";


                if (float.TryParse(grade, out float result))
                {

                    switch (result)
                    {
                        case 1:
                            break;
                        case 2:
                            points = 20;
                            break;
                        case 3:
                            points = 35;
                            break;
                        case 4:
                            points = 55;
                            break;
                        case 5:
                            points = 75;
                            break;
                        case 6:
                            points = 95;
                            break;
                    }
                }
                else
                {
                    throw new Exception("Podana wartość jest nieprawidłowa");
                }
            }
            this.grades.Add(points);
            Console.WriteLine($"Za otrzymaną ocenę {sign}{grade} dostajesz {points} punktów");
        }

        public void AddGrade(float grade)
        {
            this.grades.Add(grade);
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
            //throw new NotImplementedException();
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
            return statistics;
        }
    }
}
