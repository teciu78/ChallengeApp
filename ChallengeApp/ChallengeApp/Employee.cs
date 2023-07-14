namespace ChallengeApp
{
    public class Employee
    {
        public string name { get; set; }
        public string surename { get; set; }
        public int age { get; set; }
        public int score { get; set; }

        public Employee(string name, string surename, int age, int score)
        {
            this.name = name;
            this.surename = surename;
            this.age = age;
            this.score = score;
        }

        public void AddScore(int score)
        {
            this.score += score;
        }
    }
}
