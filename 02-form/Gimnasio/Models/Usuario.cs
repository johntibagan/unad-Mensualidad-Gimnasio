using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Models
{
    public partial class Usuario
    {
        private string nombre;
        private string identificacion;
        private float sueldo;
        private int estrato;
        private char genero;

        private float mensualidad;
        private float descuento;
        private float totalMensualidad;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Identificacion { get => identificacion; set => identificacion = value; }
        public float Sueldo { get => sueldo; set => sueldo = value; }
        public int Estrato { get => estrato; set => estrato = value; }
        public char Genero { get => genero; set => genero = value; }
        public float Mensualidad { get => mensualidad; set => mensualidad = value; }
        public float Descuento { get => descuento; set => descuento = value; }
        public float TotalMensualidad { get => totalMensualidad; set => totalMensualidad = value; }


        public float calcularMensualidad()
        {
            if (Sueldo >= 1000000 && Sueldo <= 1999999)
            {
                return 40000;
            }
            else if (Sueldo >= 2000000 && Sueldo <= 5000000)
            {
                return 60000;
            }
            else if (Sueldo > 5000000)
            {
                return 80000;
            }

            Console.WriteLine("Error: El suedldo debe ser mayor o igual a 1.000.000");
            return 0;
        }

        public float calcularDescuento(float mensualidad)
        {
            int descuento = 0;
            switch (Estrato)
            {
                case 1:
                case 2:
                    descuento = 20;
                    break;
                case 3:
                case 4:
                    descuento = 15;
                    break;
                case 5:
                case 6:
                    descuento = 10;
                    break;

                default:
                    Console.WriteLine("Error: El estrato debe ser de 1 a 6");
                    break;
            }

            // descuento adicional del 5% para género femenino
            if (descuento > 0 && string.Equals(Genero.ToString(), "f", StringComparison.OrdinalIgnoreCase))
            {
                descuento += 5;
            }

            float porcentajeDescuento = (mensualidad / 100) * descuento;

            return porcentajeDescuento;
        }
    }
}
