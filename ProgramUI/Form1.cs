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
            var rsaForm = new RSAForm();
            rsaForm.ShowDialog();
        }

        private void btnDiffieHellman_Click(object sender, EventArgs e)
        {
            var dhForm = new DiffieHellmanForm();
            dhForm.ShowDialog();
        }

        private void btnHybridCrypto_Click(object sender, EventArgs e)
        {
            var hybridForm = new HybridCryptoForm();
            hybridForm.ShowDialog();
        }
    }
}
