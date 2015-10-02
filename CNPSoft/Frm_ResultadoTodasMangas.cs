using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CNPSoft
{
    public partial class Frm_ResultadoTodasMangas : Form
    {
        private Clases.C_Fichero file;
        private Clases.C_Competencia competencia;
        
        /*private List<Clases.C_Piloto> pilotos;
        private List<Clases.C_Competidor> competidores;
        private List<Clases.C_Manga> mangas;*/

        public Frm_ResultadoTodasMangas()
        {            
            InitializeComponent();
           /* pilotos = new List<Clases.C_Piloto>();
            balizasporManga = new List<Clases.C_Baliza>();
            competidores = new List<Clases.C_Competidor>();
            mangas = new List<Clases.C_Manga>();*/
        }       

        private void Frm_ResultadoTodasMangas_Load(object sender, EventArgs e)
        {
            
        }

       /* private Clases.C_Baliza BuscarBaliza(int numero)// completar este metodo de buscar baliza
        {
            Clases.C_Baliza baliza;
            return baliza;
        }*/
    }
}
