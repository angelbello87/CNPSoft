using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CNPSoft.Clases
{
    [Serializable]
    public class C_Competidor : C_Piloto
    {
        private DateTime hora_despegue;       
        private DateTime hora_aterrizaje;        
        private TimeSpan tiempo_realizado;        
        private List<C_Baliza> balizas_marcadas;        
        private double total_de_puntos;           

        public DateTime Hora_despegue
        {
            get { return hora_despegue; }
        }
        public DateTime Hora_aterrizaje
        {
            get { return hora_aterrizaje; }
        }
        public TimeSpan Tiempo_realizado
        {
            get { return tiempo_realizado; }            
        }
        public List<C_Baliza> Balizas_marcadas
        {
            get { return balizas_marcadas; }            
        }       
        public double Total_de_puntos
        {
            get { return total_de_puntos; }
            set { total_de_puntos = value; }
        }     
        public C_Competidor(int dorsal, string nombre_apellido, string club, string provincia, string pais, string parapente, DateTime hora_despegue, DateTime hora_aterrizaje, List<C_Baliza> balizas_marcadas):base(dorsal,nombre_apellido,club,provincia,pais,parapente)
        {
            this.hora_despegue = hora_despegue;
            this.hora_aterrizaje = hora_aterrizaje;
            this.tiempo_realizado = hora_aterrizaje.Subtract(this.hora_despegue);  
            this.balizas_marcadas = balizas_marcadas;
            for (int i = 0; i < balizas_marcadas.Count; i++)
            {
                this.total_de_puntos += balizas_marcadas[i].Puntos;
            }
        }
        
    }
}
