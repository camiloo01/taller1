using System;

class Empresa
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el total de empleados: ");
        int totalEmpleados = Convert.ToInt32(Console.ReadLine());

        double totRetenidosRenta = 0;
        double totRetenidosAFP = 0;
        double totRetenidosISSS = 0;
        double totSueldosNetos = 0;

        for (int i = 1; i <= totalEmpleados; i++)
        {
            Console.Write($"Ingrese el sueldo base del empleado {i}: $");
            double sueldoBase = Convert.ToDouble(Console.ReadLine());

            double descuentoRenta = sueldoBase * 0.10;
            double descuentoAFP = sueldoBase * 0.05;
            double descuentoISSS = sueldoBase * 0.04;

            double sueldoNeto = sueldoBase - (descuentoRenta + descuentoAFP + descuentoISSS);

            totRetenidosRenta += descuentoRenta;
            totRetenidosAFP += descuentoAFP;
            totRetenidosISSS += descuentoISSS;
            totSueldosNetos += sueldoNeto;
        }

        Console.WriteLine("\nReporte contable:");
        Console.WriteLine($"Total a pagar en concepto de sueldos netos: ${totSueldosNetos}");
        Console.WriteLine($"Totales retenidos en concepto de Renta: ${totRetenidosRenta}");
        Console.WriteLine($"Totales retenidos en concepto de AFP: ${totRetenidosAFP}");
        Console.WriteLine($"Totales retenidos en concepto de Seguro Social ISSS: ${totRetenidosISSS}");
    }
}


