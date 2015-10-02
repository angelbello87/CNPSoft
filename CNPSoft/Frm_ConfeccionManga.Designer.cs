namespace CNPSoft
{
    partial class Frm_ConfeccionManga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ConfeccionManga));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listbox_balizas = new System.Windows.Forms.ListBox();
            this.listbox_balizasPuntos = new System.Windows.Forms.ListBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_puntos = new System.Windows.Forms.NumericUpDown();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_minutosCierredeManga = new System.Windows.Forms.NumericUpDown();
            this.txt_horaCierredeManga = new System.Windows.Forms.NumericUpDown();
            this.txt_minutosCierredeVentana = new System.Windows.Forms.NumericUpDown();
            this.txt_horaCierredeVentana = new System.Windows.Forms.NumericUpDown();
            this.txt_minutosAperturadeManga = new System.Windows.Forms.NumericUpDown();
            this.txt_horaAperturadeManga = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txt_puntos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_minutosCierredeManga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_horaCierredeManga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_minutosCierredeVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_horaCierredeVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_minutosAperturadeManga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_horaAperturadeManga)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balizas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Balizas - Puntos";
            // 
            // listbox_balizas
            // 
            this.listbox_balizas.FormattingEnabled = true;
            this.listbox_balizas.Location = new System.Drawing.Point(36, 107);
            this.listbox_balizas.Name = "listbox_balizas";
            this.listbox_balizas.Size = new System.Drawing.Size(176, 251);
            this.listbox_balizas.TabIndex = 2;
            // 
            // listbox_balizasPuntos
            // 
            this.listbox_balizasPuntos.FormattingEnabled = true;
            this.listbox_balizasPuntos.Location = new System.Drawing.Point(316, 107);
            this.listbox_balizasPuntos.Name = "listbox_balizasPuntos";
            this.listbox_balizasPuntos.Size = new System.Drawing.Size(176, 251);
            this.listbox_balizasPuntos.TabIndex = 3;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(247, 239);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(35, 23);
            this.btn_adicionar.TabIndex = 4;
            this.btn_adicionar.Text = ">>";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Location = new System.Drawing.Point(417, 368);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(75, 23);
            this.btn_siguiente.TabIndex = 5;
            this.btn_siguiente.Text = "Siguiente";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Puntos";
            // 
            // txt_puntos
            // 
            this.txt_puntos.Location = new System.Drawing.Point(229, 177);
            this.txt_puntos.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txt_puntos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_puntos.Name = "txt_puntos";
            this.txt_puntos.Size = new System.Drawing.Size(69, 20);
            this.txt_puntos.TabIndex = 7;
            this.txt_puntos.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(247, 276);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(35, 23);
            this.btn_eliminar.TabIndex = 8;
            this.btn_eliminar.Text = "<<";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(447, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "minuto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(380, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "hora";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(280, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "minuto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(213, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "hora";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(104, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "minuto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "hora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(371, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Cierre de la Manga (Militar)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(202, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Cierre de la Ventana (Militar)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Apertura de la Manga (Militar)";
            // 
            // txt_minutosCierredeManga
            // 
            this.txt_minutosCierredeManga.Location = new System.Drawing.Point(447, 28);
            this.txt_minutosCierredeManga.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txt_minutosCierredeManga.Name = "txt_minutosCierredeManga";
            this.txt_minutosCierredeManga.Size = new System.Drawing.Size(45, 20);
            this.txt_minutosCierredeManga.TabIndex = 26;
            // 
            // txt_horaCierredeManga
            // 
            this.txt_horaCierredeManga.Location = new System.Drawing.Point(380, 28);
            this.txt_horaCierredeManga.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txt_horaCierredeManga.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.txt_horaCierredeManga.Name = "txt_horaCierredeManga";
            this.txt_horaCierredeManga.Size = new System.Drawing.Size(45, 20);
            this.txt_horaCierredeManga.TabIndex = 25;
            this.txt_horaCierredeManga.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // txt_minutosCierredeVentana
            // 
            this.txt_minutosCierredeVentana.Location = new System.Drawing.Point(280, 28);
            this.txt_minutosCierredeVentana.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txt_minutosCierredeVentana.Name = "txt_minutosCierredeVentana";
            this.txt_minutosCierredeVentana.Size = new System.Drawing.Size(45, 20);
            this.txt_minutosCierredeVentana.TabIndex = 24;
            // 
            // txt_horaCierredeVentana
            // 
            this.txt_horaCierredeVentana.Location = new System.Drawing.Point(213, 28);
            this.txt_horaCierredeVentana.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txt_horaCierredeVentana.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.txt_horaCierredeVentana.Name = "txt_horaCierredeVentana";
            this.txt_horaCierredeVentana.Size = new System.Drawing.Size(45, 20);
            this.txt_horaCierredeVentana.TabIndex = 23;
            this.txt_horaCierredeVentana.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // txt_minutosAperturadeManga
            // 
            this.txt_minutosAperturadeManga.Location = new System.Drawing.Point(104, 28);
            this.txt_minutosAperturadeManga.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txt_minutosAperturadeManga.Name = "txt_minutosAperturadeManga";
            this.txt_minutosAperturadeManga.Size = new System.Drawing.Size(45, 20);
            this.txt_minutosAperturadeManga.TabIndex = 22;
            // 
            // txt_horaAperturadeManga
            // 
            this.txt_horaAperturadeManga.Location = new System.Drawing.Point(36, 28);
            this.txt_horaAperturadeManga.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txt_horaAperturadeManga.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.txt_horaAperturadeManga.Name = "txt_horaAperturadeManga";
            this.txt_horaAperturadeManga.Size = new System.Drawing.Size(45, 20);
            this.txt_horaAperturadeManga.TabIndex = 21;
            this.txt_horaAperturadeManga.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // Frm_ConfeccionManga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 403);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_minutosCierredeManga);
            this.Controls.Add(this.txt_horaCierredeManga);
            this.Controls.Add(this.txt_minutosCierredeVentana);
            this.Controls.Add(this.txt_horaCierredeVentana);
            this.Controls.Add(this.txt_minutosAperturadeManga);
            this.Controls.Add(this.txt_horaAperturadeManga);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.txt_puntos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.listbox_balizasPuntos);
            this.Controls.Add(this.listbox_balizas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(489, 364);
            this.Name = "Frm_ConfeccionManga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conformación de la Manga";
            this.Load += new System.EventHandler(this.Frm_ResultadoManga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_puntos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_minutosCierredeManga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_horaCierredeManga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_minutosCierredeVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_horaCierredeVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_minutosAperturadeManga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_horaAperturadeManga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listbox_balizas;
        private System.Windows.Forms.ListBox listbox_balizasPuntos;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txt_puntos;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown txt_minutosCierredeManga;
        private System.Windows.Forms.NumericUpDown txt_horaCierredeManga;
        private System.Windows.Forms.NumericUpDown txt_minutosCierredeVentana;
        private System.Windows.Forms.NumericUpDown txt_horaCierredeVentana;
        private System.Windows.Forms.NumericUpDown txt_minutosAperturadeManga;
        private System.Windows.Forms.NumericUpDown txt_horaAperturadeManga;
    }
}