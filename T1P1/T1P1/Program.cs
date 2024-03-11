// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Ingrese el primer numero");
int n1 = Convert.ToInt32(
    Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero");
int n2 = Convert.ToInt32(
    Console.ReadLine());

Console.WriteLine("Ingrese el tercer numero");
int n3 = Convert.ToInt32(
    Console.ReadLine());

if (n1 > n2 & n1 > n3 & n2 > n3)
{
    Console.WriteLine("El numero " + n1 + " es el mayor de los 3 numeros y el menor es " + n3);
}
else
{
    if (n1 > n2 & n1 > n3 & n3 > n2)
    {
        Console.WriteLine("El numero " + n1 + " es el mayor de los 3 numeros y el menor es " + n2);
    }
    else
    {
        if (n2 > n1 & n2 > n3 & n1 > n3)
        {
            Console.WriteLine("El numero " + n2 + " es el mayor de los 3 numeros y el menor es " + n3);
        }
        else
        {
            if (n2 > n1 & n2 > n3 & n3 > n1)
            {
                Console.WriteLine("El numero " + n2 + " es el mayor de los 3 numeros y el menor es " + n1);
            }
            else
            {
                if (n3 > n1 & n3 > n2 & n1 > n2)
                {
                    Console.WriteLine("El numero " + n3 + " es el mayor de los 3 numeros y el menor es " + n2);
                }
                else
                {
                    if (n3 > n2 & n3 > n1 & n2 > n1)
                    {
                        Console.WriteLine("El numero " + n3 + " es el mayor de los 3 numeros y el menor es " + n1);
                    }
                    else
                    {
                        Console.WriteLine("Numeros incorrectos");
                    }
                }
            }
        }
    }
}

