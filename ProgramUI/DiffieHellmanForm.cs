using System.Numerics;

namespace ProgramUI
{
    public partial class DiffieHellmanForm : Form
    {
        private DiffieHellman alice;
        private DiffieHellman bob;

        public DiffieHellmanForm()
        {
            InitializeComponent();
            alice = new DiffieHellman();
            bob = new DiffieHellman();
        }

        private void btnGenerateParameters_Click(object sender, EventArgs e)
        {
            try
            {
                int keyLength = int.Parse(txtKeyLength.Text);
                alice.GenerateParameters(keyLength);
                txtPrimeP.Text = alice.PrimeP.ToString();
                txtBaseG.Text = alice.BaseG.ToString();

                // Установка общих параметров для Bob
                bob.PrimeP = alice.PrimeP;
                bob.BaseG = alice.BaseG;

                btnGenerateKeys.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при генерации параметров: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerateKeys_Click(object sender, EventArgs e)
        {
            try
            {
                // Генерация ключей для Alice
                alice.GenerateKeys();
                txtAlicePrivateKey.Text = alice.PrivateKeyX.ToString();
                txtAlicePublicKey.Text = alice.PublicKeyY.ToString();

                // Генерация ключей для Bob
                bob.GenerateKeys();
                txtBobPrivateKey.Text = bob.PrivateKeyX.ToString();
                txtBobPublicKey.Text = bob.PublicKeyY.ToString();

                btnComputeSecret.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при генерации ключей: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnComputeSecret_Click(object sender, EventArgs e)
        {
            try
            {
                // Вычисление общего секрета
                BigInteger aliceSecret = alice.ComputeSharedSecret(bob.PublicKeyY);
                BigInteger bobSecret = bob.ComputeSharedSecret(alice.PublicKeyY);

                txtAliceSecret.Text = aliceSecret.ToString();
                txtBobSecret.Text = bobSecret.ToString();
                txtMatch.Text = (aliceSecret == bobSecret) ? "Да" : "Нет";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при вычислении общего секрета: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}