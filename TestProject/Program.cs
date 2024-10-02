Console.WriteLine("Ingrese un valor:");
double valor1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese un otro valor:");
double valor2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Escoja una operacion (+ , - , * , /):");
char operador = Console.ReadKey().KeyChar;

double resultado;

switch (operador)
{
    case '+':
    resultado = valor1 + valor2;
    Console.WriteLine($"{valor1}+{valor2} = {resultado}");
    break;

        case '-':
    resultado = valor1 - valor2;
    Console.WriteLine($"{valor1}-{valor2} = {resultado}");
    break;

        case '*':
    resultado = valor1 * valor2;
    Console.WriteLine($"{valor1}*{valor2} = {resultado}");
    break;

        case '/':
    resultado = valor1 / valor2;
    Console.WriteLine($"{valor1}/{valor2} = {resultado}");
    break;

    default:
    Console.WriteLine("No es una operacion permitida");
    break;
}

