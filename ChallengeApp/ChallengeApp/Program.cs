using ChallengeApp;

Console.WriteLine("Witamy w programie ChallengeApp do oceny pracowników");
Console.WriteLine("----------------------------------------------------");
Console.WriteLine();

var employee = new Employee("Franek", "Dzbanek", 45);

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika:");
    var input = Console.ReadLine();
    {
        if (input == "q" || input == "Q")
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

    var statistics1 = employee.GetStatistics();

if (!float.IsNaN(statistics1.Average))
{
    Console.WriteLine($"\nAverage: {statistics1.Average}");
    Console.WriteLine($"Min: {statistics1.Min}");
    Console.WriteLine($"Max: {statistics1.Max}");
}
else
{
    Console.WriteLine("\nNie zostały wprowadzone żadne dane\n");
}

