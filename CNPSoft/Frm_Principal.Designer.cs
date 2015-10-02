namespace CNPSoft
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.competenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadosMangaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anadirPilotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirBalizasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verResultadosPorMangaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.competenciaToolStripMenuItem,
            this.administraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // competenciaToolStripMenuItem
            // 
            this.competenciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resultadosMangaToolStripMenuItem,
            this.verResultadosPorMangaToolStripMenuItem,
            this.resultadosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.competenciaToolStripMenuItem.Name = "competenciaToolStripMenuItem";
            this.competenciaToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.competenciaToolStripMenuItem.Text = "Competencia";
            // 
            // resultadosMangaToolStripMenuItem
            // 
            this.resultadosMangaToolStripMenuItem.Name = "resultadosMangaToolStripMenuItem";
            this.resultadosMangaToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.resultadosMangaToolStripMenuItem.Text = "Insertar Resultados Manga";
            this.resultadosMangaToolStripMenuItem.Click += new System.EventHandler(this.resultadosMangaToolStripMenuItem_Click);
            // 
            // resultadosToolStripMenuItem
            // 
            this.resultadosToolStripMenuItem.Name = "resultadosToolStripMenuItem";
            this.resultadosToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.resultadosToolStripMenuItem.Text = "Resultados Generales";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anadirPilotoToolStripMenuItem,
            this.añadirBalizasToolStripMenuItem});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // anadirPilotoToolStripMenuItem
            // 
            this.anadirPilotoToolStripMenuItem.Name = "anadirPilotoToolStripMenuItem";
            this.anadirPilotoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.anadirPilotoToolStripMenuItem.Text = "Añadir Pilotos";
            this.anadirPilotoToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // añadirBalizasToolStripMenuItem
            // 
            this.añadirBalizasToolStripMenuItem.Name = "añadirBalizasToolStripMenuItem";
            this.añadirBalizasToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.añadirBalizasToolStripMenuItem.Text = "Añadir Balizas";
            this.añadirBalizasToolStripMenuItem.Click += new System.EventHandler(this.añadirBalizasToolStripMenuItem_Click);
            // 
            // verResultadosPorMangaToolStripMenuItem
            // 
            this.verResultadosPorMangaToolStripMenuItem.Name = "verResultadosPorMangaToolStripMenuItem";
            this.verResultadosPorMangaToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.verResultadosPorMangaToolStripMenuItem.Text = "Ver Resultados por Manga";
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 340);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CNP Software";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem competenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anadirPilotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirBalizasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultadosMangaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verResultadosPorMangaToolStripMenuItem;
    }
}

