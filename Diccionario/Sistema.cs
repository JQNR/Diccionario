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
            string workingDirectory = Environment.CurrentDirectory;
            string path = Directory.GetParent(workingDirectory).Parent.Parent.FullName+"/diccionario_espanol.txt";
           
            using (StreamReader file = new StreamReader(path))
            {
                int counter = 0;
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                  string[] parts = ln.Split('#');
                    palabras.Add(new Palabra(parts[0],parts[1]));
                }
                file.Close();
            }
        }
    }
}
