using ChallengeApp;

Console.WriteLine("WItamy w programie ChallengeApp do oceny Pracowników");
Console.WriteLine("----------------------------------------------------");
Console.WriteLine();

var employee = new Employee("Franek", "Dzbanek", 45);

while (true)
{
    Console.WriteLine("Podaj kolejną ovenę pracownika:");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}

var statistics1 = employee.GetStatistics();

Console.WriteLine($"Average: {statistics1.Average}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");


