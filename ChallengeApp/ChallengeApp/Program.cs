int number = 4566;
string numberInString = number.ToString();
char[] letters= numberInString.ToArray();
int numberCount;

for (int i = 0; i < 10; i++)
{
    numberCount = 0;
    foreach (char letter in letters)
    {
        if (letter.ToString() == i.ToString())
        {
            numberCount++;
        }
    }
    Console.WriteLine($"{i} => {numberCount}");
}