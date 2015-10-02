namespace CNPSoft
{
    partial class Frm_AnadirBalizas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AnadirBalizas));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_anadirbaliza = new System.Windows.Forms.Button();
            this.btn_terminar = new System.Windows.Forms.Button();
            this.listbox_balizas = new System.Windows.Forms.ListBox();
            this.txt_numero = new System.Windows.Forms.NumericUpDown();
            this.btn_eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txt_numero)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(64, 43);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(127, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // btn_anadirbaliza
            // 
            this.btn_anadirbaliza.Location = new System.Drawing.Point(16, 86);
            this.btn_anadirbaliza.Name = "btn_anadirbaliza";
            this.btn_anadirbaliza.Size = new System.Drawing.Size(75, 23);
            this.btn_anadirbaliza.TabIndex = 5;
            this.btn_anadirbaliza.Text = "Añadir";
            this.btn_anadirbaliza.UseVisualStyleBackColor = true;
            this.btn_anadirbaliza.Click += new System.EventHandler(this.btn_anadirbaliza_Click);
            // 
            // btn_terminar
            // 
            this.btn_terminar.Location = new System.Drawing.Point(116, 330);
            this.btn_terminar.Name = "btn_terminar";
            this.btn_terminar.Size = new System.Drawing.Size(75, 23);
            this.btn_terminar.TabIndex = 6;
            this.btn_terminar.Text = "Terminar";
            this.btn_terminar.UseVisualStyleBackColor = true;
            this.btn_terminar.Click += new System.EventHandler(this.btn_terminar_Click);
            // 
            // listbox_balizas
            // 
            this.listbox_balizas.FormattingEnabled = true;
            this.listbox_balizas.Location = new System.Drawing.Point(19, 125);
            this.listbox_balizas.Name = "listbox_balizas";
            this.listbox_balizas.Size = new System.Drawing.Size(172, 199);
            this.listbox_balizas.TabIndex = 8;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(64, 12);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(127, 20);
            this.txt_numero.TabIndex = 9;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(116, 86);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 10;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // Frm_AnadirBalizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 361);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.listbox_balizas);
            this.Controls.Add(this.btn_terminar);
            this.Controls.Add(this.btn_anadirbaliza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_AnadirBalizas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir Balizas";
            ((System.ComponentModel.ISupportInitialize)(this.txt_numero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_anadirbaliza;
        private System.Windows.Forms.Button btn_terminar;
        private System.Windows.Forms.ListBox listbox_balizas;
        private System.Windows.Forms.NumericUpDown txt_numero;
        private System.Windows.Forms.Button btn_eliminar;
    }
}