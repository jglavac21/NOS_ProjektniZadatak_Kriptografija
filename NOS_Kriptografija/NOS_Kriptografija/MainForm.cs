using NOS_Kriptografija.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOS_Kriptografija
{
    public partial class MainForm : Form
    {
        private readonly CryptoService _crypto = new CryptoService();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBrowseSymKey_Click(object sender, EventArgs e)
        {
            using (var save = new SaveFileDialog())
            {
                save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                save.FileName = "tajni_kljuc.txt";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    txtSymKeyPath.Text = save.FileName;
                }
            }
        }

        private void btnGenerateSymKey_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSymKeyPath.Text))
                {
                    MessageBox.Show("Odaberite datoteku za spremanje tajnog ključa.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _crypto.GenerateSymmetricKey(txtSymKeyPath.Text);

                MessageBox.Show("Tajni AES ključ uspješno generiran.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri generiranju simetričnog ključa:\n" + ex.Message,
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowsePublicKey_Click(object sender, EventArgs e)
        {
            using (var save = new SaveFileDialog())
            {
                save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                save.FileName = "javni_kljuc.txt";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    txtPublicKeyPath.Text = save.FileName;
                }
            }
        }

        private void btnBrowsePrivateKey_Click(object sender, EventArgs e)
        {
            using (var save = new SaveFileDialog())
            {
                save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                save.FileName = "privatni_kljuc.txt";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    txtPrivateKeyPath.Text = save.FileName;
                }
            }
        }

        private void btnGenerateAsymKeys_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPublicKeyPath.Text) ||
                    string.IsNullOrWhiteSpace(txtPrivateKeyPath.Text))
                {
                    MessageBox.Show("Odaberite datoteke za javni i privatni ključ.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _crypto.GenerateAsymmetricKeys(txtPublicKeyPath.Text, txtPrivateKeyPath.Text);

                MessageBox.Show("RSA ključevi uspješno generirani.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri generiranju RSA ključeva:\n" + ex.Message,
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSymBrowseInput_Click(object sender, EventArgs e)
        {
            using (var open = new OpenFileDialog())
            {
                open.Filter = "All files (*.*)|*.*";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    txtSymInputFile.Text = open.FileName;
                }
            }
        }

        private void btnSymBrowseOutput_Click(object sender, EventArgs e)
        {
            using (var save = new SaveFileDialog())
            {
                save.Filter = "Encrypted files (*.enc)|*.enc|Text files (*.txt)|*.txt|All files (*.*)|*.*";
                save.FileName = "kriptirano_simetricno.enc";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    txtSymOutputFile.Text = save.FileName;
                }
            }
        }

        private void btnSymBrowseKey_Click(object sender, EventArgs e)
        {
            using (var open = new OpenFileDialog())
            {
                open.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    txtSymKeyPath_Sym.Text = open.FileName;
                }
            }
        }

        private void btnSymEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSymInputFile.Text) ||
                    string.IsNullOrWhiteSpace(txtSymOutputFile.Text) ||
                    string.IsNullOrWhiteSpace(txtSymKeyPath_Sym.Text))
                {
                    MessageBox.Show("Odaberite ulaznu datoteku, izlaznu datoteku i tajni ključ.",
                        "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _crypto.EncryptSymmetric(txtSymInputFile.Text,
                                         txtSymOutputFile.Text,
                                         txtSymKeyPath_Sym.Text);

                MessageBox.Show("Datoteka je uspješno kriptirana (AES).", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri simetričnom kriptiranju:\n" + ex.Message,
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSymDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSymInputFile.Text) ||
                    string.IsNullOrWhiteSpace(txtSymOutputFile.Text) ||
                    string.IsNullOrWhiteSpace(txtSymKeyPath_Sym.Text))
                {
                    MessageBox.Show("Odaberite ulaznu datoteku, izlaznu datoteku i tajni ključ.",
                        "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _crypto.DecryptSymmetric(txtSymInputFile.Text,
                                         txtSymOutputFile.Text,
                                         txtSymKeyPath_Sym.Text);

                MessageBox.Show("Datoteka je uspješno dekriptirana (AES).", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri simetričnom dekriptiranju:\n" + ex.Message,
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHybridBrowseInput_Click(object sender, EventArgs e)
        {
            using (var open = new OpenFileDialog())
            {
                open.Filter = "All files (*.*)|*.*";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    txtHybridInputFile.Text = open.FileName;
                }
            }
        }

        private void btnHybridBrowseOutput_Click(object sender, EventArgs e)
        {
            using (var save = new SaveFileDialog())
            {
                save.Filter = "Encrypted files (*.enc)|*.enc|Text files (*.txt)|*.txt|All files (*.*)|*.*";
                save.FileName = "kriptirano_asimetricno.enc";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    txtHybridOutputFile.Text = save.FileName;
                }
            }
        }

        private void btnHybridBrowsePublicKey_Click(object sender, EventArgs e)
        {
            using (var open = new OpenFileDialog())
            {
                open.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    txtHybridPublicKey.Text = open.FileName;
                }
            }
        }

        private void btnHybridBrowsePrivateKey_Click(object sender, EventArgs e)
        {
            using (var open = new OpenFileDialog())
            {
                open.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    txtHybridPrivateKey.Text = open.FileName;
                }
            }
        }

        private void btnHybridEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtHybridInputFile.Text) ||
                    string.IsNullOrWhiteSpace(txtHybridOutputFile.Text) ||
                    string.IsNullOrWhiteSpace(txtHybridPublicKey.Text))
                {
                    MessageBox.Show("Odaberite ulaznu datoteku, izlaznu datoteku i javni RSA ključ.",
                        "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _crypto.EncryptAsymmetricHybrid(
                    txtHybridInputFile.Text,
                    txtHybridOutputFile.Text,
                    txtHybridPublicKey.Text);

                MessageBox.Show("Datoteka je uspješno kriptirana (RSA + AES).", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri hibridnom kriptiranju:\n" + ex.Message,
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHybridDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtHybridInputFile.Text) ||
                    string.IsNullOrWhiteSpace(txtHybridOutputFile.Text) ||
                    string.IsNullOrWhiteSpace(txtHybridPrivateKey.Text))
                {
                    MessageBox.Show("Odaberite ulaznu datoteku, izlaznu datoteku i privatni RSA ključ.",
                        "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _crypto.DecryptAsymmetricHybrid(
                    txtHybridInputFile.Text,
                    txtHybridOutputFile.Text,
                    txtHybridPrivateKey.Text);

                MessageBox.Show("Datoteka je uspješno dekriptirana (RSA + AES).", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri hibridnom dekriptiranju:\n" + ex.Message,
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHashBrowseInput_Click(object sender, EventArgs e)
        {
            using (var open = new OpenFileDialog())
            {
                open.Filter = "All files (*.*)|*.*";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    txtHashInputFile.Text = open.FileName;
                }
            }
        }

        private void btnHashBrowseOutput_Click(object sender, EventArgs e)
        {
            using (var save = new SaveFileDialog())
            {
                save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                save.FileName = "datoteka.hash";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    txtHashOutputFile.Text = save.FileName;
                }
            }
        }

        private void btnComputeHash_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtHashInputFile.Text) ||
                    string.IsNullOrWhiteSpace(txtHashOutputFile.Text))
                {
                    MessageBox.Show("Odaberite ulaznu datoteku i datoteku za spremanje hash vrijednosti.",
                        "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _crypto.ComputeHash(txtHashInputFile.Text, txtHashOutputFile.Text);

                if (File.Exists(txtHashOutputFile.Text))
                {
                    string hashHex = File.ReadAllText(txtHashOutputFile.Text);
                    txtHashValue.Text = hashHex;
                }

                MessageBox.Show("Hash (SHA-256) je uspješno izračunat.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri izračunu hasha:\n" + ex.Message,
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignBrowseInput_Click(object sender, EventArgs e)
        {
            using (var open = new OpenFileDialog())
            {
                open.Filter = "All files (*.*)|*.*";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    txtSignInput.Text = open.FileName;
                }
            }
        }

        private void btnSignBrowsePrivateKey_Click(object sender, EventArgs e)
        {
            using (var open = new OpenFileDialog())
            {
                open.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    txtSignPrivateKey.Text = open.FileName;
                }
            }
        }

        private void btnSignBrowseOutput_Click(object sender, EventArgs e)
        {
            using (var save = new SaveFileDialog())
            {
                save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                save.FileName = "signature.txt";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    txtSignOutput.Text = save.FileName;
                }
            }
        }

        private void btnSignFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSignInput.Text) ||
                    string.IsNullOrWhiteSpace(txtSignPrivateKey.Text) ||
                    string.IsNullOrWhiteSpace(txtSignOutput.Text))
                {
                    MessageBox.Show("Odaberite ulaznu datoteku, privatni ključ i izlaznu datoteku za potpis.",
                        "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _crypto.SignFile(
                    txtSignInput.Text,
                    txtSignPrivateKey.Text,
                    txtSignOutput.Text
                );

                MessageBox.Show("Datoteka je uspješno potpisana.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri potpisivanju:\n" + ex.Message,
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerifyBrowseInput_Click(object sender, EventArgs e)
        {
            using (var open = new OpenFileDialog())
            {
                open.Filter = "All files (*.*)|*.*";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    txtVerifyInput.Text = open.FileName;
                }
            }
        }

        private void btnVerifyBrowsePublicKey_Click(object sender, EventArgs e)
        {
            using (var open = new OpenFileDialog())
            {
                open.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    txtVerifyPublicKey.Text = open.FileName;
                }
            }
        }

        private void btnVerifyBrowseSignature_Click(object sender, EventArgs e)
        {
            using (var open = new OpenFileDialog())
            {
                open.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    txtVerifySignature.Text = open.FileName;
                }
            }
        }

        private void btnVerifySignatureFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtVerifyInput.Text) ||
                    string.IsNullOrWhiteSpace(txtVerifyPublicKey.Text) ||
                    string.IsNullOrWhiteSpace(txtVerifySignature.Text))
                {
                    MessageBox.Show("Odaberite originalnu datoteku, javni ključ i datoteku potpisa.",
                        "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool valid = _crypto.VerifySignature(
                    txtVerifyInput.Text,
                    txtVerifyPublicKey.Text,
                    txtVerifySignature.Text
                );

                if (valid)
                    MessageBox.Show("Potpis je valjan.", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Potpis NIJE valjan!", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri provjeri potpisa:\n" + ex.Message,
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}