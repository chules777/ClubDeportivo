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


        public ClubDeportivo()
        {
            socios = new List<Socio>();
        }

        private Socio buscarSocio(int nroSocio)
        {
            Socio socioBuscado = null;
            int i = 0;

            while(i <  socios.Count && !socios[i].GetNroSocio().Equals(nroSocio))
            {
                i++;
            }
            if(i != socios.Count)
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

            if(socio == null)
            {
                socio = new Socio(nombre, nroSocio);
                socios.Add(socio);
                resultado = true;
            }

            return resultado;
            
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
