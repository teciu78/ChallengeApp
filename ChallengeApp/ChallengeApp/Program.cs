string name = "Ewa";
bool isFemale = true;
int age = 33;

if (isFemale)
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else
    {
        Console.WriteLine($"{name}, lat {age}");
    }
} 
else if (!isFemale)
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni Mężczyzna");
    } 
    else
    {
        Console.WriteLine($"{name}, lat {age}");
    }
}