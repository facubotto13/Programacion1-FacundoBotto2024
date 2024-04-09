// See https://aka.ms/new-console-template for more information

/*CALCULAR LA SUMA DE 2 NUMEROS*/

Console.Write("Ingrese un número: ");
double numero1, numero2; /*pongo double para que permita numeros con decimales*/
if (!Double.TryParse(Console.ReadLine(), out numero1)) /*pongo Double.TryParse para que valide y convierta los numeros ingresados*/
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
    else
    {
        Console.WriteLine("La suma de los números es: " + (numero1 + numero2)); 
    }
}
