namespace ProgramUI
{
    partial class RSAForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.lblKeySize = new System.Windows.Forms.Label();
            this.txtKeySize = new System.Windows.Forms.TextBox();
            this.btnGenerateKeys = new System.Windows.Forms.Button();
            this.groupBoxKeys = new System.Windows.Forms.GroupBox();
            this.lblPublicE = new System.Windows.Forms.Label();
            this.txtPublicE = new System.Windows.Forms.TextBox();
            this.lblPublicN = new System.Windows.Forms.Label();
            this.txtPublicN = new System.Windows.Forms.TextBox();
            this.lblPrivateD = new System.Windows.Forms.Label();
            this.txtPrivateD = new System.Windows.Forms.TextBox();
            this.lblPrivateP = new System.Windows.Forms.Label();
            this.txtPrivateP = new System.Windows.Forms.TextBox();
            this.lblPrivateQ = new System.Windows.Forms.Label();
            this.txtPrivateQ = new System.Windows.Forms.TextBox();
            this.groupBoxEncryption = new System.Windows.Forms.GroupBox();
            this.lblPlaintext = new System.Windows.Forms.Label();
            this.txtPlaintext = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.lblCiphertext = new System.Windows.Forms.Label();
            this.txtCiphertext = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lblDecrypted = new System.Windows.Forms.Label();
            this.txtDecrypted = new System.Windows.Forms.TextBox();
            this.groupBoxKeys.SuspendLayout();
            this.groupBoxEncryption.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKeySize
            // 
            this.lblKeySize.AutoSize = true;
            this.lblKeySize.Location = new System.Drawing.Point(12, 15);
            this.lblKeySize.Name = "lblKeySize";
            this.lblKeySize.Size = new System.Drawing.Size(119, 20);
            this.lblKeySize.TabIndex = 0;
            this.lblKeySize.Text = "Размер ключа:";
            // 
            // txtKeySize
            // 
            this.txtKeySize.Location = new System.Drawing.Point(137, 12);
            this.txtKeySize.Name = "txtKeySize";
            this.txtKeySize.Size = new System.Drawing.Size(100, 27);
            this.txtKeySize.TabIndex = 1;
            this.txtKeySize.Text = "512";
            // 
            // btnGenerateKeys
            // 
            this.btnGenerateKeys.Location = new System.Drawing.Point(243, 11);
            this.btnGenerateKeys.Name = "btnGenerateKeys";
            this.btnGenerateKeys.Size = new System.Drawing.Size(200, 29);
            this.btnGenerateKeys.TabIndex = 2;
            this.btnGenerateKeys.Text = "Сгенерировать ключи";
            this.btnGenerateKeys.UseVisualStyleBackColor = true;
            this.btnGenerateKeys.Click += new System.EventHandler(this.btnGenerateKeys_Click);
            // 
            // groupBoxKeys
            // 
            this.groupBoxKeys.Controls.Add(this.txtPrivateQ);
            this.groupBoxKeys.Controls.Add(this.lblPrivateQ);
            this.groupBoxKeys.Controls.Add(this.txtPrivateP);
            this.groupBoxKeys.Controls.Add(this.lblPrivateP);
            this.groupBoxKeys.Controls.Add(this.txtPrivateD);
            this.groupBoxKeys.Controls.Add(this.lblPrivateD);
            this.groupBoxKeys.Controls.Add(this.txtPublicN);
            this.groupBoxKeys.Controls.Add(this.lblPublicN);
            this.groupBoxKeys.Controls.Add(this.txtPublicE);
            this.groupBoxKeys.Controls.Add(this.lblPublicE);
            this.groupBoxKeys.Location = new System.Drawing.Point(12, 46);
            this.groupBoxKeys.Name = "groupBoxKeys";
            this.groupBoxKeys.Size = new System.Drawing.Size(776, 200);
            this.groupBoxKeys.TabIndex = 3;
            this.groupBoxKeys.TabStop = false;
            this.groupBoxKeys.Text = "Ключи";
            // 
            // lblPublicE
            // 
            this.lblPublicE.AutoSize = true;
            this.lblPublicE.Location = new System.Drawing.Point(6, 23);
            this.lblPublicE.Name = "lblPublicE";
            this.lblPublicE.Size = new System.Drawing.Size(125, 20);
            this.lblPublicE.TabIndex = 0;
            this.lblPublicE.Text = "Открытый ключ e:";
            // 
            // txtPublicE
            // 
            this.txtPublicE.Location = new System.Drawing.Point(137, 20);
            this.txtPublicE.Name = "txtPublicE";
            this.txtPublicE.ReadOnly = true;
            this.txtPublicE.Size = new System.Drawing.Size(633, 27);
            this.txtPublicE.TabIndex = 1;
            // 
            // lblPublicN
            // 
            this.lblPublicN.AutoSize = true;
            this.lblPublicN.Location = new System.Drawing.Point(6, 56);
            this.lblPublicN.Name = "lblPublicN";
            this.lblPublicN.Size = new System.Drawing.Size(125, 20);
            this.lblPublicN.TabIndex = 2;
            this.lblPublicN.Text = "Открытый ключ n:";
            // 
            // txtPublicN
            // 
            this.txtPublicN.Location = new System.Drawing.Point(137, 53);
            this.txtPublicN.Name = "txtPublicN";
            this.txtPublicN.ReadOnly = true;
            this.txtPublicN.Size = new System.Drawing.Size(633, 27);
            this.txtPublicN.TabIndex = 3;
            // 
            // lblPrivateD
            // 
            this.lblPrivateD.AutoSize = true;
            this.lblPrivateD.Location = new System.Drawing.Point(6, 89);
            this.lblPrivateD.Name = "lblPrivateD";
            this.lblPrivateD.Size = new System.Drawing.Size(125, 20);
            this.lblPrivateD.TabIndex = 4;
            this.lblPrivateD.Text = "Закрытый ключ d:";
            // 
            // txtPrivateD
            // 
            this.txtPrivateD.Location = new System.Drawing.Point(137, 86);
            this.txtPrivateD.Name = "txtPrivateD";
            this.txtPrivateD.ReadOnly = true;
            this.txtPrivateD.Size = new System.Drawing.Size(633, 27);
            this.txtPrivateD.TabIndex = 5;
            // 
            // lblPrivateP
            // 
            this.lblPrivateP.AutoSize = true;
            this.lblPrivateP.Location = new System.Drawing.Point(6, 122);
            this.lblPrivateP.Name = "lblPrivateP";
            this.lblPrivateP.Size = new System.Drawing.Size(125, 20);
            this.lblPrivateP.TabIndex = 6;
            this.lblPrivateP.Text = "Закрытый ключ p:";
            // 
            // txtPrivateP
            // 
            this.txtPrivateP.Location = new System.Drawing.Point(137, 119);
            this.txtPrivateP.Name = "txtPrivateP";
            this.txtPrivateP.ReadOnly = true;
            this.txtPrivateP.Size = new System.Drawing.Size(633, 27);
            this.txtPrivateP.TabIndex = 7;
            // 
            // lblPrivateQ
            // 
            this.lblPrivateQ.AutoSize = true;
            this.lblPrivateQ.Location = new System.Drawing.Point(6, 155);
            this.lblPrivateQ.Name = "lblPrivateQ";
            this.lblPrivateQ.Size = new System.Drawing.Size(125, 20);
            this.lblPrivateQ.TabIndex = 8;
            this.lblPrivateQ.Text = "Закрытый ключ q:";
            // 
            // txtPrivateQ
            // 
            this.txtPrivateQ.Location = new System.Drawing.Point(137, 152);
            this.txtPrivateQ.Name = "txtPrivateQ";
            this.txtPrivateQ.ReadOnly = true;
            this.txtPrivateQ.Size = new System.Drawing.Size(633, 27);
            this.txtPrivateQ.TabIndex = 9;
            // 
            // groupBoxEncryption
            // 
            this.groupBoxEncryption.Controls.Add(this.txtDecrypted);
            this.groupBoxEncryption.Controls.Add(this.lblDecrypted);
            this.groupBoxEncryption.Controls.Add(this.btnDecrypt);
            this.groupBoxEncryption.Controls.Add(this.txtCiphertext);
            this.groupBoxEncryption.Controls.Add(this.lblCiphertext);
            this.groupBoxEncryption.Controls.Add(this.btnEncrypt);
            this.groupBoxEncryption.Controls.Add(this.txtPlaintext);
            this.groupBoxEncryption.Controls.Add(this.lblPlaintext);
            this.groupBoxEncryption.Location = new System.Drawing.Point(12, 252);
            this.groupBoxEncryption.Name = "groupBoxEncryption";
            this.groupBoxEncryption.Size = new System.Drawing.Size(776, 186);
            this.groupBoxEncryption.TabIndex = 4;
            this.groupBoxEncryption.TabStop = false;
            this.groupBoxEncryption.Text = "Шифрование/Дешифрование";
            // 
            // lblPlaintext
            // 
            this.lblPlaintext.AutoSize = true;
            this.lblPlaintext.Location = new System.Drawing.Point(6, 23);
            this.lblPlaintext.Name = "lblPlaintext";
            this.lblPlaintext.Size = new System.Drawing.Size(94, 20);
            this.lblPlaintext.TabIndex = 0;
            this.lblPlaintext.Text = "Сообщение:";
            // 
            // txtPlaintext
            // 
            this.txtPlaintext.Location = new System.Drawing.Point(137, 20);
            this.txtPlaintext.Name = "txtPlaintext";
            this.txtPlaintext.Size = new System.Drawing.Size(500, 27);
            this.txtPlaintext.TabIndex = 1;
            this.txtPlaintext.Text = "123456";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(643, 19);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(127, 29);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Зашифровать";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // lblCiphertext
            // 
            this.lblCiphertext.AutoSize = true;
            this.lblCiphertext.Location = new System.Drawing.Point(6, 56);
            this.lblCiphertext.Name = "lblCiphertext";
            this.lblCiphertext.Size = new System.Drawing.Size(125, 20);
            this.lblCiphertext.TabIndex = 3;
            this.lblCiphertext.Text = "Шифротекст:";
            // 
            // txtCiphertext
            // 
            this.txtCiphertext.Location = new System.Drawing.Point(137, 53);
            this.txtCiphertext.Multiline = true;
            this.txtCiphertext.Name = "txtCiphertext";
            this.txtCiphertext.ReadOnly = true;
            this.txtCiphertext.Size = new System.Drawing.Size(633, 60);
            this.txtCiphertext.TabIndex = 4;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(643, 119);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(127, 29);
            this.btnDecrypt.TabIndex = 5;
            this.btnDecrypt.Text = "Расшифровать";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lblDecrypted
            // 
            this.lblDecrypted.AutoSize = true;
            this.lblDecrypted.Location = new System.Drawing.Point(6, 152);
            this.lblDecrypted.Name = "lblDecrypted";
            this.lblDecrypted.Size = new System.Drawing.Size(125, 20);
            this.lblDecrypted.TabIndex = 6;
            this.lblDecrypted.Text = "Расшифровано:";
            // 
            // txtDecrypted
            // 
            this.txtDecrypted.Location = new System.Drawing.Point(137, 149);
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.ReadOnly = true;
            this.txtDecrypted.Size = new System.Drawing.Size(633, 27);
            this.txtDecrypted.TabIndex = 7;
            // 
            // RSAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxEncryption);
            this.Controls.Add(this.groupBoxKeys);
            this.Controls.Add(this.btnGenerateKeys);
            this.Controls.Add(this.txtKeySize);
            this.Controls.Add(this.lblKeySize);
            this.Name = "RSAForm";
            this.Text = "RSA Шифрование";
            this.groupBoxKeys.ResumeLayout(false);
            this.groupBoxKeys.PerformLayout();
            this.groupBoxEncryption.ResumeLayout(false);
            this.groupBoxEncryption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblKeySize;
        private System.Windows.Forms.TextBox txtKeySize;
        private System.Windows.Forms.Button btnGenerateKeys;
        private System.Windows.Forms.GroupBox groupBoxKeys;
        private System.Windows.Forms.Label lblPublicE;
        private System.Windows.Forms.TextBox txtPublicE;
        private System.Windows.Forms.Label lblPublicN;
        private System.Windows.Forms.TextBox txtPublicN;
        private System.Windows.Forms.Label lblPrivateD;
        private System.Windows.Forms.TextBox txtPrivateD;
        private System.Windows.Forms.Label lblPrivateP;
        private System.Windows.Forms.TextBox txtPrivateP;
        private System.Windows.Forms.Label lblPrivateQ;
        private System.Windows.Forms.TextBox txtPrivateQ;
        private System.Windows.Forms.GroupBox groupBoxEncryption;
        private System.Windows.Forms.TextBox txtDecrypted;
        private System.Windows.Forms.Label lblDecrypted;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtCiphertext;
        private System.Windows.Forms.Label lblCiphertext;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtPlaintext;
        private System.Windows.Forms.Label lblPlaintext;
    }
}