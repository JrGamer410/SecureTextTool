using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SecureTextTool
{
    public partial class AddDialog : Form
    {
        public string SelectedMethod => Method.SelectedItem?.ToString();
        public string obfusactionkey => obfuKey.Text;
        public AddDialog()
        {
            InitializeComponent();
        }

        private void Method_SelectedIndexChanged(object sender, EventArgs e)
        {
            noKeyError.SetError(obfuKey, "");
            obfukeytext.Visible = false;
            obfuKey.Visible = false;
            addButton.Enabled = true;
            if (Method.Text == "Vigenere Cipher")
            {
                obfuKey.Visible = true;
                obfukeytext.Visible = true;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (Method.Text == "Vigenere Cipher")
            {
                if (string.IsNullOrWhiteSpace(obfuKey.Text))
                {
                    noKeyError.SetError(obfuKey, "This field is required.");
                }
                else
                {
                    noKeyError.SetError(obfuKey, ""); // Clear the error
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
