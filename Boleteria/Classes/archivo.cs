using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boleteria.Classes
{
    public class archivo
    {
        public string? NombreArhivo {  get; set; }

        public bool AgregarLineaArchivo(string linea)
        {
            NombreArhivo = "Boletos.txt";

            if (File.Exists(NombreArhivo))
            {
                var LineasExistentes = File.ReadAllLines(NombreArhivo);
                if (LineasExistentes.Contains(linea))
                {
                    return false;
                }
                using (StreamWriter sw = new StreamWriter(NombreArhivo, true))
                {
                    sw.WriteLine(linea);
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(NombreArhivo, false))
                {
                    sw.WriteLine(linea);
                }
            }
            return true;
        }

        public List<string> LeerArchivo()
        {
            NombreArhivo = "Boletos.txt";
            if (File.Exists(NombreArhivo))
            {
                return File.ReadAllLines(NombreArhivo).ToList();
            }
            else
            {
                File.Create(NombreArhivo).Dispose();
                return new List<string>();
            }
            
        }

       

    }
}
