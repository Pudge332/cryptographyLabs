namespace ProgramUI
{
    partial class RSAForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKeyLength = new System.Windows.Forms.TextBox();
            this.btnGenerateKeys = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPublicKeyE = new System.Windows.Forms.TextBox();
            this.txtPublicKeyN = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrivateKeyD = new System.Windows.Forms.TextBox();
            this.txtPrivateKeyP = new System.Windows.Forms.TextBox();
            this.txtPrivateKeyQ = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCiphertext = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDecrypted = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Длина ключа:";
            // 
            // txtKeyLength
            // 
            this.txtKeyLength.Location = new System.Drawing.Point(102, 12);
            this.txtKeyLength.Name = "txtKeyLength";
            this.txtKeyLength.Size = new System.Drawing.Size(100, 23);
            this.txtKeyLength.TabIndex = 1;
            this.txtKeyLength.Text = "512";
            // 
            // btnGenerateKeys
            // 
            this.btnGenerateKeys.Location = new System.Drawing.Point(208, 11);
            this.btnGenerateKeys.Name = "btnGenerateKeys";
            this.btnGenerateKeys.Size = new System.Drawing.Size(150, 23);
            this.btnGenerateKeys.TabIndex = 2;
            this.btnGenerateKeys.Text = "Сгенерировать ключи";
            this.btnGenerateKeys.UseVisualStyleBackColor = true;
            this.btnGenerateKeys.Click += new System.EventHandler(this.btnGenerateKeys_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPublicKeyN);
            this.groupBox1.Controls.Add(this.txtPublicKeyE);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Открытый ключ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "e:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "n:";
            // 
            // txtPublicKeyE
            // 
            this.txtPublicKeyE.Location = new System.Drawing.Point(29, 22);
            this.txtPublicKeyE.Name = "txtPublicKeyE";
            this.txtPublicKeyE.ReadOnly = true;
            this.txtPublicKeyE.Size = new System.Drawing.Size(741, 23);
            this.txtPublicKeyE.TabIndex = 2;
            // 
            // txtPublicKeyN
            // 
            this.txtPublicKeyN.Location = new System.Drawing.Point(29, 51);
            this.txtPublicKeyN.Name = "txtPublicKeyN";
            this.txtPublicKeyN.ReadOnly = true;
            this.txtPublicKeyN.Size = new System.Drawing.Size(741, 23);
            this.txtPublicKeyN.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPrivateKeyQ);
            this.groupBox2.Controls.Add(this.txtPrivateKeyP);
            this.groupBox2.Controls.Add(this.txtPrivateKeyD);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 129);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Закрытый ключ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "d:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "p:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "q:";
            // 
            // txtPrivateKeyD
            // 
            this.txtPrivateKeyD.Location = new System.Drawing.Point(29, 22);
            this.txtPrivateKeyD.Name = "txtPrivateKeyD";
            this.txtPrivateKeyD.ReadOnly = true;
            this.txtPrivateKeyD.Size = new System.Drawing.Size(741, 23);
            this.txtPrivateKeyD.TabIndex = 3;
            // 
            // txtPrivateKeyP
            // 
            this.txtPrivateKeyP.Location = new System.Drawing.Point(29, 51);
            this.txtPrivateKeyP.Name = "txtPrivateKeyP";
            this.txtPrivateKeyP.ReadOnly = true;
            this.txtPrivateKeyP.Size = new System.Drawing.Size(741, 23);
            this.txtPrivateKeyP.TabIndex = 4;
            // 
            // txtPrivateKeyQ
            // 
            this.txtPrivateKeyQ.Location = new System.Drawing.Point(29, 80);
            this.txtPrivateKeyQ.Name = "txtPrivateKeyQ";
            this.txtPrivateKeyQ.ReadOnly = true;
            this.txtPrivateKeyQ.Size = new System.Drawing.Size(741, 23);
            this.txtPrivateKeyQ.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDecrypted);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnDecrypt);
            this.groupBox3.Controls.Add(this.txtCiphertext);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnEncrypt);
            this.groupBox3.Controls.Add(this.txtMessage);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 282);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 156);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Шифрование и дешифрование";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Сообщение:";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(88, 22);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(582, 23);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.Text = "123456";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Enabled = false;
            this.btnEncrypt.Location = new System.Drawing.Point(676, 21);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(94, 23);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Шифровать";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 30);
            this.label8.TabIndex = 3;
            this.label8.Text = "Шифрованное\r\nсообщение:";
            // 
            // txtCiphertext
            // 
            this.txtCiphertext.Location = new System.Drawing.Point(88, 61);
            this.txtCiphertext.Name = "txtCiphertext";
            this.txtCiphertext.ReadOnly = true;
            this.txtCiphertext.Size = new System.Drawing.Size(582, 23);
            this.txtCiphertext.TabIndex = 4;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Enabled = false;
            this.btnDecrypt.Location = new System.Drawing.Point(676, 61);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(94, 23);
            this.btnDecrypt.TabIndex = 5;
            this.btnDecrypt.Text = "Дешифровать";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 30);
            this.label9.TabIndex = 6;
            this.label9.Text = "Расшифрованное\r\nсообщение:";
            // 
            // txtDecrypted
            // 
            this.txtDecrypted.Location = new System.Drawing.Point(88, 107);
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.ReadOnly = true;
            this.txtDecrypted.Size = new System.Drawing.Size(582, 23);
            this.txtDecrypted.TabIndex = 7;
            // 
            // RSAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGenerateKeys);
            this.Controls.Add(this.txtKeyLength);
            this.Controls.Add(this.label1);
            this.Name = "RSAForm";
            this.Text = "RSA Шифрование";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKeyLength;
        private System.Windows.Forms.Button btnGenerateKeys;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPublicKeyN;
        private System.Windows.Forms.TextBox txtPublicKeyE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPrivateKeyQ;
        private System.Windows.Forms.TextBox txtPrivateKeyP;
        private System.Windows.Forms.TextBox txtPrivateKeyD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDecrypted;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtCiphertext;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label7;
    }
}