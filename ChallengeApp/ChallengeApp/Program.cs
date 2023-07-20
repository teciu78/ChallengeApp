using ChallengeApp;
using System.Globalization;

string name = "";
string surename = "";
int age = 0;
string pointsQuestion= "";
int count = 0;
float points = 0f;
int empNo = 1;
string exit;
int pointsNo = 0;
bool valid = true;

List<Employee> employees = new List<Employee>();

do
{
    Console.Clear();
    Console.WriteLine("------------------------------");
    Console.WriteLine($"WPROWADŹ DANE PRACOWNIKA NR: {empNo}");
    Console.WriteLine("------------------------------");

    Console.Write("Podaj imię pracownika: ");
    name = Console.ReadLine();

    do
    {
        Console.Write("Podaj nazwisko pracownika: ");
        surename = Console.ReadLine();

        if (string.IsNullOrEmpty(surename))
        {
            Console.WriteLine();
            Console.WriteLine("Podaj imię pracownika! Spróbuj ponownie.");
            Console.WriteLine();
        }


    } while (string.IsNullOrEmpty(surename));

    valid = true;
    do
    {
        Console.Write("Podaj wiek pracownika: ");
        try
        {
            age = Convert.ToInt32(Console.ReadLine());
            valid = true;
        }
        catch
        {
            Console.WriteLine();
            Console.WriteLine("Podana wartość jest nieprawidłowa! Spróbuj ponownie.");
            Console.WriteLine();
            valid = false;
        }

        if (valid && age < 18)
        {
            Console.WriteLine();
            Console.WriteLine("Podany wiek jest nieprawidłowy! Minimalny wiek to 18 lat.");
            Console.WriteLine();
            valid = false;
        }
    }
    while (!valid);

    Console.Write("Czy chcesz dodać punkty? (Y/N) ");
    pointsQuestion = Console.ReadLine();

    if (pointsQuestion.Equals("Y", StringComparison.OrdinalIgnoreCase))
    {
        do
        {
            Console.Write("Ile wyników chcesz dodać? ");
            try
            {
                count = Convert.ToInt32(Console.ReadLine());
                valid = true;
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Podana wartość jest nieprawidłowa! Spróbuj ponownie.");
                Console.WriteLine();
                valid = false;
            }
        }
        while (!valid);

        employees.Add(new Employee ( name, surename, age));

        pointsNo = 0;
        points = 0;

        do
        {
            pointsNo++;

            valid = true;
            do
            {
                Console.Write($"Podaj wynik nr {pointsNo}: ");
                try
                {
                    points = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
                    valid = true;
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("Podana wartość jest nieprawidłowa! Spróbuj ponownie.");
                    Console.WriteLine();
                    valid = false;
                }

                if (points < -100 || points > 100)
                {
                    Console.WriteLine();
                    Console.WriteLine("Podana wartość jest nieprawidłowa! Podaj liczbę zmiennoprzecinkową w zakresie od -100 do 100.");
                    Console.WriteLine();
                    valid = false;
                }
            }
            while (!valid);

            var index = employees.FindIndex(x => x.Name == name);
            employees[index].AddGrade(points);

        }
        while (pointsNo != count);
    }

    Console.WriteLine("------------------------------------------------------------------------------------------");
    Console.WriteLine("LISTA WPROWADZONYCH PRACOWNIKÓW");

    foreach (var employee in employees)
    {
        var statistics = employee.GetStatistics();
        Console.WriteLine("------------------------------------------------------------------------------------------");
        Console.WriteLine($"Pracownik : {employee.Name} {employee.Surename}, lat {employee.Age}.");
        Console.WriteLine("------------------------------------------------------------------------------------------");
        Console.WriteLine($"Suma punktów: {statistics.Sum:N2}");
        Console.WriteLine($"Minimalny wynik: {statistics.Min:N2}");
        Console.WriteLine($"Maksymalny wynik: {statistics.Max:N2}");
        Console.WriteLine($"Średnia punktów: {statistics.Average:N2}");
    }

    Console.WriteLine("-------------------------------------------");
    Console.Write("Czy chesz dodać kolejnego pracownika? (Y/N) ");
    exit = Console.ReadLine();
    empNo++;

} while (!exit.Equals("N", StringComparison.OrdinalIgnoreCase));

Console.Clear();
Console.WriteLine("-------------------------------");
Console.WriteLine("DZIĘKUJĘ ZA WPROWADZENIE DANYCH");
Console.WriteLine("-------------------------------");




