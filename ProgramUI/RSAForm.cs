using System;
using System.Numerics;
using System.Windows.Forms;

namespace ProgramUI
{
    public partial class RSAForm : Form
    {
        private RSA _rsa;

        public RSAForm()
        {
            InitializeComponent();
            _rsa = new RSA();
        }

        private void btnGenerateKeys_Click(object sender, EventArgs e)
        {
            try
            {
                int keySize = int.Parse(txtKeySize.Text);
                _rsa.GenerateKeys(keySize);

                txtPublicE.Text = _rsa.PublicKeyE.ToString();
                txtPublicN.Text = _rsa.PublicKeyN.ToString();
                txtPrivateD.Text = _rsa.PrivateKeyD.ToString();
                txtPrivateP.Text = _rsa.PrivateKeyP.ToString();
                txtPrivateQ.Text = _rsa.PrivateKeyQ.ToString();

                MessageBox.Show("Ключи успешно сгенерированы", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (string.IsNullOrEmpty(txtPublicE.Text) || string.IsNullOrEmpty(txtPublicN.Text))
                {
                    MessageBox.Show("Сначала сгенерируйте ключи", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                BigInteger message = BigInteger.Parse(txtPlaintext.Text);
                BigInteger ciphertext = _rsa.Encrypt(message);
                txtCiphertext.Text = ciphertext.ToString();
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
                if (string.IsNullOrEmpty(txtPrivateD.Text) || string.IsNullOrEmpty(txtPrivateP.Text) || string.IsNullOrEmpty(txtPrivateQ.Text))
                {
                    MessageBox.Show("Сначала сгенерируйте ключи", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                BigInteger ciphertext = BigInteger.Parse(txtCiphertext.Text);
                BigInteger decrypted = _rsa.Decrypt(ciphertext);
                txtDecrypted.Text = decrypted.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при дешифровании: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}