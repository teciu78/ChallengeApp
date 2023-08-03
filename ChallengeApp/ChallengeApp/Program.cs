using ChallengeApp;

Console.WriteLine("\nWitamy w programie ChallengeApp do oceny pracowników");
Console.WriteLine("----------------------------------------------------");

var employee = new EmployeeInFile("Franek", "Dzbanek");

while (true)
{
    Console.WriteLine("\nPodaj kolejną ocenę pracownika:");
    var input = Console.ReadLine();
    {
        if (input == "q" || input == "Q")
            break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

var statistics = employee.GetStatistics();

if (!float.IsNaN(statistics.Average))
{
    Console.WriteLine($"\nPracownik zdobył łącznie: {statistics.Sum:N2} punktów.");
    Console.WriteLine($"\nAverage: {statistics.Average:N2}");
    Console.WriteLine($"Min: {statistics.Min:N2}");
    Console.WriteLine($"Max: {statistics.Max:N2}");
}
else
{
    Console.WriteLine("\nNie zostały wprowadzone żadne dane\n");
}

