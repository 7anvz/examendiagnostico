using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Diagnostico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precio = 0.00;
            double totalpago = 0.00;
            double diferencia = 0.00;

            Console.WriteLine("TIPOS DE JUGOS: ");
            Console.WriteLine("- - - - - - - - -");
            Console.WriteLine("[1] Jugo de Naranja");
            Console.WriteLine("[2] Jugo de Fresas");
            Console.WriteLine("[3] Jugo de Lúcuma");
            Console.WriteLine("[4] Jugo de Papaya");
            Console.WriteLine("[5] Jugo Surtido");
            Console.WriteLine("[6] Jugo de Piña");
            Console.WriteLine("  ");
            Console.Write("Escribe el número del jugo que deseas >>> ");
            int jugo = int.Parse(Console.ReadLine());

            Console.WriteLine("  ");
            Console.WriteLine("TAMAÑOS DEL JUGO: ");
            Console.WriteLine("- - - - - - - - -");
            Console.WriteLine("[1] Large");
            Console.WriteLine("[2] Medium");
            Console.WriteLine("[3] Small");
            Console.WriteLine("  ");
            Console.Write("Escribe el número del tamaño que deseas >>> ");
            int tamaño = int.Parse(Console.ReadLine());

            Console.WriteLine("  ");
            Console.WriteLine("TIPO DE PAGO: ");
            Console.WriteLine("- - - - - - - - -");
            Console.WriteLine("[1] Efectivo");
            Console.WriteLine("[2] Tarjeta / Medio electrónico");
            Console.WriteLine("  ");
            Console.Write("Escribe el número de la forma de pago >>> ");
            int tipopago = int.Parse(Console.ReadLine());

            switch (jugo)
            {
                case 1:
                    if (tamaño == 1) precio = 15.50;
                    else if (tamaño == 2) precio = 12.00;
                    else if (tamaño == 3) precio = 10.50;
                    break;

                case 2:
                    if (tamaño == 1) precio = 17.00;
                    else if (tamaño == 2) precio = 13.70;
                    else if (tamaño == 3) precio = 11.50;
                    break;

                case 3:
                    if (tamaño == 1) precio = 14.20;
                    else if (tamaño == 2) precio = 11.50;
                    else if (tamaño == 3) precio = 9.70;
                    break;

                case 4:
                    if (tamaño == 1) precio = 10.00;
                    else if (tamaño == 2) precio = 8.50;
                    else if (tamaño == 3) precio = 6.50;
                    break;

                case 5:
                    if (tamaño == 1) precio = 20.00;
                    else if (tamaño == 2) precio = 17.00;
                    else if (tamaño == 3) precio = 15.00;
                    break;

                default:
                    if (tamaño == 1) precio = 11.50;
                    else if (tamaño == 2) precio = 9.40;
                    else if (tamaño == 3) precio = 7.20;
                    break;
            }

            if (tipopago == 1)
            {
                diferencia = precio * 0.08;       
                totalpago = precio - diferencia;
            }
            else if (tipopago == 2)
            {
                diferencia = precio * 0.07;      
                totalpago = precio + diferencia;
            }

            Console.WriteLine("  ");
            Console.WriteLine("↓ ↓ ↓ ↓ ↓ ↓ ↓ ↓ ↓ ↓ ↓ ↓ ↓ ↓ ↓");
            Console.WriteLine($"PRECIO INICIAL: S/{precio}");
            if (tipopago == 1) Console.WriteLine($"DESCUENTO (8%): - S/{diferencia:F2}");
            else Console.WriteLine($"RECARGO (7%): + S/{diferencia:F2}");
            Console.WriteLine($"PRECIO FINAL: S/{totalpago:F2}");
        }
    }
}
