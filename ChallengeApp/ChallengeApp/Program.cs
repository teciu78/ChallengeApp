using ChallengeApp;

Console.WriteLine("\nWitamy w programie ChallengeApp do oceny pracowników");
Console.WriteLine("----------------------------------------------------");

var employee = new EmployeeInMemory("Franek", "Dzbanek");
employee.GradeAdded += EmployeeGradeAdded;

var employee1 = new EmployeeInFile("Franek", "Dzbanek");
employee1.GradeAdded += EmployeeGradeSaved;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

void EmployeeGradeSaved(object sender, EventArgs args)
{
    Console.WriteLine("Zapisano nową ocenę");
}





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
        employee1.AddGrade(input);
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

