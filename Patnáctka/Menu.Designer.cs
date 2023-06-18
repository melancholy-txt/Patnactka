namespace Patnáctka
{
    partial class Menu
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
            this.btnPatnactka = new System.Windows.Forms.Button();
            this.lbPatnactkaSkore = new System.Windows.Forms.Label();
            this.lbLisakSkore = new System.Windows.Forms.Label();
            this.btnLisak = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPatnactka
            // 
            this.btnPatnactka.Font = new System.Drawing.Font("Comic Sans MS", 20.29091F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnPatnactka.Location = new System.Drawing.Point(50, 20);
            this.btnPatnactka.Name = "btnPatnactka";
            this.btnPatnactka.Size = new System.Drawing.Size(300, 100);
            this.btnPatnactka.TabIndex = 0;
            this.btnPatnactka.Text = "Patnáctka";
            this.btnPatnactka.UseVisualStyleBackColor = true;
            this.btnPatnactka.Click += new System.EventHandler(this.btnPatnactka_Click);
            // 
            // lbPatnactkaSkore
            // 
            this.lbPatnactkaSkore.AutoSize = true;
            this.lbPatnactkaSkore.Location = new System.Drawing.Point(50, 140);
            this.lbPatnactkaSkore.Name = "lbPatnactkaSkore";
            this.lbPatnactkaSkore.Size = new System.Drawing.Size(171, 19);
            this.lbPatnactkaSkore.TabIndex = 2;
            this.lbPatnactkaSkore.Text = "Nejvyšší dosažené skóre: 0";
            // 
            // lbLisakSkore
            // 
            this.lbLisakSkore.AutoSize = true;
            this.lbLisakSkore.Location = new System.Drawing.Point(50, 303);
            this.lbLisakSkore.Name = "lbLisakSkore";
            this.lbLisakSkore.Size = new System.Drawing.Size(171, 19);
            this.lbLisakSkore.TabIndex = 3;
            this.lbLisakSkore.Text = "Nejvyšší dosažené skóre: 0";
            // 
            // btnLisak
            // 
            this.btnLisak.Font = new System.Drawing.Font("Comic Sans MS", 20.29091F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnLisak.Location = new System.Drawing.Point(50, 177);
            this.btnLisak.Name = "btnLisak";
            this.btnLisak.Size = new System.Drawing.Size(300, 100);
            this.btnLisak.TabIndex = 4;
            this.btnLisak.Text = "Lišák";
            this.btnLisak.UseVisualStyleBackColor = true;
            this.btnLisak.Click += new System.EventHandler(this.btnLisak_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Comic Sans MS", 20.29091F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnHelp.Location = new System.Drawing.Point(12, 363);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(150, 75);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "Pomoc";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Comic Sans MS", 20.29091F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnQuit.Location = new System.Drawing.Point(241, 363);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(150, 75);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Konec";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnLisak);
            this.Controls.Add(this.lbLisakSkore);
            this.Controls.Add(this.lbPatnactkaSkore);
            this.Controls.Add(this.btnPatnactka);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPatnactka;
        private Label lbPatnactkaSkore;
        private Label lbLisakSkore;
        private Button btnLisak;
        private Button btnHelp;
        private Button btnQuit;
    }
}