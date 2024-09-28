using System;

namespace ClubDeportivoTP1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClubDeportivo clubDeportivo = new ClubDeportivo();

            int bandera = 1;

            string nombre;
            int nroSocio;

            while(bandera == 1)
            {
            Console.WriteLine("¿Deseas cargar un socio?");
            Console.WriteLine("Pulsa 1 para cargar socio, 0 para terminar el programa");
                bandera = int.Parse(Console.ReadLine());
                if(bandera == 1)
                {
                    Console.WriteLine("Escriba el nombre del socio:");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Escriba el nro de socio a ingresar:");
                    nroSocio = int.Parse(Console.ReadLine());
                    cargarSocio(nombre, nroSocio);
                }

            }

            

            void cargarSocio(string nombre, int nroSocio)
            {
                bool pude;

                pude = clubDeportivo.altaSocio(nombre, nroSocio);
                if (pude)
                {
                    Console.WriteLine("El socio " + nombre + " fue cargado exitosiamente " + " con el número de socio: " + nroSocio);
                }
                else
                {
                    Console.WriteLine("El socio ya existe.");
                }
            }

            clubDeportivo.listarSocios();


            Console.ReadKey();
        }
    }
}
