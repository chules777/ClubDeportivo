using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoTP1
{
    class Socio
    {
        private string nombre;
        private int nroSocio;
        private List<string> actividades;


        public Socio(string nombre, int nroSocio)
        {
            this.nombre = nombre;
            this.nroSocio = nroSocio;
            this.actividades = new List<string>();
        }

        public int GetNroSocio()
        {
            return nroSocio;
        }

        public bool agregarActividad(string actividad)
        {
            bool resultado = false;
            if (this.actividades.Count < 3)
            {
                if (this.actividades.IndexOf(actividad) == -1)
                {
                    this.actividades.Add(actividad);
                    resultado = true;
                }
            }
            return resultado;
        }

        public override string ToString()
        {
            return "Nombre: " + nombre + " nroSocio: " + nroSocio;
        }

    }
}
