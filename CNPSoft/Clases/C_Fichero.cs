using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace CNPSoft.Clases
{
    public class C_Fichero
    {        
        private StreamWriter fileW;
        private StreamReader fileR;
        private string archivo;

        public C_Fichero(string archivo)
        {
            this.archivo = archivo;            
        }
        public void Escribir(string texto)
        {            
            fileW.WriteLine(texto);
        }
        public string Leer()
        {            
            
            return fileR.ReadToEnd();
        }
        public string LeerLinea()
        {
            return fileR.ReadLine();
        }
        public void AbrirW()
        {
            fileW = new StreamWriter(archivo, true);
        }
        public void AbrirR()
        {
            fileR = new StreamReader(archivo);
        }
        public void CerrarW()
        {
            fileW.Close();
        }
        public void CerrarR()
        {
            fileR.Close();
        }
    }
}
