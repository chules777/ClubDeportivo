using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoTP1
{
    class ClubDeportivo
    {
        private List<Socio> socios;
        private List<string> actividades;


        public ClubDeportivo()
        {
            socios = new List<Socio>();
            actividades = new List<string>();
        }

        private Socio buscarSocio(int nroSocio)
        {
            Socio socioBuscado = null;
            int i = 0;

            while (i < socios.Count && !socios[i].GetNroSocio().Equals(nroSocio))
            {
                i++;
            }
            if (i != socios.Count)
            {
                socioBuscado = socios[i];
            }

            return socioBuscado;

        }

        public bool altaSocio(string nombre, int nroSocio)
        {
            bool resultado = false;
            Socio socio;
            socio = buscarSocio(nroSocio);

            if (socio == null)
            {
                socio = new Socio(nombre, nroSocio);
                socios.Add(socio);
                resultado = true;
                Console.WriteLine("El socio fue cargado exitosamete");
            }
            else
            {
                Console.WriteLine("El socio ya existe.");
            }


            return resultado;

        }

        public bool agregarActividad(string actividad)
        {
            bool resultado = false;
            if (this.actividades.IndexOf(actividad) == -1)
            {
                this.actividades.Add(actividad);
                resultado = true;
            }
            return resultado;
        }

        public string inscribirActividad(string actividad, int nroSocio)
        {
            Socio socio = buscarSocio(nroSocio);
            if (socio == null)
            {
                return "SOCIO INEXISTENTE";
            }
            if (this.actividades.IndexOf(actividad) == -1)
            {
                return "ACTIVIDAD INEXISTENTE";
            }
            if (socio.agregarActividad(actividad))
            {
                return "INSCRIPICION EXITOSA";
            }
            else
            {
                return "TOPE DE ACTIVIDADES ALCANZADO";
            }
        }

        public void listarSocios()
        {
            foreach (var socio in socios)
            {
                Console.WriteLine(socio);
            }
        }

    }
}
