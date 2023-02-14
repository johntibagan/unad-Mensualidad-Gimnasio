using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensualidad_Gimnasio.Components
{
    internal class Mensualidad
    {
        public static void calcular()
        {
            Usuario usuario = solicitarDatos();
            float valorMensual = usuario.calcularMensualidad();
            float valorDescuento = usuario.calcularDescuento(valorMensual);
            float total = valorMensual - valorDescuento;


            Console.WriteLine();
            Console.WriteLine(" ------- Totales -------");

            Console.WriteLine("Mensualidad: " + valorMensual);
            Console.WriteLine("Descuento: " + valorDescuento);
            Console.WriteLine("Total a pagar: " + total);
        }

        private static Usuario solicitarDatos()
        {
            Usuario usuario = new Usuario();

            Console.WriteLine("Ingresar número de identificación");
            usuario.Identificacion = Console.ReadLine();

            Console.WriteLine("Ingresar nombre completo");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresar sueldo");
            usuario.Sueldo = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar estrato");
            usuario.Estrato = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar genero");
            usuario.Genero = char.Parse(Console.ReadLine());

            usuario.verDatos();

            return usuario;
        }
    }
}