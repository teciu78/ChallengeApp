using ChallengeApp;

List<Employee> employees = new List<Employee>();    

Employee employee1 = new Employee("Jan", "Kowalski", 41, 0);
Employee employee2 = new Employee("Artur", "Wiśniewski", 66, 0);
Employee employee3 = new Employee("Stanisław", "Tym", 85, 0);

employee1.AddScore(10);
employee1.AddScore(5);
employee1.AddScore(2);
employee1.AddScore(7);
employee1.AddScore(3);

employee2.AddScore(2);
employee2.AddScore(4);
employee2.AddScore(9);
employee2.AddScore(8);
employee2.AddScore(3);

employee3.AddScore(10);
employee3.AddScore(9);
employee3.AddScore(9);
employee3.AddScore(10);
employee3.AddScore(9);

employees.Add(employee1);
employees.Add(employee2);
employees.Add(employee3);

var maxScore = employees.Max(r => r.score);

foreach (var employee in employees)
{
	if (employee.score == maxScore)
	{
        Console.WriteLine($"Najwięcej, bo aż {employee.score} punktów zdobył {employee.name} {employee.surename}");
    }
}

