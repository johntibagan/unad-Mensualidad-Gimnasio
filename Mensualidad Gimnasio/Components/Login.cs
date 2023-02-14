using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensualidad_Gimnasio
{
    internal class Login
    {
        public static void start()
        {
            Console.WriteLine("----------- Iniciar Sesión -----------");
            Console.WriteLine("Ingresar contraseña");
            bool errorLogin;
            do
            {
                String clave = Console.ReadLine();
                errorLogin = clave != "123";
                if (errorLogin)
                {
                    Console.WriteLine("Contraseña incorrecta");
                }

            } while (errorLogin);

            Console.WriteLine("----------- Beinvenido al sistema Gimnasio Robles  -----------");
        }
    }
}
