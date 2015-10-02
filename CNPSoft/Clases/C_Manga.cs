using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CNPSoft.Clases
{
    [Serializable]
    public class C_Manga
    {
        private List<C_Baliza> balizas;        
        private List<C_Competidor> competidores;        
        private DateTime apertura_manga;        
        private DateTime cierre_ventana;        
        private DateTime cierre_manga;

        public List<C_Baliza> Balizas
        {
            get { return balizas; }
        }
        public List<C_Competidor> Competidores
        {
            get { return competidores; }
        }
        public DateTime Apertura_manga
        {
            get { return apertura_manga; }
            set { apertura_manga = value; }
        }
        public DateTime Cierre_ventana
        {
            get { return cierre_ventana; }
            set { cierre_manga = value; }
        }
        public DateTime Cierre_manga
        {
            get { return cierre_manga; }
            set { cierre_manga = value; }
        }


        public C_Manga(List<C_Baliza> balizas, List<C_Competidor> competidores, DateTime apertura_manga, DateTime cierre_ventana, DateTime cierre_manga)
        {
            this.balizas = balizas;
            this.competidores = competidores;
            this.apertura_manga = apertura_manga;
            this.cierre_ventana = cierre_ventana;
            this.cierre_manga = cierre_manga;
        }
    }
}
