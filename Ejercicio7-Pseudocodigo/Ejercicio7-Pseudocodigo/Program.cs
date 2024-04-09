// See https://aka.ms/new-console-template for more information

/*MOSTRAR EL MAYOR DE DOS NUMEROS*/

Console.Write("Ingrese un número: ");
double numero1, numero2; /*pongo double para permitir numeros decimales*/
if (!Double.TryParse(Console.ReadLine(), out numero1)) /*pongo double para que valide y convierta numeros enteros*/
{
    Console.WriteLine("Error, debe ingresar un número correcto");
}
else
{
    Console.Write("Ingrese otro número: ");
    if (!Double.TryParse(Console.ReadLine(), out numero2))
    {
        Console.WriteLine("Error, debe ingresar un número correcto");
    }

    else if (numero1 > numero2)
    {
        Console.WriteLine("El número mayor es: " + numero1);
    }
    else if (numero1 == numero2)
    {
        Console.WriteLine("Los números son iguales");
    }
    else
    {
        Console.WriteLine("El número mayor es: " + numero2);
    }
}

