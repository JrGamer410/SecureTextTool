using System.Buffers.Text;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SecureTextTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const string Charset = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789 !@#$%^&*()-_=+[]{}|;:'\",.<>?/\\`~";


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (inputText.Text == "")
            {
                EncryptButton.Enabled = false;
                decryptButton.Enabled = false;
            }
            else
            {
                EncryptButton.Enabled = true;
                if (Methods.Items.Count > 0)
                {
                    decryptButton.Enabled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var dialog = new AddDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedMethod = dialog.SelectedMethod;
                    string obfumethod = dialog.obfusactionkey;
                    if (selectedMethod == "Vigenere Cipher")
                    {
                        selectedMethod = selectedMethod + " (" + obfumethod + ")";
                    }
                    Methods.Items.Add(selectedMethod);
                    if (inputText.Text != "")
                    {
                        decryptButton.Enabled = true;
                    }
                }
            }
        }

        private void Methods_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeButton.Enabled = true;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Methods.Items.Remove(Methods.SelectedItem);
            if (Methods.Items.Count == 0)
            {
                removeButton.Enabled = false;
            }
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            string text = inputText.Text;
            foreach (var item in Methods.Items)
            {
                // Here we iterate through the list and preform the requested obfuscation and encrypted actions with any parameters.
                string line = item.ToString();
                if (line.StartsWith("Vigenere Cipher"))
                {
                    Match match = Regex.Match(line, @"\((.*?)\)");
                    if (match.Success)
                    {
                        string insideParens = match.Groups[1].Value;
                        text = VigenereFull(text, insideParens);
                    }
                }
                else if (line == "base64")
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(text);
                    text = Convert.ToBase64String(bytes);
                }
            }
            output_text.Text = text;
            copyButton.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(output_text.Text);
            copiedText.Visible = true;
            copiedTextTimer.Start();
        }

        private void copiedTextTimer_Tick(object sender, EventArgs e)
        {
            copiedText.Visible = false;
            copiedTextTimer.Stop();
        }

        private void output_text_TextChanged(object sender, EventArgs e)
        {
            copyButton.Enabled = true;
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            string text = inputText.Text;
            // Here we check if the user wants us to iterate through the list in reverse or in order (like for encryption).
            if (doDecryptReverseOrder.Checked)
            {
                for (int i = Methods.Items.Count - 1; i >= 0; i--)
                {
                    var item = Methods.Items[i];
                    string line = item.ToString();
                    if (line == "base64")
                    {
                        try
                        {
                            byte[] decodedBytes = Convert.FromBase64String(text);
                            text = Encoding.UTF8.GetString(decodedBytes);
                        }
                        catch (Exception ex)
                        {
                            // Error handler for if something goes wrong (e.g. non base64 code passed to the decode function.)
                            MessageBox.Show("An error occurred whilst trying to decode base64: " + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else if (line.StartsWith("Vigenere Cipher"))
                    {
                        Match match = Regex.Match(line, @"\((.*?)\)");
                        if (match.Success)
                        {
                            string insideParens = match.Groups[1].Value;
                            text = VigenereFull(text, insideParens, true);
                        }
                    }
                }
            }
            else
            {
                foreach (var item in Methods.Items)
                {
                    string line = item.ToString();
                    if (line == "base64")
                    {
                        try
                        {
                            byte[] decodedBytes = Convert.FromBase64String(text);
                            text = Encoding.UTF8.GetString(decodedBytes);
                        }
                        catch (Exception ex)
                        {
                            // Error handler for if something goes wrong (e.g. non base64 code passed to the decode function.)
                            MessageBox.Show("An error occurred whilst trying to decode base64: " + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else if (line.StartsWith("Vigenere Cipher"))
                    {
                        Match match = Regex.Match(line, @"\((.*?)\)");
                        if (match.Success)
                        {
                            string insideParens = match.Groups[1].Value;
                            text = VigenereFull(text, insideParens, true);
                        }
                    }
                }
            }




            // Here we output our final result and allow the user to copy it with the "Copy" button.
            output_text.Text = text;
            copyButton.Enabled = true;
        }
        string VigenereFull(string input, string key, bool decrypt = false)
        {
            // Note: Written by ChatGPT, due to not knowing how best to and not really willing to try to find it.
            StringBuilder result = new StringBuilder();
            int keyIndex = 0;

            foreach (char c in input)
            {
                int charPos = Charset.IndexOf(c);
                if (charPos == -1)
                {
                    // Character not in the charset, leave as-is
                    result.Append(c);
                    continue;
                }

                char keyChar = key[keyIndex % key.Length];
                int keyPos = Charset.IndexOf(keyChar);

                if (keyPos == -1)
                {
                    // Invalid key character, default to no shift
                    keyPos = 0;
                }

                int shift = decrypt
                    ? (charPos - keyPos + Charset.Length) % Charset.Length
                    : (charPos + keyPos) % Charset.Length;

                result.Append(Charset[shift]);
                keyIndex++;
            }

            return result.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("SecureTextTool v1.0\nBy Sean-e/JrGamer410\nhttps://sean-e.xyz", "About SecureTextTool", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
