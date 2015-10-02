using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CNPSoft.Clases
{
    [Serializable]
    public class C_Baliza
    {
        private string nombre;        
        private int numero;        
        private int puntos;

        public string Nombre
        {
            get { return nombre; }            
        }
        public int Numero
        {
            get { return numero; }            
        }
        public int Puntos
        {
            get { return puntos; }
            set { puntos = value; }
        }
        public C_Baliza(string nombre, int numero, int puntos)
        {
            this.nombre = nombre;
            this.numero = numero;
            this.puntos = puntos;
        }
    }
}
