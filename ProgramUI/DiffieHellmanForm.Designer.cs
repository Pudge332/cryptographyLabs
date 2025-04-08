namespace ProgramUI
{
    partial class DiffieHellmanForm
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
            this.btnGenerateParameters = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBaseG = new System.Windows.Forms.TextBox();
            this.txtPrimeP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAlicePublicKey = new System.Windows.Forms.TextBox();
            this.txtAlicePrivateKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBobPublicKey = new System.Windows.Forms.TextBox();
            this.txtBobPrivateKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGenerateKeys = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMatch = new System.Windows.Forms.TextBox();
            this.txtBobSecret = new System.Windows.Forms.TextBox();
            this.txtAliceSecret = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnComputeSecret = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            // btnGenerateParameters
            // 
            this.btnGenerateParameters.Location = new System.Drawing.Point(208, 11);
            this.btnGenerateParameters.Name = "btnGenerateParameters";
            this.btnGenerateParameters.Size = new System.Drawing.Size(150, 23);
            this.btnGenerateParameters.TabIndex = 2;
            this.btnGenerateParameters.Text = "Сгенерировать параметры";
            this.btnGenerateParameters.UseVisualStyleBackColor = true;
            this.btnGenerateParameters.Click += new System.EventHandler(this.btnGenerateParameters_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBaseG);
            this.groupBox1.Controls.Add(this.txtPrimeP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // txtBaseG
            // 
            this.txtBaseG.Location = new System.Drawing.Point(29, 51);
            this.txtBaseG.Name = "txtBaseG";
            this.txtBaseG.ReadOnly = true;
            this.txtBaseG.Size = new System.Drawing.Size(741, 23);
            this.txtBaseG.TabIndex = 3;
            // 
            // txtPrimeP
            // 
            this.txtPrimeP.Location = new System.Drawing.Point(29, 22);
            this.txtPrimeP.Name = "txtPrimeP";
            this.txtPrimeP.ReadOnly = true;
            this.txtPrimeP.Size = new System.Drawing.Size(741, 23);
            this.txtPrimeP.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "g:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "p:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAlicePublicKey);
            this.groupBox2.Controls.Add(this.txtAlicePrivateKey);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 85);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ключи Alice";
            // 
            // txtAlicePublicKey
            // 
            this.txtAlicePublicKey.Location = new System.Drawing.Point(90, 51);
            this.txtAlicePublicKey.Name = "txtAlicePublicKey";
            this.txtAlicePublicKey.ReadOnly = true;
            this.txtAlicePublicKey.Size = new System.Drawing.Size(680, 23);
            this.txtAlicePublicKey.TabIndex = 3;
            // 
            // txtAlicePrivateKey
            // 
            this.txtAlicePrivateKey.Location = new System.Drawing.Point(90, 22);
            this.txtAlicePrivateKey.Name = "txtAlicePrivateKey";
            this.txtAlicePrivateKey.ReadOnly = true;
            this.txtAlicePrivateKey.Size = new System.Drawing.Size(680, 23);
            this.txtAlicePrivateKey.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Публичный:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Приватный:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBobPublicKey);
            this.groupBox3.Controls.Add(this.txtBobPrivateKey);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 85);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ключи Bob";
            // 
            // txtBobPublicKey
            // 
            this.txtBobPublicKey.Location = new System.Drawing.Point(90, 51);
            this.txtBobPublicKey.Name = "txtBobPublicKey";
            this.txtBobPublicKey.ReadOnly = true;
            this.txtBobPublicKey.Size = new System.Drawing.Size(680, 23);
            this.txtBobPublicKey.TabIndex = 3;
            // 
            // txtBobPrivateKey
            // 
            this.txtBobPrivateKey.Location = new System.Drawing.Point(90, 22);
            this.txtBobPrivateKey.Name = "txtBobPrivateKey";
            this.txtBobPrivateKey.ReadOnly = true;
            this.txtBobPrivateKey.Size = new System.Drawing.Size(680, 23);
            this.txtBobPrivateKey.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Публичный:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Приватный:";
            // 
            // btnGenerateKeys
            // 
            this.btnGenerateKeys.Enabled = false;
            this.btnGenerateKeys.Location = new System.Drawing.Point(364, 11);
            this.btnGenerateKeys.Name = "btnGenerateKeys";
            this.btnGenerateKeys.Size = new System.Drawing.Size(150, 23);
            this.btnGenerateKeys.TabIndex = 6;
            this.btnGenerateKeys.Text = "Сгенерировать ключи";
            this.btnGenerateKeys.UseVisualStyleBackColor = true;
            this.btnGenerateKeys.Click += new System.EventHandler(this.btnGenerateKeys_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMatch);
            this.groupBox4.Controls.Add(this.txtBobSecret);
            this.groupBox4.Controls.Add(this.txtAliceSecret);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(12, 314);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(776, 124);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Общий секрет";
            // 
            // txtMatch
            // 
            this.txtMatch.Location = new System.Drawing.Point(90, 80);
            this.txtMatch.Name = "txtMatch";
            this.txtMatch.ReadOnly = true;
            this.txtMatch.Size = new System.Drawing.Size(680, 23);
            this.txtMatch.TabIndex = 5;
            // 
            // txtBobSecret
            // 
            this.txtBobSecret.Location = new System.Drawing.Point(90, 51);
            this.txtBobSecret.Name = "txtBobSecret";
            this.txtBobSecret.ReadOnly = true;
            this.txtBobSecret.Size = new System.Drawing.Size(680, 23);
            this.txtBobSecret.TabIndex = 4;
            // 
            // txtAliceSecret
            // 
            this.txtAliceSecret.Location = new System.Drawing.Point(90, 22);
            this.txtAliceSecret.Name = "txtAliceSecret";
            this.txtAliceSecret.ReadOnly = true;
            this.txtAliceSecret.Size = new System.Drawing.Size(680, 23);
            this.txtAliceSecret.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Совпадают:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Bob:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Alice:";
            // 
            // btnComputeSecret
            // 
            this.btnComputeSecret.Enabled = false;
            this.btnComputeSecret.Location = new System.Drawing.Point(520, 11);
            this.btnComputeSecret.Name = "btnComputeSecret";
            this.btnComputeSecret.Size = new System.Drawing.Size(150, 23);
            this.btnComputeSecret.TabIndex = 8;
            this.btnComputeSecret.Text = "Вычислить общий секрет";
            this.btnComputeSecret.UseVisualStyleBackColor = true;
            this.btnComputeSecret.Click += new System.EventHandler(this.btnComputeSecret_Click);
            // 
            // DiffieHellmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnComputeSecret);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnGenerateKeys);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGenerateParameters);
            this.Controls.Add(this.txtKeyLength);
            this.Controls.Add(this.label1);
            this.Name = "DiffieHellmanForm";
            this.Text = "Алгоритм Диффи-Хеллмана";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKeyLength;
        private System.Windows.Forms.Button btnGenerateParameters;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBaseG;
        private System.Windows.Forms.TextBox txtPrimeP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAlicePublicKey;
        private System.Windows.Forms.TextBox txtAlicePrivateKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBobPublicKey;
        private System.Windows.Forms.TextBox txtBobPrivateKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGenerateKeys;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMatch;
        private System.Windows.Forms.TextBox txtBobSecret;
        private System.Windows.Forms.TextBox txtAliceSecret;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnComputeSecret;
    }
}