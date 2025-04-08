namespace ProgramUI
{
    partial class DiffieHellmanForm
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
            this.lblBitLength = new System.Windows.Forms.Label();
            this.txtBitLength = new System.Windows.Forms.TextBox();
            this.btnGenerateParameters = new System.Windows.Forms.Button();
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.txtBaseG = new System.Windows.Forms.TextBox();
            this.lblBaseG = new System.Windows.Forms.Label();
            this.txtPrimeP = new System.Windows.Forms.TextBox();
            this.lblPrimeP = new System.Windows.Forms.Label();
            this.groupBoxAlice = new System.Windows.Forms.GroupBox();
            this.txtAliceSharedSecret = new System.Windows.Forms.TextBox();
            this.lblAliceSharedSecret = new System.Windows.Forms.Label();
            this.txtAlicePublic = new System.Windows.Forms.TextBox();
            this.lblAlicePublic = new System.Windows.Forms.Label();
            this.txtAlicePrivate = new System.Windows.Forms.TextBox();
            this.lblAlicePrivate = new System.Windows.Forms.Label();
            this.btnGenerateAliceKeys = new System.Windows.Forms.Button();
            this.groupBoxBob = new System.Windows.Forms.GroupBox();
            this.txtBobSharedSecret = new System.Windows.Forms.TextBox();
            this.lblBobSharedSecret = new System.Windows.Forms.Label();
            this.txtBobPublic = new System.Windows.Forms.TextBox();
            this.lblBobPublic = new System.Windows.Forms.Label();
            this.txtBobPrivate = new System.Windows.Forms.TextBox();
            this.lblBobPrivate = new System.Windows.Forms.Label();
            this.btnGenerateBobKeys = new System.Windows.Forms.Button();
            this.btnComputeSharedSecret = new System.Windows.Forms.Button();
            this.lblSecretMatch = new System.Windows.Forms.Label();
            this.groupBoxParameters.SuspendLayout();
            this.groupBoxAlice.SuspendLayout();
            this.groupBoxBob.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBitLength
            // 
            this.lblBitLength.AutoSize = true;
            this.lblBitLength.Location = new System.Drawing.Point(12, 15);
            this.lblBitLength.Name = "lblBitLength";
            this.lblBitLength.Size = new System.Drawing.Size(119, 20);
            this.lblBitLength.TabIndex = 0;
            this.lblBitLength.Text = "Длина в битах:";
            // 
            // txtBitLength
            // 
            this.txtBitLength.Location = new System.Drawing.Point(137, 12);
            this.txtBitLength.Name = "txtBitLength";
            this.txtBitLength.Size = new System.Drawing.Size(100, 27);
            this.txtBitLength.TabIndex = 1;
            this.txtBitLength.Text = "512";
            // 
            // btnGenerateParameters
            // 
            this.btnGenerateParameters.Location = new System.Drawing.Point(243, 11);
            this.btnGenerateParameters.Name = "btnGenerateParameters";
            this.btnGenerateParameters.Size = new System.Drawing.Size(200, 29);
            this.btnGenerateParameters.TabIndex = 2;
            this.btnGenerateParameters.Text = "Сгенерировать параметры";
            this.btnGenerateParameters.UseVisualStyleBackColor = true;
            this.btnGenerateParameters.Click += new System.EventHandler(this.btnGenerateParameters_Click);
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.txtBaseG);
            this.groupBoxParameters.Controls.Add(this.lblBaseG);
            this.groupBoxParameters.Controls.Add(this.txtPrimeP);
            this.groupBoxParameters.Controls.Add(this.lblPrimeP);
            this.groupBoxParameters.Location = new System.Drawing.Point(12, 46);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(776, 100);
            this.groupBoxParameters.TabIndex = 3;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Параметры";
            // 
            // txtBaseG
            // 
            this.txtBaseG.Location = new System.Drawing.Point(137, 56);
            this.txtBaseG.Name = "txtBaseG";
            this.txtBaseG.ReadOnly = true;
            this.txtBaseG.Size = new System.Drawing.Size(633, 27);
            this.txtBaseG.TabIndex = 3;
            // 
            // lblBaseG
            // 
            this.lblBaseG.AutoSize = true;
            this.lblBaseG.Location = new System.Drawing.Point(6, 59);
            this.lblBaseG.Name = "lblBaseG";
            this.lblBaseG.Size = new System.Drawing.Size(125, 20);
            this.lblBaseG.TabIndex = 2;
            this.lblBaseG.Text = "Основание g:";
            // 
            // txtPrimeP
            // 
            this.txtPrimeP.Location = new System.Drawing.Point(137, 23);
            this.txtPrimeP.Name = "txtPrimeP";
            this.txtPrimeP.ReadOnly = true;
            this.txtPrimeP.Size = new System.Drawing.Size(633, 27);
            this.txtPrimeP.TabIndex = 1;
            // 
            // lblPrimeP
            // 
            this.lblPrimeP.AutoSize = true;
            this.lblPrimeP.Location = new System.Drawing.Point(6, 26);
            this.lblPrimeP.Name = "lblPrimeP";
            this.lblPrimeP.Size = new System.Drawing.Size(125, 20);
            this.lblPrimeP.TabIndex = 0;
            this.lblPrimeP.Text = "Простое число p:";
            // 
            // groupBoxAlice
            // 
            this.groupBoxAlice.Controls.Add(this.txtAliceSharedSecret);
            this.groupBoxAlice.Controls.Add(this.lblAliceSharedSecret);
            this.groupBoxAlice.Controls.Add(this.txtAlicePublic);
            this.groupBoxAlice.Controls.Add(this.lblAlicePublic);
            this.groupBoxAlice.Controls.Add(this.txtAlicePrivate);
            this.groupBoxAlice.Controls.Add(this.lblAlicePrivate);
            this.groupBoxAlice.Controls.Add(this.btnGenerateAliceKeys);
            this.groupBoxAlice.Location = new System.Drawing.Point(12, 152);
            this.groupBoxAlice.Name = "groupBoxAlice";
            this.groupBoxAlice.Size = new System.Drawing.Size(776, 125);
            this.groupBoxAlice.TabIndex = 4;
            this.groupBoxAlice.TabStop = false;
            this.groupBoxAlice.Text = "Участник A (Алиса)";
            // 
            // txtAliceSharedSecret
            // 
            this.txtAliceSharedSecret.Location = new System.Drawing.Point(137, 89);
            this.txtAliceSharedSecret.Name = "txtAliceSharedSecret";
            this.txtAliceSharedSecret.ReadOnly = true;
            this.txtAliceSharedSecret.Size = new System.Drawing.Size(633, 27);
            this.txtAliceSharedSecret.TabIndex = 6;
            // 
            // lblAliceSharedSecret
            // 
            this.lblAliceSharedSecret.AutoSize = true;
            this.lblAliceSharedSecret.Location = new System.Drawing.Point(6, 92);
            this.lblAliceSharedSecret.Name = "lblAliceSharedSecret";
            this.lblAliceSharedSecret.Size = new System.Drawing.Size(125, 20);
            this.lblAliceSharedSecret.TabIndex = 5;
            this.lblAliceSharedSecret.Text = "Общий секрет:";
            // 
            // txtAlicePublic
            // 
            this.txtAlicePublic.Location = new System.Drawing.Point(137, 56);
            this.txtAlicePublic.Name = "txtAlicePublic";
            this.txtAlicePublic.ReadOnly = true;
            this.txtAlicePublic.Size = new System.Drawing.Size(633, 27);
            this.txtAlicePublic.TabIndex = 4;
            // 
            // lblAlicePublic
            // 
            this.lblAlicePublic.AutoSize = true;
            this.lblAlicePublic.Location = new System.Drawing.Point(6, 59);
            this.lblAlicePublic.Name = "lblAlicePublic";
            this.lblAlicePublic.Size = new System.Drawing.Size(125, 20);
            this.lblAlicePublic.TabIndex = 3;
            this.lblAlicePublic.Text = "Открытый ключ:";
            // 
            // txtAlicePrivate
            // 
            this.txtAlicePrivate.Location = new System.Drawing.Point(137, 23);
            this.txtAlicePrivate.Name = "txtAlicePrivate";
            this.txtAlicePrivate.ReadOnly = true;
            this.txtAlicePrivate.Size = new System.Drawing.Size(500, 27);
            this.txtAlicePrivate.TabIndex = 2;
            // 
            // lblAlicePrivate
            // 
            this.lblAlicePrivate.AutoSize = true;
            this.lblAlicePrivate.Location = new System.Drawing.Point(6, 26);
            this.lblAlicePrivate.Name = "lblAlicePrivate";
            this.lblAlicePrivate.Size = new System.Drawing.Size(125, 20);
            this.lblAlicePrivate.TabIndex = 1;
            this.lblAlicePrivate.Text = "Закрытый ключ:";
            // 
            // btnGenerateAliceKeys
            // 
            this.btnGenerateAliceKeys.Location = new System.Drawing.Point(643, 22);
            this.btnGenerateAliceKeys.Name = "btnGenerateAliceKeys";
            this.btnGenerateAliceKeys.Size = new System.Drawing.Size(127, 29);
            this.btnGenerateAliceKeys.TabIndex = 0;
            this.btnGenerateAliceKeys.Text = "Сгенерировать";
            this.btnGenerateAliceKeys.UseVisualStyleBackColor = true;
            this.btnGenerateAliceKeys.Click += new System.EventHandler(this.btnGenerateAliceKeys_Click);
            // 
            // groupBoxBob
            // 
            this.groupBoxBob.Controls.Add(this.txtBobSharedSecret);
            this.groupBoxBob.Controls.Add(this.lblBobSharedSecret);
            this.groupBoxBob.Controls.Add(this.txtBobPublic);
            this.groupBoxBob.Controls.Add(this.lblBobPublic);
            this.groupBoxBob.Controls.Add(this.txtBobPrivate);
            this.groupBoxBob.Controls.Add(this.lblBobPrivate);
            this.groupBoxBob.Controls.Add(this.btnGenerateBobKeys);
            this.groupBoxBob.Location = new System.Drawing.Point(12, 283);
            this.groupBoxBob.Name = "groupBoxBob";
            this.groupBoxBob.Size = new System.Drawing.Size(776, 125);
            this.groupBoxBob.TabIndex = 5;
            this.groupBoxBob.TabStop = false;
            this.groupBoxBob.Text = "Участник B (Боб)";
            // 
            // txtBobSharedSecret
            // 
            this.txtBobSharedSecret.Location = new System.Drawing.Point(137, 89);
            this.txtBobSharedSecret.Name = "txtBobSharedSecret";
            this.txtBobSharedSecret.ReadOnly = true;
            this.txtBobSharedSecret.Size = new System.Drawing.Size(633, 27);
            this.txtBobSharedSecret.TabIndex = 6;
            // 
            // lblBobSharedSecret
            // 
            this.lblBobSharedSecret.AutoSize = true;
            this.lblBobSharedSecret.Location = new System.Drawing.Point(6, 92);
            this.lblBobSharedSecret.Name = "lblBobSharedSecret";
            this.lblBobSharedSecret.Size = new System.Drawing.Size(125, 20);
            this.lblBobSharedSecret.TabIndex = 5;
            this.lblBobSharedSecret.Text = "Общий секрет:";
            // 
            // txtBobPublic
            // 
            this.txtBobPublic.Location = new System.Drawing.Point(137, 56);
            this.txtBobPublic.Name = "txtBobPublic";
            this.txtBobPublic.ReadOnly = true;
            this.txtBobPublic.Size = new System.Drawing.Size(633, 27);
            this.txtBobPublic.TabIndex = 4;
            // 
            // lblBobPublic
            // 
            this.lblBobPublic.AutoSize = true;
            this.lblBobPublic.Location = new System.Drawing.Point(6, 59);
            this.lblBobPublic.Name = "lblBobPublic";
            this.lblBobPublic.Size = new System.Drawing.Size(125, 20);
            this.lblBobPublic.TabIndex = 3;
            this.lblBobPublic.Text = "Открытый ключ:";
            // 
            // txtBobPrivate
            // 
            this.txtBobPrivate.Location = new System.Drawing.Point(137, 23);
            this.txtBobPrivate.Name = "txtBobPrivate";
            this.txtBobPrivate.ReadOnly = true;
            this.txtBobPrivate.Size = new System.Drawing.Size(500, 27);
            this.txtBobPrivate.TabIndex = 2;
            // 
            // lblBobPrivate
            // 
            this.lblBobPrivate.AutoSize = true;
            this.lblBobPrivate.Location = new System.Drawing.Point(6, 26);
            this.lblBobPrivate.Name = "lblBobPrivate";
            this.lblBobPrivate.Size = new System.Drawing.Size(125, 20);
            this.lblBobPrivate.TabIndex = 1;
            this.lblBobPrivate.Text = "Закрытый ключ:";
            // 
            // btnGenerateBobKeys
            // 
            this.btnGenerateBobKeys.Location = new System.Drawing.Point(643, 22);
            this.btnGenerateBobKeys.Name = "btnGenerateBobKeys";
            this.btnGenerateBobKeys.Size = new System.Drawing.Size(127, 29);
            this.btnGenerateBobKeys.TabIndex = 0;
            this.btnGenerateBobKeys.Text = "Сгенерировать";
            this.btnGenerateBobKeys.UseVisualStyleBackColor = true;
            this.btnGenerateBobKeys.Click += new System.EventHandler(this.btnGenerateBobKeys_Click);
            // 
            // btnComputeSharedSecret
            // 
            this.btnComputeSharedSecret.Location = new System.Drawing.Point(12, 414);
            this.btnComputeSharedSecret.Name = "btnComputeSharedSecret";
            this.btnComputeSharedSecret.Size = new System.Drawing.Size(200, 29);
            this.btnComputeSharedSecret.TabIndex = 6;
            this.btnComputeSharedSecret.Text = "Вычислить общий секрет";
            this.btnComputeSharedSecret.UseVisualStyleBackColor = true;
            this.btnComputeSharedSecret.Click += new System.EventHandler(this.btnComputeSharedSecret_Click);
            // 
            // lblSecretMatch
            // 
            this.lblSecretMatch.AutoSize = true;
            this.lblSecretMatch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSecretMatch.Location = new System.Drawing.Point(218, 418);
            this.lblSecretMatch.Name = "lblSecretMatch";
            this.lblSecretMatch.Size = new System.Drawing.Size(0, 20);
            this.lblSecretMatch.TabIndex = 7;
            // 
            // DiffieHellmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSecretMatch);
            this.Controls.Add(this.btnComputeSharedSecret);
            this.Controls.Add(this.groupBoxBob);
            this.Controls.Add(this.groupBoxAlice);
            this.Controls.Add(this.groupBoxParameters);
            this.Controls.Add(this.btnGenerateParameters);
            this.Controls.Add(this.txtBitLength);
            this.Controls.Add(this.lblBitLength);
            this.Name = "DiffieHellmanForm";
            this.Text = "Алгоритм Диффи-Хеллмана";
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            this.groupBoxAlice.ResumeLayout(false);
            this.groupBoxAlice.PerformLayout();
            this.groupBoxBob.ResumeLayout(false);
            this.groupBoxBob.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBitLength;
        private System.Windows.Forms.TextBox txtBitLength;
        private System.Windows.Forms.Button btnGenerateParameters;
        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.TextBox txtBaseG;
        private System.Windows.Forms.Label lblBaseG;
        private System.Windows.Forms.TextBox txtPrimeP;
        private System.Windows.Forms.Label lblPrimeP;
        private System.Windows.Forms.GroupBox groupBoxAlice;
        private System.Windows.Forms.TextBox txtAliceSharedSecret;
        private System.Windows.Forms.Label lblAliceSharedSecret;
        private System.Windows.Forms.TextBox txtAlicePublic;
        private System.Windows.Forms.Label lblAlicePublic;
        private System.Windows.Forms.TextBox txtAlicePrivate;
        private System.Windows.Forms.Label lblAlicePrivate;
        private System.Windows.Forms.Button btnGenerateAliceKeys;
        private System.Windows.Forms.GroupBox groupBoxBob;
        private System.Windows.Forms.TextBox txtBobSharedSecret;
        private System.Windows.Forms.Label lblBobSharedSecret;
        private System.Windows.Forms.TextBox txtBobPublic;
        private System.Windows.Forms.Label lblBobPublic;
        private System.Windows.Forms.TextBox txtBobPrivate;
        private System.Windows.Forms.Label lblBobPrivate;
        private System.Windows.Forms.Button btnGenerateBobKeys;
        private System.Windows.Forms.Button btnComputeSharedSecret;
        private System.Windows.Forms.Label lblSecretMatch;
    }
}