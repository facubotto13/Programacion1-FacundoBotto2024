// See https://aka.ms/new-console-template for more information

/*CALCULAR EL AREA DE UN CUADRADO*/

Console.Write("Ingrese uno de los lados: ");
double lado; /*uso double para permitir numeros decimales*/
if (!Double.TryParse(Console.ReadLine(), out lado)) /*uso double para convertir numeros enteros*/
{
    Console.WriteLine("Error, debe ingresar un número correcto");
}
else
{
    Console.WriteLine("El área del cuadrado es de: " + (lado * lado));
}