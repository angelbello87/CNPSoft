namespace CNPSoft
{
    partial class Frm_ProcesarResultadoManga
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ProcesarResultadoManga));
            this.lview_resultadoManga = new System.Windows.Forms.ListView();
            this.Dorsal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Balizas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Puntos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_procesar = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lview_resultadoManga
            // 
            this.lview_resultadoManga.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Dorsal,
            this.Nombre,
            this.Balizas,
            this.Puntos,
            this.columnHeader2,
            this.columnHeader1});
            this.lview_resultadoManga.GridLines = true;
            this.lview_resultadoManga.Location = new System.Drawing.Point(12, 12);
            this.lview_resultadoManga.Name = "lview_resultadoManga";
            this.lview_resultadoManga.Size = new System.Drawing.Size(590, 360);
            this.lview_resultadoManga.TabIndex = 1;
            this.lview_resultadoManga.UseCompatibleStateImageBehavior = false;
            this.lview_resultadoManga.View = System.Windows.Forms.View.Details;
            // 
            // Dorsal
            // 
            this.Dorsal.Text = "Dorsal";
            this.Dorsal.Width = 42;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 186;
            // 
            // Balizas
            // 
            this.Balizas.Text = "Balizas Marcadas";
            this.Balizas.Width = 153;
            // 
            // Puntos
            // 
            this.Puntos.Text = "Puntos";
            this.Puntos.Width = 51;
            // 
            // btn_procesar
            // 
            this.btn_procesar.Location = new System.Drawing.Point(527, 378);
            this.btn_procesar.Name = "btn_procesar";
            this.btn_procesar.Size = new System.Drawing.Size(75, 23);
            this.btn_procesar.TabIndex = 13;
            this.btn_procesar.Text = "Procesar";
            this.btn_procesar.UseVisualStyleBackColor = true;
            this.btn_procesar.Click += new System.EventHandler(this.btn_procesar_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Posición";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 53;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tiempo Realizado";
            this.columnHeader2.Width = 100;
            // 
            // Frm_ProcesarResultadoManga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 413);
            this.Controls.Add(this.btn_procesar);
            this.Controls.Add(this.lview_resultadoManga);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ProcesarResultadoManga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procesar Resultado Manga";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_ProcesarResultadoManga_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lview_resultadoManga;
        private System.Windows.Forms.Button btn_procesar;
        private System.Windows.Forms.ColumnHeader Dorsal;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Balizas;
        private System.Windows.Forms.ColumnHeader Puntos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}