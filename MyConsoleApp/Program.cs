// See https://aka.ms/new-console-template for more information
Console.WriteLine("Introduzca un numero entero:");
int valor = Convert.ToInt32(Console.ReadLine());
double valor2 = valor / 2d;
double resto = valor2 % 2;
if (resto == 0)
{
    Console.WriteLine("Este valor no es el doble de un impar.");
}
else
{
    Console.WriteLine("Este Valor es el doble de un impar.");
}