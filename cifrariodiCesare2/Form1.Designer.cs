namespace cifrariodiCesare2
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_cripta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.lbl_n3 = new System.Windows.Forms.Label();
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.lbl_ris = new System.Windows.Forms.Label();
            this.txt_n4 = new System.Windows.Forms.TextBox();
            this.lbl_n5 = new System.Windows.Forms.Label();
            this.txt_n3 = new System.Windows.Forms.TextBox();
            this.lbl_n4 = new System.Windows.Forms.Label();
            this.btn_decripta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cripta
            // 
            this.btn_cripta.Location = new System.Drawing.Point(78, 171);
            this.btn_cripta.Name = "btn_cripta";
            this.btn_cripta.Size = new System.Drawing.Size(75, 23);
            this.btn_cripta.TabIndex = 0;
            this.btn_cripta.Text = "CRIPTA";
            this.btn_cripta.UseVisualStyleBackColor = true;
            this.btn_cripta.Click += new System.EventHandler(this.btn_cripta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CIFRARIO DI CESARE";
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Location = new System.Drawing.Point(75, 45);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(89, 13);
            this.lbl_n2.TabIndex = 2;
            this.lbl_n2.Text = "inserisci la stringa";
            // 
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(78, 62);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(100, 20);
            this.txt_n1.TabIndex = 3;
            // 
            // txt_n2
            // 
            this.txt_n2.Location = new System.Drawing.Point(78, 117);
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(100, 20);
            this.txt_n2.TabIndex = 5;
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.Location = new System.Drawing.Point(75, 100);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(90, 13);
            this.lbl_n3.TabIndex = 4;
            this.lbl_n3.Text = "inserisci la chiave";
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Location = new System.Drawing.Point(78, 220);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(68, 13);
            this.lbl_n1.TabIndex = 6;
            this.lbl_n1.Text = "RISULTATO";
            // 
            // lbl_ris
            // 
            this.lbl_ris.AutoSize = true;
            this.lbl_ris.Location = new System.Drawing.Point(392, 220);
            this.lbl_ris.Name = "lbl_ris";
            this.lbl_ris.Size = new System.Drawing.Size(68, 13);
            this.lbl_ris.TabIndex = 12;
            this.lbl_ris.Text = "RISULTATO";
            // 
            // txt_n4
            // 
            this.txt_n4.Location = new System.Drawing.Point(392, 117);
            this.txt_n4.Name = "txt_n4";
            this.txt_n4.Size = new System.Drawing.Size(100, 20);
            this.txt_n4.TabIndex = 11;
            // 
            // lbl_n5
            // 
            this.lbl_n5.AutoSize = true;
            this.lbl_n5.Location = new System.Drawing.Point(389, 100);
            this.lbl_n5.Name = "lbl_n5";
            this.lbl_n5.Size = new System.Drawing.Size(90, 13);
            this.lbl_n5.TabIndex = 10;
            this.lbl_n5.Text = "inserisci la chiave";
            // 
            // txt_n3
            // 
            this.txt_n3.Location = new System.Drawing.Point(392, 62);
            this.txt_n3.Name = "txt_n3";
            this.txt_n3.Size = new System.Drawing.Size(100, 20);
            this.txt_n3.TabIndex = 9;
            // 
            // lbl_n4
            // 
            this.lbl_n4.AutoSize = true;
            this.lbl_n4.Location = new System.Drawing.Point(389, 45);
            this.lbl_n4.Name = "lbl_n4";
            this.lbl_n4.Size = new System.Drawing.Size(90, 13);
            this.lbl_n4.TabIndex = 8;
            this.lbl_n4.Text = "inserisci la chiave";
            // 
            // btn_decripta
            // 
            this.btn_decripta.Location = new System.Drawing.Point(392, 171);
            this.btn_decripta.Name = "btn_decripta";
            this.btn_decripta.Size = new System.Drawing.Size(75, 23);
            this.btn_decripta.TabIndex = 7;
            this.btn_decripta.Text = "DECRIPTA";
            this.btn_decripta.UseVisualStyleBackColor = true;
            this.btn_decripta.Click += new System.EventHandler(this.btn_decripta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_ris);
            this.Controls.Add(this.txt_n4);
            this.Controls.Add(this.lbl_n5);
            this.Controls.Add(this.txt_n3);
            this.Controls.Add(this.lbl_n4);
            this.Controls.Add(this.btn_decripta);
            this.Controls.Add(this.lbl_n1);
            this.Controls.Add(this.txt_n2);
            this.Controls.Add(this.lbl_n3);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cripta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cripta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.TextBox txt_n2;
        private System.Windows.Forms.Label lbl_n3;
        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.Label lbl_ris;
        private System.Windows.Forms.TextBox txt_n4;
        private System.Windows.Forms.Label lbl_n5;
        private System.Windows.Forms.TextBox txt_n3;
        private System.Windows.Forms.Label lbl_n4;
        private System.Windows.Forms.Button btn_decripta;
    }
}

