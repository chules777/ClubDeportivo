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


        public Socio(string nombre, int nroSocio)
        {
            this.nombre = nombre;
            this.nroSocio = nroSocio;
        }

        public int GetNroSocio()
        {
            return nroSocio;
        }


        public override string ToString()
        {
            return "Nombre: " + nombre + " nroSocio: " + nroSocio;
        }

    }
}
