// See https://aka.ms/new-console-template for more information

/*CALCULAR EL PROMEDIO DE 3 NUMEROS*/

Console.Write("Ingrese un número: ");
double numero1, numero2, numero3; /*uso double para permitir numeros decimales*/
if (!Double.TryParse(Console.ReadLine(), out numero1)) /*uso double para validar y convertir numeros enteros*/
{
    Console.WriteLine("Error, debe ingresar un número correcto");
}
else
{
    Console.Write("Ingrese otro número: ");
    if (!Double.TryParse(Console.ReadLine(), out numero2)) /*uso double para validar y convertir numeros enteros*/
    {
        Console.WriteLine("Error, debe ingresar un número correcto");
    }

    else
    {
        Console.Write("Ingrese otro número: ");
        if (!Double.TryParse(Console.ReadLine(), out numero3)) /*uso double para validar y convertir numeros enteros*/
        {
            Console.WriteLine("Error, debe ingresar un número correcto");
        }
        else
        {
            Console.WriteLine("La suma de los números es: " + (numero1 + numero2 + numero3) + " y su promedio es: " + (numero1 + numero2 + numero3)/3);
        }
    }
}