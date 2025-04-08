using System;
using System.Numerics;
using System.Windows.Forms;

namespace ProgramUI
{
    public partial class RSAForm : Form
    {
        private RSA rsa;

        public RSAForm()
        {
            InitializeComponent();
            rsa = new RSA();
        }

        private void btnGenerateKeys_Click(object sender, EventArgs e)
        {
            try
            {
                int keyLength = int.Parse(txtKeyLength.Text);
                rsa.GenerateKeys(keyLength);

                txtPublicKeyE.Text = rsa.PublicKeyE.ToString();
                txtPublicKeyN.Text = rsa.PublicKeyN.ToString();
                txtPrivateKeyD.Text = rsa.PrivateKeyD.ToString();
                txtPrivateKeyP.Text = rsa.PrivateKeyP.ToString();
                txtPrivateKeyQ.Text = rsa.PrivateKeyQ.ToString();

                btnEncrypt.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при генерации ключей: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                BigInteger message = BigInteger.Parse(txtMessage.Text);
                BigInteger ciphertext = rsa.Encrypt(message);
                txtCiphertext.Text = ciphertext.ToString();
                btnDecrypt.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при шифровании: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                BigInteger ciphertext = BigInteger.Parse(txtCiphertext.Text);
                BigInteger decrypted = rsa.Decrypt(ciphertext);
                txtDecrypted.Text = decrypted.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при дешифровании: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}