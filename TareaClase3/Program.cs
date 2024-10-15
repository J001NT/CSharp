

Console.WriteLine("Elija una opcion del Menú:");
Console.WriteLine("Opcion 1: Sumar 2 numeros");
Console.WriteLine("Opcion 2: Imprimir tabla de multiplicar de");
Console.WriteLine("Opcion 3: Lista de frutas");
Console.WriteLine("Opcion 4: Salir");

string entrada = Console.ReadLine();

if (int.TryParse(entrada, out int numero))
{
    if (numero >= 1 && numero <= 4)
    {

        switch (numero)

        {
            case 1:
                Console.WriteLine("Opcion 1: Sumar 2 numeros");
                break;
            case 2:
                Console.WriteLine("Opcion 2: Imprimir tabla de multiplicar de");
                break;
            case 3:
                Console.WriteLine("Opcion 3: Lista de frutas");
                break;
            case 4:
                Console.WriteLine("Opcion 4: Salir");
                break;
        }
    }
    else
    {
        Console.WriteLine("Ingrese una opcion válida");
    }
}
else
    {
        Console.WriteLine("Por favor, ingrese un numero entero.");
    }

