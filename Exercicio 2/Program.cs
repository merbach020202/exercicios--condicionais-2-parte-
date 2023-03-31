
Console.WriteLine("Digite o 1º número");
int número = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o 2º número");
int número2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o 3º número");
int número3 = int.Parse(Console.ReadLine());

if (número > número2 && número > número3)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"O maior número é {número}");
    Console.ResetColor();
}
else if (número2 > número && número2 > número3)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"O maior número é {número2}");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"O maior número é {número3}");
    Console.ResetColor();
}


if (número < número2 && número < número3)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"O menor número é {número}");
    Console.ResetColor();
}
else if (número2 < número && número2 < número3)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"O menor número é {número2}");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"O menor número é {número3}");
    Console.ResetColor();
}







