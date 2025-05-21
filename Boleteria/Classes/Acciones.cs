using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boleteria.Classes
{
    class Acciones
    {
        public static List<Boletos> CargarBoletos()
        {
            var archivos = new Classes.archivo();
            var boletos = new List<Boletos>();
            var lineas = archivos.LeerArchivo();

            foreach (var linea in lineas)
            {
                string[] elementos = linea.Split("|");
                if (elementos.Length == 3 ) continue;

                var boleto = new Boletos();
                boleto.Nombre = elementos[0];
                boleto.Correo = elementos[1];
                boleto.Numero = elementos[2];
                boleto.Asiento = elementos[3];
                boletos.Add(boleto);
            }
            return boletos;
        }

        public static List<string> AgregarBoleto(Boletos boleto, int cantidad)
        {
            var archivo = new archivo();

            var nombre = boleto.Nombre;
            var correo = boleto.Correo;
            var numero = boleto.Numero;
            List<string> asientos = new List<string>();
            var asiento = "";

            if (cantidad >= 5 && cantidad > AsientosDisponibles())
            {
                return null;
            }
            if (Classes.Acciones.Excedido(correo, cantidad)) return null;

                for (int i = 0; i < cantidad; i++)
            {
                 asiento = OtorgarAsiento();
                 var linea = nombre + "|" + correo + "|" + numero + "|" + asiento;
                 archivo.AgregarLineaArchivo(linea);
                asientos.Add(asiento);
            }
            return asientos;
        }

        public static int AsientosDisponibles()
        {
            var archivo = new archivo();
            var asientosOcupados = archivo.LeerArchivo().Count();
            var asientosDisponibles = 60 - asientosOcupados;
            return asientosDisponibles; 
        }

        public static string OtorgarAsiento()
        {
            var archivo = new archivo();
            var asientoNuevo = archivo.LeerArchivo().Count();
            string[] filas = ["A","B","C","D","E","F"];
            string[] numeros = ["1", "2", "3", "4", "5", "6", "7", "8", "9", "10"];
            int fila = asientoNuevo / 10;
            int numAsiento = asientoNuevo % 10; 
            string asientoAsignando = filas[fila] + numeros[numAsiento];
            return asientoAsignando;    
        }
        public static bool Excedido(string correo, int cantidad)
        {
            List<Boletos> boletos = CargarBoletos();
            int contador = cantidad;
            foreach (var boleto in boletos)
            {
                if (boleto.Correo == correo)
                {
                    contador++;
                    if (contador > 5) return true;
                }
            }
            return false;
        }
    }
}
