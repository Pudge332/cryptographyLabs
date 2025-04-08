using System;
using System.IO;
using System.Windows.Forms;

namespace ProgramUI
{
    public partial class HybridCryptoForm : Form
    {
        private HybridCryptoSystem _sender;
        private HybridCryptoSystem _receiver;

        public HybridCryptoForm()
        {
            InitializeComponent();
            _sender = new HybridCryptoSystem();
            _receiver = new HybridCryptoSystem();
        }

        private void btnGenerateKeys_Click(object sender, EventArgs e)
        {
            int keySize = int.Parse(txtKeySize.Text);
            this._sender = new HybridCryptoSystem(keySize);
            this._sender.GenerateAndSaveKeys();
            txtPublicKey.Text = File.ReadAllText("public.key");
            txtPrivateKey.Text = File.ReadAllText("private.key");
            lblStatus.Text = "Ключи успешно сгенерированы";
        }

        private void btnEncryptAndSign_Click(object sender, EventArgs e)
        {
            try
            {
                string message = txtOriginalMessage.Text;
                _sender.EncryptAndSign(message);
                
                // Отображаем зашифрованное сообщение для наглядности
                if (File.Exists("data.enc"))
                {
                    byte[] encryptedData = File.ReadAllBytes("data.enc");
                    txtEncryptedMessage.Text = Convert.ToBase64String(encryptedData);
                }
                
                lblStatus.Text = "Сообщение зашифровано и подписано";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при шифровании: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecryptAndVerify_Click(object sender, EventArgs e)
        {
            try
            {
                _receiver.ImportPrivateKey();
                string decryptedMessage = _receiver.DecryptAndVerify();
                txtDecryptedMessage.Text = decryptedMessage;
                lblStatus.Text = "Сообщение расшифровано и подпись проверена";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при расшифровке: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}