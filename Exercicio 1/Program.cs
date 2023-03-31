

Console.WriteLine($"Em qual dia você nasceu?: ");
int dia = int.Parse(Console.ReadLine());
//DIAS
if (dia > 31 )
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valor inválido (O dia foi digitado incorretamente)");
    Console.ResetColor();
}

else 
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Valor válido");
    Console.ResetColor();
}

//MESES
Console.WriteLine($"Em qual mês você nasceu?: ");
int meses = int.Parse(Console.ReadLine());

if (meses > 12)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valor inválido (O mês foi digitado incorretamente)");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Valor válido");
    Console.ResetColor();
}

//ANO
Console.WriteLine($"Qual o ano em que você nasceu: ");
int anos = int.Parse(Console.ReadLine());

if (anos <= 2013 && anos >2023)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valor inválido (O ano digitado esta incorreto)");
    Console.ResetColor();
}

else{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Valor válido");
    Console.ResetColor();
}









 