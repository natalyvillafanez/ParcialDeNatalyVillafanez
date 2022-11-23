using ParcialDeNatalyVillafanez.WindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialDeNatalyVillfanez.Datos
{
    public class RepositorioDeElipses
    {
        private List<Elipse> elipsesLista;
        public RepositorioDeElipses()
        {
            elipsesLista = new List<Elipse>();
        }
        public void Agregar (Elipse elipse)
        {
            elipsesLista.Add(elipse);
        }
        public int CantidadElipses()
        {
            return elipsesLista.Count();
        }
        public List<Elipse> GetLista()
        {
            return elipsesLista;
        }
        public void Borrar(Elipse elipse)
        {
            elipsesLista.Remove(elipse);
        }

    }
}
