using System;
using System.Numerics;
using System.Windows.Forms;

namespace ProgramUI
{
    public partial class DiffieHellmanForm : Form
    {
        private DiffieHellman _aliceInstance;
        private DiffieHellman _bobInstance;

        public DiffieHellmanForm()
        {
            InitializeComponent();
            _aliceInstance = new DiffieHellman();
            _bobInstance = new DiffieHellman();
        }

        private void btnGenerateParameters_Click(object sender, EventArgs e)
        {
            try
            {
                int bitLength = int.Parse(txtBitLength.Text);
                _aliceInstance.GenerateParameters(bitLength);

                // Передаем параметры Бобу
                _bobInstance.PrimeP = _aliceInstance.PrimeP;
                _bobInstance.BaseG = _aliceInstance.BaseG;

                txtPrimeP.Text = _aliceInstance.PrimeP.ToString();
                txtBaseG.Text = _aliceInstance.BaseG.ToString();

                MessageBox.Show("Параметры успешно сгенерированы", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при генерации параметров: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerateAliceKeys_Click(object sender, EventArgs e)
        {
            try
            {
                if (_aliceInstance.PrimeP == 0 || _aliceInstance.BaseG == 0)
                {
                    MessageBox.Show("Сначала сгенерируйте параметры", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _aliceInstance.GenerateKeys();
                txtAlicePrivate.Text = _aliceInstance.PrivateKeyX.ToString();
                txtAlicePublic.Text = _aliceInstance.PublicKeyY.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при генерации ключей Алисы: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerateBobKeys_Click(object sender, EventArgs e)
        {
            try
            {
                if (_bobInstance.PrimeP == 0 || _bobInstance.BaseG == 0)
                {
                    MessageBox.Show("Сначала сгенерируйте параметры", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _bobInstance.GenerateKeys();
                txtBobPrivate.Text = _bobInstance.PrivateKeyX.ToString();
                txtBobPublic.Text = _bobInstance.PublicKeyY.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при генерации ключей Боба: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnComputeSharedSecret_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAlicePublic.Text) || string.IsNullOrEmpty(txtBobPublic.Text))
                {
                    MessageBox.Show("Сначала сгенерируйте ключи для обоих участников", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                BigInteger bobPublicKey = BigInteger.Parse(txtBobPublic.Text);
                BigInteger alicePublicKey = BigInteger.Parse(txtAlicePublic.Text);

                BigInteger aliceSecret = _aliceInstance.ComputeSharedSecret(bobPublicKey);
                BigInteger bobSecret = _bobInstance.ComputeSharedSecret(alicePublicKey);

                txtAliceSharedSecret.Text = aliceSecret.ToString();
                txtBobSharedSecret.Text = bobSecret.ToString();

                if (aliceSecret == bobSecret)
                {
                    lblSecretMatch.Text = "Секреты совпадают: ДА";
                    lblSecretMatch.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblSecretMatch.Text = "Секреты совпадают: НЕТ";
                    lblSecretMatch.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при вычислении общего секрета: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}