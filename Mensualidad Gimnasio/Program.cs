using Mensualidad_Gimnasio.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensualidad_Gimnasio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login.start();
            

            bool reiniciar = false;
            do
            {
                Mensualidad.calcular();
                Console.WriteLine();
                Console.WriteLine("Ingrese R + Enter para reiniciar");
                reiniciar =  String.Equals(Console.ReadLine(), "r", StringComparison.OrdinalIgnoreCase);
                if (reiniciar)
                {
                    Console.Clear();
                }
            }
            while (reiniciar);
        }
    }
}
