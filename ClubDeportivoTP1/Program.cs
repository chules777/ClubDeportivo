using System;

namespace ClubDeportivoTP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se instancia el club deportivo
            ClubDeportivo clubDeportivo = new ClubDeportivo();
            string resultado;


            //Se agregan actividades al club
            clubDeportivo.agregarActividad("natacion");
            clubDeportivo.agregarActividad("futbol");
            clubDeportivo.agregarActividad("basket");
            clubDeportivo.agregarActividad("tiro");
            clubDeportivo.agregarActividad("tenis");

            //Se da de alta un nuevo socio
             clubDeportivo.altaSocio("Luis", 1);

            //No permite cargar otro socio existente:
            clubDeportivo.altaSocio("Luis", 1);

            //Intentamos inscribir a un socio inexistente
            resultado = clubDeportivo.inscribirActividad("natacion", 2);
            Console.WriteLine(resultado);

            //Intentamos inscribir un socio a una actividad inexistente
            resultado = clubDeportivo.inscribirActividad("hockey", 1);
            Console.WriteLine(resultado);

            //Inscripciones exitosas
            resultado = clubDeportivo.inscribirActividad("tenis", 1);
            Console.WriteLine(resultado);
            resultado = clubDeportivo.inscribirActividad("natacion", 1);
            Console.WriteLine(resultado);
            resultado = clubDeportivo.inscribirActividad("futbol", 1);
            Console.WriteLine(resultado);

            //Intentamos inscribir al socio a mas de tres actividades
            resultado = clubDeportivo.inscribirActividad("tiro", 1);
            Console.WriteLine(resultado);
        }
    }
}
