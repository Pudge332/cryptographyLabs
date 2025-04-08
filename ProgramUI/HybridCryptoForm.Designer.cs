namespace ProgramUI
{
    partial class HybridCryptoForm
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
            this.txtKeySize = new System.Windows.Forms.TextBox();
            this.btnGenerateKeys = new System.Windows.Forms.Button();
            this.lblKeysStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEncryptAndSign = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEncryptStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblVerifyStatus = new System.Windows.Forms.Label();
            this.txtDecrypted = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDecryptAndVerify = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размер ключа:";
            // 
            // txtKeySize
            // 
            this.txtKeySize.Location = new System.Drawing.Point(102, 12);
            this.txtKeySize.Name = "txtKeySize";
            this.txtKeySize.Size = new System.Drawing.Size(100, 23);
            this.txtKeySize.TabIndex = 1;
            this.txtKeySize.Text = "2048";
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
            // lblKeysStatus
            // 
            this.lblKeysStatus.AutoSize = true;
            this.lblKeysStatus.Location = new System.Drawing.Point(364, 15);
            this.lblKeysStatus.Name = "lblKeysStatus";
            this.lblKeysStatus.Size = new System.Drawing.Size(0, 15);
            this.lblKeysStatus.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEncryptStatus);
            this.groupBox1.Controls.Add(this.btnEncryptAndSign);
            this.groupBox1.Controls.Add(this.txtMessage);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Шифрование и подпись";
            // 
            // btnEncryptAndSign
            // 
            this.btnEncryptAndSign.Enabled = false;
            this.btnEncryptAndSign.Location = new System.Drawing.Point(6, 51);
            this.btnEncryptAndSign.Name = "btnEncryptAndSign";
            this.btnEncryptAndSign.Size = new System.Drawing.Size(150, 23);
            this.btnEncryptAndSign.TabIndex = 2;
            this.btnEncryptAndSign.Text = "Зашифровать и подписать";
            this.btnEncryptAndSign.UseVisualStyleBackColor = true;
            this.btnEncryptAndSign.Click += new System.EventHandler(this.btnEncryptAndSign_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(90, 22);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(680, 23);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.Text = "Секретное сообщение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Сообщение:";
            // 
            // lblEncryptStatus
            // 
            this.lblEncryptStatus.AutoSize = true;
            this.lblEncryptStatus.Location = new System.Drawing.Point(162, 55);
            this.lblEncryptStatus.Name = "lblEncryptStatus";
            this.lblEncryptStatus.Size = new System.Drawing.Size(0, 15);
            this.lblEncryptStatus.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblVerifyStatus);
            this.groupBox2.Controls.Add(this.txtDecrypted);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnDecryptAndVerify);
            this.groupBox2.Location = new System.Drawing.Point(12, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дешифрование и проверка подписи";
            // 
            // lblVerifyStatus
            // 
            this.lblVerifyStatus.AutoSize = true;
            this.lblVerifyStatus.Location = new System.Drawing.Point(162, 26);
            this.lblVerifyStatus.Name = "lblVerifyStatus";
            this.lblVerifyStatus.Size = new System.Drawing.Size(0, 15);
            this.lblVerifyStatus.TabIndex = 3;
            // 
            // txtDecrypted
            // 
            this.txtDecrypted.Location = new System.Drawing.Point(90, 51);
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.ReadOnly = true;
            this.txtDecrypted.Size = new System.Drawing.Size(680, 23);
            this.txtDecrypted.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Результат:";
            // 
            // btnDecryptAndVerify
            // 
            this.btnDecryptAndVerify.Enabled = false;
            this.btnDecryptAndVerify.Location = new System.Drawing.Point(6, 22);
            this.btnDecryptAndVerify.Name = "btnDecryptAndVerify";
            this.btnDecryptAndVerify.Size = new System.Drawing.Size(150, 23);
            this.btnDecryptAndVerify.TabIndex = 0;
            this.btnDecryptAndVerify.Text = "Расшифровать и проверить";
            this.btnDecryptAndVerify.UseVisualStyleBackColor = true;
            this.btnDecryptAndVerify.Click += new System.EventHandler(this.btnDecryptAndVerify_Click);
            // 
            // HybridCryptoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 259);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblKeysStatus);
            this.Controls.Add(this.btnGenerateKeys);
            this.Controls.Add(this.txtKeySize);
            this.Controls.Add(this.label1);
            this.Name = "HybridCryptoForm";
            this.Text = "Гибридная криптосистема";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKeySize;
        private System.Windows.Forms.Button btnGenerateKeys;
        private System.Windows.Forms.Label lblKeysStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEncryptStatus;
        private System.Windows.Forms.Button btnEncryptAndSign;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblVerifyStatus;
        private System.Windows.Forms.TextBox txtDecrypted;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDecryptAndVerify;
    }
}