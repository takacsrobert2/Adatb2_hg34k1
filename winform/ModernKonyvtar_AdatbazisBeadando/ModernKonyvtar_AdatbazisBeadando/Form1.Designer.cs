namespace ModernKonyvtar_AdatbazisBeadando
{
    partial class Form1
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
            this.dgv_Konyvek = new System.Windows.Forms.DataGridView();
            this.tb_Cim = new System.Windows.Forms.TextBox();
            this.tb_Szerzo = new System.Windows.Forms.TextBox();
            this.tb_Kiado = new System.Windows.Forms.TextBox();
            this.tb_Isbn_azonosito = new System.Windows.Forms.TextBox();
            this.tb_Nyelv = new System.Windows.Forms.TextBox();
            this.cbb_Kategoria = new System.Windows.Forms.ComboBox();
            this.dtp_Kiadas_eve = new System.Windows.Forms.DateTimePicker();
            this.delete_button = new System.Windows.Forms.Button();
            this.insert_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Konyvek)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Konyvek
            // 
            this.dgv_Konyvek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Konyvek.Location = new System.Drawing.Point(0, 150);
            this.dgv_Konyvek.Name = "dgv_Konyvek";
            this.dgv_Konyvek.RowHeadersWidth = 51;
            this.dgv_Konyvek.RowTemplate.Height = 24;
            this.dgv_Konyvek.Size = new System.Drawing.Size(788, 298);
            this.dgv_Konyvek.TabIndex = 0;
            // 
            // tb_Cim
            // 
            this.tb_Cim.Location = new System.Drawing.Point(8, 8);
            this.tb_Cim.Name = "tb_Cim";
            this.tb_Cim.Size = new System.Drawing.Size(100, 22);
            this.tb_Cim.TabIndex = 1;
            // 
            // tb_Szerzo
            // 
            this.tb_Szerzo.Location = new System.Drawing.Point(114, 8);
            this.tb_Szerzo.Name = "tb_Szerzo";
            this.tb_Szerzo.Size = new System.Drawing.Size(100, 22);
            this.tb_Szerzo.TabIndex = 2;
            // 
            // tb_Kiado
            // 
            this.tb_Kiado.Location = new System.Drawing.Point(220, 8);
            this.tb_Kiado.Name = "tb_Kiado";
            this.tb_Kiado.Size = new System.Drawing.Size(100, 22);
            this.tb_Kiado.TabIndex = 3;
            // 
            // tb_Isbn_azonosito
            // 
            this.tb_Isbn_azonosito.Location = new System.Drawing.Point(532, 8);
            this.tb_Isbn_azonosito.Name = "tb_Isbn_azonosito";
            this.tb_Isbn_azonosito.Size = new System.Drawing.Size(100, 22);
            this.tb_Isbn_azonosito.TabIndex = 5;
            // 
            // tb_Nyelv
            // 
            this.tb_Nyelv.Location = new System.Drawing.Point(638, 8);
            this.tb_Nyelv.Name = "tb_Nyelv";
            this.tb_Nyelv.Size = new System.Drawing.Size(100, 22);
            this.tb_Nyelv.TabIndex = 6;
            // 
            // cbb_Kategoria
            // 
            this.cbb_Kategoria.FormattingEnabled = true;
            this.cbb_Kategoria.Location = new System.Drawing.Point(12, 48);
            this.cbb_Kategoria.Name = "cbb_Kategoria";
            this.cbb_Kategoria.Size = new System.Drawing.Size(121, 24);
            this.cbb_Kategoria.TabIndex = 7;
            // 
            // dtp_Kiadas_eve
            // 
            this.dtp_Kiadas_eve.CustomFormat = "yyyy";
            this.dtp_Kiadas_eve.Location = new System.Drawing.Point(326, 8);
            this.dtp_Kiadas_eve.Name = "dtp_Kiadas_eve";
            this.dtp_Kiadas_eve.Size = new System.Drawing.Size(200, 22);
            this.dtp_Kiadas_eve.TabIndex = 8;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(652, 68);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(64, 58);
            this.delete_button.TabIndex = 9;
            this.delete_button.Text = "Törlés";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // insert_button
            // 
            this.insert_button.Location = new System.Drawing.Point(506, 70);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(126, 54);
            this.insert_button.TabIndex = 10;
            this.insert_button.Text = "Hozzáadás";
            this.insert_button.UseVisualStyleBackColor = true;
            this.insert_button.Click += new System.EventHandler(this.insert_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.insert_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.dtp_Kiadas_eve);
            this.Controls.Add(this.cbb_Kategoria);
            this.Controls.Add(this.tb_Nyelv);
            this.Controls.Add(this.tb_Isbn_azonosito);
            this.Controls.Add(this.tb_Kiado);
            this.Controls.Add(this.tb_Szerzo);
            this.Controls.Add(this.tb_Cim);
            this.Controls.Add(this.dgv_Konyvek);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Konyvek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Konyvek;
        private System.Windows.Forms.TextBox tb_Cim;
        private System.Windows.Forms.TextBox tb_Szerzo;
        private System.Windows.Forms.TextBox tb_Kiado;
        private System.Windows.Forms.TextBox tb_Isbn_azonosito;
        private System.Windows.Forms.TextBox tb_Nyelv;
        private System.Windows.Forms.ComboBox cbb_Kategoria;
        private System.Windows.Forms.DateTimePicker dtp_Kiadas_eve;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button insert_button;
    }
}

