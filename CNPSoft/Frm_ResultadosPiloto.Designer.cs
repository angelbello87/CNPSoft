namespace CNPSoft
{
    partial class Frm_ResultadosPiloto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ResultadosPiloto));
            this.listbox_baliza = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_dorsal = new System.Windows.Forms.ComboBox();
            this.cbox_piloto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_terminar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txt_horadeDespegue = new System.Windows.Forms.NumericUpDown();
            this.txt_minutodeDespegue = new System.Windows.Forms.NumericUpDown();
            this.txt_horadeAterrizaje = new System.Windows.Forms.NumericUpDown();
            this.txt_minutodeAterrizaje = new System.Windows.Forms.NumericUpDown();
            this.lview_pilotoscalificados = new System.Windows.Forms.ListView();
            this.Dorsal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_recalificar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_horadeDespegue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_minutodeDespegue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_horadeAterrizaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_minutodeAterrizaje)).BeginInit();
            this.SuspendLayout();
            // 
            // listbox_baliza
            // 
            this.listbox_baliza.CheckOnClick = true;
            this.listbox_baliza.ColumnWidth = 1;
            this.listbox_baliza.FormattingEnabled = true;
            this.listbox_baliza.Location = new System.Drawing.Point(28, 172);
            this.listbox_baliza.Name = "listbox_baliza";
            this.listbox_baliza.Size = new System.Drawing.Size(268, 199);
            this.listbox_baliza.TabIndex = 0;
            this.listbox_baliza.ThreeDCheckBoxes = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Balizas marcadas por el Piloto";
            // 
            // cbox_dorsal
            // 
            this.cbox_dorsal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_dorsal.FormattingEnabled = true;
            this.cbox_dorsal.Location = new System.Drawing.Point(28, 40);
            this.cbox_dorsal.Name = "cbox_dorsal";
            this.cbox_dorsal.Size = new System.Drawing.Size(38, 21);
            this.cbox_dorsal.TabIndex = 2;
            this.cbox_dorsal.SelectionChangeCommitted += new System.EventHandler(this.cbox_dorsal_SelectionChangeCommitted);
            // 
            // cbox_piloto
            // 
            this.cbox_piloto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_piloto.FormattingEnabled = true;
            this.cbox_piloto.Location = new System.Drawing.Point(72, 40);
            this.cbox_piloto.Name = "cbox_piloto";
            this.cbox_piloto.Size = new System.Drawing.Size(224, 21);
            this.cbox_piloto.TabIndex = 3;
            this.cbox_piloto.SelectedIndexChanged += new System.EventHandler(this.cbox_piloto_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dorsal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre del Piloto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hora de Despegue (Militar)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hora de Aterrizaje (Militar)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(229, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = ":";
            // 
            // btn_terminar
            // 
            this.btn_terminar.Location = new System.Drawing.Point(555, 381);
            this.btn_terminar.Name = "btn_terminar";
            this.btn_terminar.Size = new System.Drawing.Size(75, 23);
            this.btn_terminar.TabIndex = 14;
            this.btn_terminar.Text = "Terminar";
            this.btn_terminar.UseVisualStyleBackColor = true;
            this.btn_terminar.Click += new System.EventHandler(this.btn_terminar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(221, 381);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 15;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txt_horadeDespegue
            // 
            this.txt_horadeDespegue.Location = new System.Drawing.Point(31, 101);
            this.txt_horadeDespegue.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txt_horadeDespegue.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.txt_horadeDespegue.Name = "txt_horadeDespegue";
            this.txt_horadeDespegue.Size = new System.Drawing.Size(45, 20);
            this.txt_horadeDespegue.TabIndex = 16;
            this.txt_horadeDespegue.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.txt_horadeDespegue.ValueChanged += new System.EventHandler(this.txt_horadeDespegue_ValueChanged);
            // 
            // txt_minutodeDespegue
            // 
            this.txt_minutodeDespegue.Location = new System.Drawing.Point(101, 100);
            this.txt_minutodeDespegue.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txt_minutodeDespegue.Name = "txt_minutodeDespegue";
            this.txt_minutodeDespegue.Size = new System.Drawing.Size(45, 20);
            this.txt_minutodeDespegue.TabIndex = 17;
            this.txt_minutodeDespegue.ValueChanged += new System.EventHandler(this.txt_minutodeDespegue_ValueChanged);
            // 
            // txt_horadeAterrizaje
            // 
            this.txt_horadeAterrizaje.Location = new System.Drawing.Point(178, 100);
            this.txt_horadeAterrizaje.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txt_horadeAterrizaje.Name = "txt_horadeAterrizaje";
            this.txt_horadeAterrizaje.Size = new System.Drawing.Size(45, 20);
            this.txt_horadeAterrizaje.TabIndex = 18;
            this.txt_horadeAterrizaje.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});            
            // 
            // txt_minutodeAterrizaje
            // 
            this.txt_minutodeAterrizaje.Location = new System.Drawing.Point(249, 99);
            this.txt_minutodeAterrizaje.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txt_minutodeAterrizaje.Name = "txt_minutodeAterrizaje";
            this.txt_minutodeAterrizaje.Size = new System.Drawing.Size(45, 20);
            this.txt_minutodeAterrizaje.TabIndex = 19;
            // 
            // lview_pilotoscalificados
            // 
            this.lview_pilotoscalificados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Dorsal,
            this.Nombre,
            this.columnHeader1});
            this.lview_pilotoscalificados.FullRowSelect = true;
            this.lview_pilotoscalificados.GridLines = true;
            this.lview_pilotoscalificados.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lview_pilotoscalificados.HideSelection = false;
            this.lview_pilotoscalificados.Location = new System.Drawing.Point(327, 40);
            this.lview_pilotoscalificados.Name = "lview_pilotoscalificados";
            this.lview_pilotoscalificados.Size = new System.Drawing.Size(303, 331);
            this.lview_pilotoscalificados.TabIndex = 20;
            this.lview_pilotoscalificados.UseCompatibleStateImageBehavior = false;
            this.lview_pilotoscalificados.View = System.Windows.Forms.View.Details;
            // 
            // Dorsal
            // 
            this.Dorsal.Text = "Dorsal";
            this.Dorsal.Width = 48;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 144;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Balizas Marcadas";
            this.columnHeader1.Width = 107;
            // 
            // btn_recalificar
            // 
            this.btn_recalificar.Location = new System.Drawing.Point(327, 380);
            this.btn_recalificar.Name = "btn_recalificar";
            this.btn_recalificar.Size = new System.Drawing.Size(75, 23);
            this.btn_recalificar.TabIndex = 21;
            this.btn_recalificar.Text = "Recalificar";
            this.btn_recalificar.UseVisualStyleBackColor = true;
            this.btn_recalificar.Click += new System.EventHandler(this.btn_recalificar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "hora";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "minuto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(177, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "hora";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(246, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "minuto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(429, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Pilotos calificados";
            // 
            // Frm_ResultadosPiloto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 415);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_recalificar);
            this.Controls.Add(this.lview_pilotoscalificados);
            this.Controls.Add(this.txt_minutodeAterrizaje);
            this.Controls.Add(this.txt_horadeAterrizaje);
            this.Controls.Add(this.txt_minutodeDespegue);
            this.Controls.Add(this.txt_horadeDespegue);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_terminar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbox_piloto);
            this.Controls.Add(this.cbox_dorsal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listbox_baliza);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(341, 409);
            this.Name = "Frm_ResultadosPiloto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados del Piloto";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_ResultadosPiloto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_horadeDespegue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_minutodeDespegue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_horadeAterrizaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_minutodeAterrizaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox listbox_baliza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_dorsal;
        private System.Windows.Forms.ComboBox cbox_piloto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_terminar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.NumericUpDown txt_horadeDespegue;
        private System.Windows.Forms.NumericUpDown txt_minutodeDespegue;
        private System.Windows.Forms.NumericUpDown txt_horadeAterrizaje;
        private System.Windows.Forms.NumericUpDown txt_minutodeAterrizaje;
        private System.Windows.Forms.ListView lview_pilotoscalificados;
        private System.Windows.Forms.ColumnHeader Dorsal;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btn_recalificar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}