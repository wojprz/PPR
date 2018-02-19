namespace WindowsFormsApp3
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
            this.aPESEL = new System.Windows.Forms.TextBox();
            this.Nazwisko = new System.Windows.Forms.TextBox();
            this.Imie = new System.Windows.Forms.TextBox();
            this.Miejsce = new System.Windows.Forms.TextBox();
            this.aKlient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aPESEL
            // 
            this.aPESEL.Location = new System.Drawing.Point(20, 104);
            this.aPESEL.MaxLength = 11;
            this.aPESEL.Name = "aPESEL";
            this.aPESEL.Size = new System.Drawing.Size(280, 20);
            this.aPESEL.TabIndex = 1;
            this.aPESEL.Text = "PESEL";
            this.aPESEL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Nazwisko
            // 
            this.Nazwisko.Location = new System.Drawing.Point(306, 104);
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.Size = new System.Drawing.Size(280, 20);
            this.Nazwisko.TabIndex = 2;
            this.Nazwisko.Text = "Nazwisko";
            this.Nazwisko.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nazwisko.TextChanged += new System.EventHandler(this.Nazwisko_TextChanged);
            // 
            // Imie
            // 
            this.Imie.Location = new System.Drawing.Point(592, 104);
            this.Imie.Name = "Imie";
            this.Imie.Size = new System.Drawing.Size(280, 20);
            this.Imie.TabIndex = 3;
            this.Imie.Text = "Imie";
            this.Imie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Miejsce
            // 
            this.Miejsce.Location = new System.Drawing.Point(878, 104);
            this.Miejsce.Name = "Miejsce";
            this.Miejsce.Size = new System.Drawing.Size(280, 20);
            this.Miejsce.TabIndex = 4;
            this.Miejsce.Text = "Miejsce zamieszkania";
            this.Miejsce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // aKlient
            // 
            this.aKlient.AutoSize = true;
            this.aKlient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aKlient.Location = new System.Drawing.Point(20, 21);
            this.aKlient.Name = "aKlient";
            this.aKlient.Size = new System.Drawing.Size(532, 63);
            this.aKlient.TabIndex = 9;
            this.aKlient.Text = "Dodawanie nowego klienta";
            this.aKlient.UseVisualStyleBackColor = true;
            this.aKlient.Click += new System.EventHandler(this.aKlient_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 1056);
            this.Controls.Add(this.aKlient);
            this.Controls.Add(this.Miejsce);
            this.Controls.Add(this.Imie);
            this.Controls.Add(this.Nazwisko);
            this.Controls.Add(this.aPESEL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox aPESEL;
        private System.Windows.Forms.TextBox Nazwisko;
        private System.Windows.Forms.TextBox Imie;
        private System.Windows.Forms.TextBox Miejsce;
        private System.Windows.Forms.Button aKlient;
    }
}

