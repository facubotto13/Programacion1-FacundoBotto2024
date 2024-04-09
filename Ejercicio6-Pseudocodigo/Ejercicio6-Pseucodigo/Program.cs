// See https://aka.ms/new-console-template for more information

/*DETERMINAR SI UN NUMERO ES POSITIVO*/

Console.Write("Ingrese un numero: ");
double numero; /*uso double para permitir numeros decimales*/
if (!Double.TryParse(Console.ReadLine(), out numero)) /*uso double para evaluar y convertir numeros enteros*/
{
    Console.WriteLine("Error, debe ingresar un número correcto");
}
else
if (numero >= 0)
{
    Console.WriteLine("El número es positivo");
}
else
{
    Console.WriteLine("El número NO es positivo");
}

