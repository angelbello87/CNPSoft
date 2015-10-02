using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace CNPSoft.Clases
{
    public class C_Competencia
    {
        private Clases.C_Fichero file;
        //private string nombre;
        //private DateTime fecha;
        private List<C_Competidor> competidores;
        private List<C_Piloto> pilotos;
        List<C_Baliza> balizas;
        private List<C_Manga> mangas;
        //private Clases.C_Fichero file;

        public List<C_Manga> Mangas
        {
            get { return mangas; }
            set { mangas = value; }
        }
        public List<C_Competidor> Competidores
        {
            get { return competidores; }
            set { competidores = value; }
        }             
        public C_Competencia(List<C_Competidor> competidores, List<C_Manga> mangas)
        {
            this.competidores = competidores;
            this.mangas = mangas;
        }
        public C_Competencia()
        {
            competidores = new List<C_Competidor>();
            mangas = new List<C_Manga>();
        }

        public List<C_Piloto> CargarPilotos()
        {
            pilotos = new List<C_Piloto>();
            file = new Clases.C_Fichero("pilotos.txt");
            file.AbrirR();
            string bal = "";
            try
            {
                bal = file.Leer();
                file.CerrarR();
            }
            catch (Exception)
            {
                throw new Exception("Debe adicionar todas las balizas del campeonato primeramente");               
            }
            string[] aux = bal.Split('\r', '\n');
            string tmp1 = "";
            for (int i = 0; i < aux.Length; )
            {
                tmp1 = aux[i];
                if (tmp1 == "")
                {
                    i++;
                }
                else
                {
                    string[] tmp = tmp1.Split(',');
                    Clases.C_Piloto p = new Clases.C_Piloto(int.Parse(tmp[0]), tmp[1], tmp[2], tmp[3], tmp[4], tmp[5]);
                    pilotos.Add(p);
                    i++;
                }
            }
            return pilotos;
        }
        public List<Clases.C_Baliza> CargarBalizasCampeonato()
        {
            balizas = new List<C_Baliza>();
            file = new Clases.C_Fichero("balizas.txt");
            string bal = "";
            try
            {
                file.AbrirR();
                bal = file.Leer();
                file.CerrarR();
            }
            catch
            {
                throw new Exception("Debe adicionar todas las balizas del campeonato primeramente");
            }
            string[] aux = bal.Split('\r', '\n');
            string tmp1 = "";
            for (int i = 0; i < aux.Length; )
            {
                tmp1 = aux[i];
                if (tmp1 == "")
                {
                    i++;
                }
                else
                {
                    string[] tmp = tmp1.Split(',');
                    Clases.C_Baliza b = new Clases.C_Baliza(tmp[1], int.Parse(tmp[0]), int.Parse(tmp[2]));
                    balizas.Add(b);
                    i++;
                }
            }
            return balizas;
        }
        public List<C_Manga> CargarMangas()//falta cargar los competidores con sus resultados
        {
            file = new Clases.C_Fichero("mangas.txt");
            List<C_Baliza> balizasporManga = CargarBalizasporManga();
            string tmpResult = "";
            try
            {
                file.AbrirR();
            }
            catch (Exception)
            {
                throw new Exception("Debe haberse procesado al menos una manga");               
            }
            tmpResult = file.Leer();
            file.CerrarR();
            string[] aux = tmpResult.Split('\r', '\n');
            string tmp1 = "";
            for (int i = 0; i < aux.Length; )
            {
                tmp1 = aux[i];
                if (tmp1 == "")
                {
                    i++;
                }
                else
                {
                    string[] tmp = tmp1.Split('-');

                    string[] apertura = tmp[2].Split(':');
                    DateTime aperManga = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, int.Parse(apertura[0]), int.Parse(apertura[1]), int.Parse(apertura[2]), 0);
                    string[] cierVent = tmp[3].Split(':');
                    DateTime cierVentana = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, int.Parse(cierVent[0]), int.Parse(cierVent[1]), int.Parse(cierVent[2]), 0);
                    string[] cierManga = tmp[4].Split(':');
                    DateTime cierreManga = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, int.Parse(cierManga[0]), int.Parse(cierManga[1]), int.Parse(cierManga[2]), 0);
                    //las balizaas estan vacias y los competidores tambien

                    Clases.C_Manga m = new Clases.C_Manga(balizasporManga, competidores, aperManga, cierVentana, cierreManga);
                    //Seguir Obteniendo resultados de la manga
                    //Llamar en este metodo al metodo cargar pilotos para convertirlos en competidores...
                    mangas.Add(m);
                    i++;
                }
            }
            return mangas;
        }
        private List<C_Baliza> CargarBalizasporManga()//ver si funciona
        {
            file = new Clases.C_Fichero("mangas.txt");
            List<C_Baliza> balizasporManga = new List<C_Baliza>();
            string tmpResult = "";
            try
            {
                file.AbrirR();
            }
            catch (Exception)
            {
                throw new Exception("Debe haberse procesado al menos una manga");
            } 
            do
            {
                tmpResult = file.LeerLinea();  
            }
            while (tmpResult.Split('-')[0] != "B");
            
            file.CerrarR();
            string[] balizas = tmpResult.Split('-');            
            for (int i = 0; i < balizas.Length; i++)
			{
                balizasporManga.Add(BuscarBaliza(int.Parse(balizas[i])));
			}
            return balizasporManga;          
        }
        private C_Baliza BuscarBaliza(int numero)
        {
            C_Baliza tmpbaliza = null;
            for (int i = 0; i < balizas.Count; i++)
            {
                if (balizas[i].Numero == numero)
                {
                    tmpbaliza = balizas[i];
                    break;
                }
            }
            return tmpbaliza;
        }
        
    }
}
