using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace Diccionario
{
    public class Sistema
    {
        List<Palabra> palabras = new List<Palabra>();
        public Sistema()
        {
            Precarga();
        }

        private void Precarga()
        {
            //1 - Obtenemos el archivo txt que contiene todas las palabras con su significado.
            //1 - Obtenemos el archivo txt que contiene todas las palabras con su significado.
            //1 - Obtenemos el archivo txt que contiene todas las palabras con su significado.
            //1 - Obtenemos el archivo txt que contiene todas las palabras con su significado.
            //1 - Obtenemos el archivo txt que contiene todas las palabras con su significado.
            //1 - Obtenemos el archivo txt que contiene todas las palabras con su significado.
            string workingDirectory = Environment.CurrentDirectory;
            string path = Directory.GetParent(workingDirectory).Parent.Parent.FullName+"/diccionario_espanol.txt";
           
            
            using (StreamReader file = new StreamReader(path))
            {
               
                string ln;
                //2 - Recorremos linea a linea mientras existan.
                while ((ln = file.ReadLine()) != null)
                {
                    /*
                     Creamos un array pequeño donde en la posición
                    cero se guarda el nombre de la palabra, y en la
                    posición uno se guarda su significado.
                    Lo utilizamos para crear una instancia de palabra
                    y agregarla a la lista.
                     */
                    string[] parts = ln.Split('#');// https://docs.microsoft.com/en-us/dotnet/api/system.string.split?view=net-6.0
                    palabras.Add(new Palabra(parts[0],parts[1]));
                }
                file.Close();
            }
        }
    }
}
