// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("-------------------------MINHA-PRIMEIRA-CALCULADORA-------------------------");
Console.WriteLine("-------------------------------Criador:-Enzo--------------------------------");

Console.WriteLine("Insert your first number");
float awns;
float num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert second number");
float num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write your the operation (+,-,*,/)");
string symble = Console.ReadLine();

switch (symble)
{
    case "+":
        awns = num1 + num2;
        Console.WriteLine("Awenser:" + awns);
        break;

    case "-":
        awns = num1 - num2;
        Console.WriteLine("Awenser:" + awns);
        break;

    case "*":
        awns = num1 * num2;
        Console.WriteLine("Awenser:" + awns);
        break;

    case "/":
        awns = num1 / num2;
        Console.WriteLine("Awenser:" + awns);
        break;

    default:
        Console.WriteLine("HEY, u put an undefined input");
        break;
        
}



