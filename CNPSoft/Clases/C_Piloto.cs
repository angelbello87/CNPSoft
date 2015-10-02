using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CNPSoft.Clases
{
    [Serializable]
    public class C_Piloto
    {
        private int dorsal;        
        private string nombre_apellido;        
        private string club;        
        private string provincia;       
        private string pais;        
        private string parapente;

        public int Dorsal
        {
            get { return dorsal; }
        }
        public string Nombre_apellido
        {
            get { return nombre_apellido; }
        }
        public string Club
        {
            get { return club; }
        }
        public string Provincia
        {
            get { return provincia; }
        }
        public string Pais
        {
            get { return pais; }
        }
        public string Parapente
        {
            get { return parapente; }
            set { parapente = value; }
        }

        public C_Piloto(int dorsal, string nombre_apellido, string club, string provincia, string pais, string parapente)
        {
            this.dorsal = dorsal;            
            this.nombre_apellido = nombre_apellido;
            this.club = club;
            this.provincia = provincia;
            this.pais = pais;
            this.parapente = parapente;
        }

    }
}
