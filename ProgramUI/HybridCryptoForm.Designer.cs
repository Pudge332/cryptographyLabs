namespace ProgramUI
{
    partial class HybridCryptoForm
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
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.lblPrivateKey = new System.Windows.Forms.Label();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.lblPublicKey = new System.Windows.Forms.Label();
            this.groupBoxEncryption = new System.Windows.Forms.GroupBox();
            this.btnEncryptAndSign = new System.Windows.Forms.Button();
            this.txtOriginalMessage = new System.Windows.Forms.TextBox();
            this.lblOriginalMessage = new System.Windows.Forms.Label();
            this.txtEncryptedMessage = new System.Windows.Forms.TextBox();
            this.lblEncryptedMessage = new System.Windows.Forms.Label();
            this.groupBoxDecryption = new System.Windows.Forms.GroupBox();
            this.btnDecryptAndVerify = new System.Windows.Forms.Button();
            this.txtDecryptedMessage = new System.Windows.Forms.TextBox();
            this.lblDecryptedMessage = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBoxKeys.SuspendLayout();
            this.groupBoxEncryption.SuspendLayout();
            this.groupBoxDecryption.SuspendLayout();
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
            this.txtKeySize.Text = "2048";
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
            this.groupBoxKeys.Controls.Add(this.txtPrivateKey);
            this.groupBoxKeys.Controls.Add(this.lblPrivateKey);
            this.groupBoxKeys.Controls.Add(this.txtPublicKey);
            this.groupBoxKeys.Controls.Add(this.lblPublicKey);
            this.groupBoxKeys.Location = new System.Drawing.Point(12, 46);
            this.groupBoxKeys.Name = "groupBoxKeys";
            this.groupBoxKeys.Size = new System.Drawing.Size(776, 120);
            this.groupBoxKeys.TabIndex = 3;
            this.groupBoxKeys.TabStop = false;
            this.groupBoxKeys.Text = "Ключи";
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Location = new System.Drawing.Point(137, 56);
            this.txtPrivateKey.Multiline = true;
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.ReadOnly = true;
            this.txtPrivateKey.Size = new System.Drawing.Size(633, 50);
            this.txtPrivateKey.TabIndex = 3;
            // 
            // lblPrivateKey
            // 
            this.lblPrivateKey.AutoSize = true;
            this.lblPrivateKey.Location = new System.Drawing.Point(6, 59);
            this.lblPrivateKey.Name = "lblPrivateKey";
            this.lblPrivateKey.Size = new System.Drawing.Size(125, 20);
            this.lblPrivateKey.TabIndex = 2;
            this.lblPrivateKey.Text = "Закрытый ключ:";
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Location = new System.Drawing.Point(137, 23);
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.ReadOnly = true;
            this.txtPublicKey.Size = new System.Drawing.Size(633, 27);
            this.txtPublicKey.TabIndex = 1;
            // 
            // lblPublicKey
            // 
            this.lblPublicKey.AutoSize = true;
            this.lblPublicKey.Location = new System.Drawing.Point(6, 26);
            this.lblPublicKey.Name = "lblPublicKey";
            this.lblPublicKey.Size = new System.Drawing.Size(125, 20);
            this.lblPublicKey.TabIndex = 0;
            this.lblPublicKey.Text = "Открытый ключ:";
            // 
            // groupBoxEncryption
            // 
            this.groupBoxEncryption.Controls.Add(this.btnEncryptAndSign);
            this.groupBoxEncryption.Controls.Add(this.txtOriginalMessage);
            this.groupBoxEncryption.Controls.Add(this.lblOriginalMessage);
            this.groupBoxEncryption.Controls.Add(this.txtEncryptedMessage);
            this.groupBoxEncryption.Controls.Add(this.lblEncryptedMessage);
            this.groupBoxEncryption.Location = new System.Drawing.Point(12, 172);
            this.groupBoxEncryption.Name = "groupBoxEncryption";
            this.groupBoxEncryption.Size = new System.Drawing.Size(776, 170);
            this.groupBoxEncryption.TabIndex = 4;
            this.groupBoxEncryption.TabStop = false;
            this.groupBoxEncryption.Text = "Шифрование";
            // 
            // btnEncryptAndSign
            // 
            this.btnEncryptAndSign.Location = new System.Drawing.Point(643, 22);
            this.btnEncryptAndSign.Name = "btnEncryptAndSign";
            this.btnEncryptAndSign.Size = new System.Drawing.Size(127, 29);
            this.btnEncryptAndSign.TabIndex = 2;
            this.btnEncryptAndSign.Text = "Зашифровать";
            this.btnEncryptAndSign.UseVisualStyleBackColor = true;
            this.btnEncryptAndSign.Click += new System.EventHandler(this.btnEncryptAndSign_Click);
            // 
            // txtOriginalMessage
            // 
            this.txtOriginalMessage.Location = new System.Drawing.Point(137, 23);
            this.txtOriginalMessage.Multiline = true;
            this.txtOriginalMessage.Name = "txtOriginalMessage";
            this.txtOriginalMessage.Size = new System.Drawing.Size(500, 60);
            this.txtOriginalMessage.TabIndex = 1;
            // 
            // lblOriginalMessage
            // 
            this.lblOriginalMessage.AutoSize = true;
            this.lblOriginalMessage.Location = new System.Drawing.Point(6, 26);
            this.lblOriginalMessage.Name = "lblOriginalMessage";
            this.lblOriginalMessage.Size = new System.Drawing.Size(125, 20);
            this.lblOriginalMessage.TabIndex = 0;
            this.lblOriginalMessage.Text = "Сообщение:";
            // 
            // txtEncryptedMessage
            // 
            this.txtEncryptedMessage.Location = new System.Drawing.Point(137, 93);
            this.txtEncryptedMessage.Multiline = true;
            this.txtEncryptedMessage.Name = "txtEncryptedMessage";
            this.txtEncryptedMessage.ReadOnly = true;
            this.txtEncryptedMessage.Size = new System.Drawing.Size(500, 60);
            this.txtEncryptedMessage.TabIndex = 4;
            // 
            // lblEncryptedMessage
            // 
            this.lblEncryptedMessage.AutoSize = true;
            this.lblEncryptedMessage.Location = new System.Drawing.Point(6, 96);
            this.lblEncryptedMessage.Name = "lblEncryptedMessage";
            this.lblEncryptedMessage.Size = new System.Drawing.Size(125, 20);
            this.lblEncryptedMessage.TabIndex = 3;
            this.lblEncryptedMessage.Text = "Зашифровано:";
            // 
            // groupBoxDecryption
            // 
            this.groupBoxDecryption.Controls.Add(this.btnDecryptAndVerify);
            this.groupBoxDecryption.Controls.Add(this.txtDecryptedMessage);
            this.groupBoxDecryption.Controls.Add(this.lblDecryptedMessage);
            this.groupBoxDecryption.Location = new System.Drawing.Point(12, 348);
            this.groupBoxDecryption.Name = "groupBoxDecryption";
            this.groupBoxDecryption.Size = new System.Drawing.Size(776, 100);
            this.groupBoxDecryption.TabIndex = 5;
            this.groupBoxDecryption.TabStop = false;
            this.groupBoxDecryption.Text = "Расшифрование";
            // 
            // btnDecryptAndVerify
            // 
            this.btnDecryptAndVerify.Location = new System.Drawing.Point(643, 22);
            this.btnDecryptAndVerify.Name = "btnDecryptAndVerify";
            this.btnDecryptAndVerify.Size = new System.Drawing.Size(127, 29);
            this.btnDecryptAndVerify.TabIndex = 2;
            this.btnDecryptAndVerify.Text = "Расшифровать";
            this.btnDecryptAndVerify.UseVisualStyleBackColor = true;
            this.btnDecryptAndVerify.Click += new System.EventHandler(this.btnDecryptAndVerify_Click);
            // 
            // txtDecryptedMessage
            // 
            this.txtDecryptedMessage.Location = new System.Drawing.Point(137, 23);
            this.txtDecryptedMessage.Multiline = true;
            this.txtDecryptedMessage.Name = "txtDecryptedMessage";
            this.txtDecryptedMessage.ReadOnly = true;
            this.txtDecryptedMessage.Size = new System.Drawing.Size(500, 60);
            this.txtDecryptedMessage.TabIndex = 1;
            // 
            // lblDecryptedMessage
            // 
            this.lblDecryptedMessage.AutoSize = true;
            this.lblDecryptedMessage.Location = new System.Drawing.Point(6, 26);
            this.lblDecryptedMessage.Name = "lblDecryptedMessage";
            this.lblDecryptedMessage.Size = new System.Drawing.Size(125, 20);
            this.lblDecryptedMessage.TabIndex = 0;
            this.lblDecryptedMessage.Text = "Расшифровано:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(12, 460);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 20);
            this.lblStatus.TabIndex = 6;
            // 
            // HybridCryptoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.groupBoxDecryption);
            this.Controls.Add(this.groupBoxEncryption);
            this.Controls.Add(this.groupBoxKeys);
            this.Controls.Add(this.btnGenerateKeys);
            this.Controls.Add(this.txtKeySize);
            this.Controls.Add(this.lblKeySize);
            this.Name = "HybridCryptoForm";
            this.Text = "Гибридная криптосистема";
            this.groupBoxKeys.ResumeLayout(false);
            this.groupBoxKeys.PerformLayout();
            this.groupBoxEncryption.ResumeLayout(false);
            this.groupBoxEncryption.PerformLayout();
            this.groupBoxDecryption.ResumeLayout(false);
            this.groupBoxDecryption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblKeySize;
        private System.Windows.Forms.TextBox txtKeySize;
        private System.Windows.Forms.Button btnGenerateKeys;
        private System.Windows.Forms.GroupBox groupBoxKeys;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.Label lblPrivateKey;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.Label lblPublicKey;
        private System.Windows.Forms.GroupBox groupBoxEncryption;
        private System.Windows.Forms.Button btnEncryptAndSign;
        private System.Windows.Forms.TextBox txtOriginalMessage;
        private System.Windows.Forms.Label lblOriginalMessage;
        private System.Windows.Forms.TextBox txtEncryptedMessage;
        private System.Windows.Forms.Label lblEncryptedMessage;
        private System.Windows.Forms.GroupBox groupBoxDecryption;
        private System.Windows.Forms.Button btnDecryptAndVerify;
        private System.Windows.Forms.TextBox txtDecryptedMessage;
        private System.Windows.Forms.Label lblDecryptedMessage;
        private System.Windows.Forms.Label lblStatus;
    }
}