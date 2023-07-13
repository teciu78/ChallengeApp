using ChallengeApp;

List<Employee> employees = new List<Employee>();    

Employee employee1 = new Employee("Jan", "Kowalski", 41, 89);
Employee employee2 = new Employee("Artur", "Wiśniewski", 66, 94);
Employee employee3 = new Employee("Stanisław", "Tym", 85, 100);

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

