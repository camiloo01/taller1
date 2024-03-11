using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la cantidad de numeros primos que desea generar: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        int contador = 0;
        int numeroActual = 2;

        Console.WriteLine($"Los primeros {cantidad} numeros primos son:");

        while (contador < cantidad)
        {
            bool esPrimo = true;

            for (int i = 2; i <= Math.Sqrt(numeroActual); i++)
            {
                if (numeroActual % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }

            if (esPrimo)
            {
                Console.Write(numeroActual + " ");
                contador++;
            }

            numeroActual++;
        }
    }
}
