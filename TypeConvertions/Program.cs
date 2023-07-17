


Console.Write("What is your Age: ");
string? ageText = Console.ReadLine();

bool isValidInt =int.TryParse(ageText,out int age);

Console.WriteLine($"This is valid: {isValidInt}");
if (isValidInt)
{
    Console.WriteLine(age + 15);
}

double testDouble = age;
decimal testDecimal = (decimal) testDouble;
