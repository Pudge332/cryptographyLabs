using System;
using System.Windows.Forms;

namespace ProgramUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRSA_Click(object sender, EventArgs e)
        {
            // Обработчик события для кнопки RSA
            RSAForm rsaForm = new RSAForm();
            rsaForm.Show();
        }

        private void btnDiffieHellman_Click(object sender, EventArgs e)
        {
            // Обработчик события для кнопки Diffie-Hellman
            DiffieHellmanForm diffieHellmanForm = new DiffieHellmanForm();
            diffieHellmanForm.Show();
        }

        private void btnHybridCrypto_Click(object sender, EventArgs e)
        {
            // Обработчик события для кнопки гибридной криптосистемы
            HybridCryptoForm hybridCryptoForm = new HybridCryptoForm();
            hybridCryptoForm.Show();
        }
    }
}