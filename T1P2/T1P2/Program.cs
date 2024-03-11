Console.WriteLine("Ingrese hasta que numero desea imprimir");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= num; i++)
{
    if (i != 25) {
        Console.WriteLine(i);
    }
}