namespace CNPSoft
{
    partial class Frm_AnadirPiloto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AnadirPiloto));
            this.label1 = new System.Windows.Forms.Label();
            this.numUpD_Dorsal = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombreyapellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbox_club = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbox_provincia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pais = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_parapente = new System.Windows.Forms.TextBox();
            this.btn_anadirpiloto = new System.Windows.Forms.Button();
            this.btn_terminar = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.listbox_pilotos = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpD_Dorsal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dorsal";
            // 
            // numUpD_Dorsal
            // 
            this.numUpD_Dorsal.Location = new System.Drawing.Point(57, 5);
            this.numUpD_Dorsal.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpD_Dorsal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpD_Dorsal.Name = "numUpD_Dorsal";
            this.numUpD_Dorsal.Size = new System.Drawing.Size(120, 20);
            this.numUpD_Dorsal.TabIndex = 1;
            this.numUpD_Dorsal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre(s) y Apellidos";
            // 
            // txt_nombreyapellidos
            // 
            this.txt_nombreyapellidos.Location = new System.Drawing.Point(128, 31);
            this.txt_nombreyapellidos.Name = "txt_nombreyapellidos";
            this.txt_nombreyapellidos.Size = new System.Drawing.Size(220, 20);
            this.txt_nombreyapellidos.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Club";
            // 
            // cbox_club
            // 
            this.cbox_club.FormattingEnabled = true;
            this.cbox_club.Items.AddRange(new object[] {
            "Laminares",
            "Vuelo Santiago",
            "Alcones del Abra",
            "Team Guisa"});
            this.cbox_club.Location = new System.Drawing.Point(51, 57);
            this.cbox_club.Name = "cbox_club";
            this.cbox_club.Size = new System.Drawing.Size(297, 21);
            this.cbox_club.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Provincia";
            // 
            // cbox_provincia
            // 
            this.cbox_provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_provincia.FormattingEnabled = true;
            this.cbox_provincia.Items.AddRange(new object[] {
            "Pinar del Rio",
            "Artemisa",
            "Isla de la Juventud",
            "Mayabeque",
            "La habana",
            "Matanzas",
            "Villa Clara",
            "Cienfuegos",
            "Santi Spíritus",
            "Ciego de Avila",
            "Camaguey",
            "Las Tunas",
            "Granma",
            "Holguin",
            "Santiago de Cuba",
            "Guantánamo"});
            this.cbox_provincia.Location = new System.Drawing.Point(70, 83);
            this.cbox_provincia.Name = "cbox_provincia";
            this.cbox_provincia.Size = new System.Drawing.Size(278, 21);
            this.cbox_provincia.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "País";
            // 
            // txt_pais
            // 
            this.txt_pais.Location = new System.Drawing.Point(52, 110);
            this.txt_pais.Name = "txt_pais";
            this.txt_pais.Size = new System.Drawing.Size(125, 20);
            this.txt_pais.TabIndex = 9;
            this.txt_pais.Text = "Cuba";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Parapente";
            // 
            // txt_parapente
            // 
            this.txt_parapente.Location = new System.Drawing.Point(76, 136);
            this.txt_parapente.Name = "txt_parapente";
            this.txt_parapente.Size = new System.Drawing.Size(272, 20);
            this.txt_parapente.TabIndex = 11;
            // 
            // btn_anadirpiloto
            // 
            this.btn_anadirpiloto.Location = new System.Drawing.Point(16, 182);
            this.btn_anadirpiloto.Name = "btn_anadirpiloto";
            this.btn_anadirpiloto.Size = new System.Drawing.Size(75, 23);
            this.btn_anadirpiloto.TabIndex = 12;
            this.btn_anadirpiloto.Text = "Añadir Piloto";
            this.btn_anadirpiloto.UseVisualStyleBackColor = true;
            this.btn_anadirpiloto.Click += new System.EventHandler(this.btn_anadirpiloto_Click);
            // 
            // btn_terminar
            // 
            this.btn_terminar.Location = new System.Drawing.Point(273, 428);
            this.btn_terminar.Name = "btn_terminar";
            this.btn_terminar.Size = new System.Drawing.Size(75, 23);
            this.btn_terminar.TabIndex = 13;
            this.btn_terminar.Text = "Terminar";
            this.btn_terminar.UseVisualStyleBackColor = true;
            this.btn_terminar.Click += new System.EventHandler(this.btn_terminar_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(16, 161);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 13);
            this.lbl_error.TabIndex = 14;
            // 
            // listbox_pilotos
            // 
            this.listbox_pilotos.FormattingEnabled = true;
            this.listbox_pilotos.Location = new System.Drawing.Point(16, 230);
            this.listbox_pilotos.Name = "listbox_pilotos";
            this.listbox_pilotos.Size = new System.Drawing.Size(332, 186);
            this.listbox_pilotos.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Eliminar Piloto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_AnadirPiloto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 463);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listbox_pilotos);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_terminar);
            this.Controls.Add(this.btn_anadirpiloto);
            this.Controls.Add(this.txt_parapente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_pais);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbox_provincia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbox_club);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nombreyapellidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numUpD_Dorsal);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_AnadirPiloto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir Piloto";
            ((System.ComponentModel.ISupportInitialize)(this.numUpD_Dorsal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUpD_Dorsal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombreyapellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbox_club;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbox_provincia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_pais;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_parapente;
        private System.Windows.Forms.Button btn_anadirpiloto;
        private System.Windows.Forms.Button btn_terminar;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.ListBox listbox_pilotos;
        private System.Windows.Forms.Button button1;
    }
}