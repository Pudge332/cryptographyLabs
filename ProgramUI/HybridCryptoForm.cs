using System;
using System.Windows.Forms;

namespace ProgramUI
{
    public partial class HybridCryptoForm : Form
    {
        private HybridCryptoSystem sender;
        private HybridCryptoSystem receiver;

        public HybridCryptoForm()
        {
            InitializeComponent();
            sender = new HybridCryptoSystem();
            receiver = new HybridCryptoSystem();
        }

        private void btnGenerateKeys_Click(object sender, EventArgs e)
        {
            try
            {
                int keySize = int.Parse(txtKeySize.Text);
                this.sender = new HybridCryptoSystem(keySize);
                this.sender.GenerateAndSaveKeys();
                lblKeysStatus.Text = "Ключи успешно сгенерированы";
                btnEncryptAndSign.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при генерации ключей: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEncryptAndSign_Click(object sender, EventArgs e)
        {
            try
            {
                string message = txtMessage.Text;
                if (string.IsNullOrEmpty(message))
                {
                    MessageBox.Show("Введите сообщение для шифрования", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                this.sender.EncryptAndSign(message);
                lblEncryptStatus.Text = "Сообщение зашифровано и подписано";
                btnDecryptAndVerify.Enabled = true;
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
                receiver.ImportPrivateKey();
                string result = receiver.DecryptAndVerify();
                txtDecrypted.Text = result;
                lblVerifyStatus.Text = "Подпись проверена успешно";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при дешифровании: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblVerifyStatus.Text = "Ошибка проверки подписи";
            }
        }
    }
}