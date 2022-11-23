using ParcialDeNatalyVillafanez.Entidades1;
using ParcialDeNatalyVillafanez.WindowsForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialDeNatalyVillfanez.Datos
{
    public static class ManejadorDeArchivoSecuencial
    {
        private static string archivo = "Elipses.txt";
        public static void GuardarEnArchivoSecuencia(List<Elipse> lista)
        {
            using (var escritor = new StreamWriter(archivo))
            {
                foreach (var elipse in lista)
                {
                    string linea = ConstruirLinea(elipse);
                    escritor.WriteLine(linea);
                }
            }
        }
        public static List<Elipse> LeerArchivoSecuencial()
        {
            List<Elipse> lista = new List<Elipse>();
            if (File.Exists(archivo)
            {
                using (var lector = new StreamReader(archivo))
                {
                    while (!lector.EndOfStream)
                    {
                        string linea = lector.ReadLine();
                        Elipse elipse = ConstruirElipse(linea);
                        lista.Add(elipse);
                    }
                }
            }
           
        }

        private static Elipse ConstruirElipse(string linea)
        {
            var campos = linea.Split('|');
            Elipse elipse = new Elipse()
            {
                SemiejeMayor = double.Parse(campos[0]),
                SemiejeMenor = double.Parse(campos[1]),
                TipoDeTrazo = (TipoTrazo)int.Parse(campos[2])
            };
            return elipse;
        }

        private static string ConstruirLinea(Elipse elipse)
        {
            string linea = $"{elipse.SemiejeMayor} | {elipse.SemiejeMenor} | {elipse.TipoDeTrazo.GetHashCode()}";
            return linea;
        }
    }
}
