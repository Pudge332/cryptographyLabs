namespace ProgramUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Объявления кнопок как приватных полей класса
        private System.Windows.Forms.Button btnRSA;
        private System.Windows.Forms.Button btnDiffieHellman;
        private System.Windows.Forms.Button btnHybridCrypto;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRSA = new System.Windows.Forms.Button();
            this.btnDiffieHellman = new System.Windows.Forms.Button();
            this.btnHybridCrypto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRSA
            // 
            this.btnRSA.Location = new System.Drawing.Point(300, 100);
            this.btnRSA.Name = "btnRSA";
            this.btnRSA.Size = new System.Drawing.Size(200, 50);
            this.btnRSA.TabIndex = 0;
            this.btnRSA.Text = "RSA Шифрование";
            this.btnRSA.UseVisualStyleBackColor = true;
            this.btnRSA.Click += new System.EventHandler(this.btnRSA_Click);
            // 
            // btnDiffieHellman
            // 
            this.btnDiffieHellman.Location = new System.Drawing.Point(300, 180);
            this.btnDiffieHellman.Name = "btnDiffieHellman";
            this.btnDiffieHellman.Size = new System.Drawing.Size(200, 50);
            this.btnDiffieHellman.TabIndex = 1;
            this.btnDiffieHellman.Text = "Diffie-Hellman";
            this.btnDiffieHellman.UseVisualStyleBackColor = true;
            this.btnDiffieHellman.Click += new System.EventHandler(this.btnDiffieHellman_Click);
            // 
            // btnHybridCrypto
            // 
            this.btnHybridCrypto.Location = new System.Drawing.Point(300, 260);
            this.btnHybridCrypto.Name = "btnHybridCrypto";
            this.btnHybridCrypto.Size = new System.Drawing.Size(200, 50);
            this.btnHybridCrypto.TabIndex = 2;
            this.btnHybridCrypto.Text = "Гибридная криптосистема";
            this.btnHybridCrypto.UseVisualStyleBackColor = true;
            this.btnHybridCrypto.Click += new System.EventHandler(this.btnHybridCrypto_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHybridCrypto);
            this.Controls.Add(this.btnDiffieHellman);
            this.Controls.Add(this.btnRSA);
            this.Name = "Form1";
            this.Text = "Криптографические методы";
            this.ResumeLayout(false);
        }

        #endregion
    }
}