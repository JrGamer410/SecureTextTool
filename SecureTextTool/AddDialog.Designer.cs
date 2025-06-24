namespace SecureTextTool
{
    partial class AddDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            Method = new ComboBox();
            button1 = new Button();
            addButton = new Button();
            obfukeytext = new Label();
            obfuKey = new TextBox();
            noKeyError = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)noKeyError).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 20);
            label1.Name = "label1";
            label1.Size = new Size(348, 15);
            label1.TabIndex = 0;
            label1.Text = "Choose an encryption or obfuscation to add, and then click Add.";
            // 
            // Method
            // 
            Method.DropDownStyle = ComboBoxStyle.DropDownList;
            Method.FormattingEnabled = true;
            Method.Items.AddRange(new object[] { "base64", "Vigenere Cipher" });
            Method.Location = new Point(26, 63);
            Method.Name = "Method";
            Method.Size = new Size(348, 23);
            Method.TabIndex = 1;
            Method.SelectedIndexChanged += Method_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(299, 148);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // addButton
            // 
            addButton.Enabled = false;
            addButton.Location = new Point(218, 148);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 3;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // obfukeytext
            // 
            obfukeytext.AutoSize = true;
            obfukeytext.Location = new Point(26, 89);
            obfukeytext.Name = "obfukeytext";
            obfukeytext.Size = new Size(29, 15);
            obfukeytext.TabIndex = 4;
            obfukeytext.Text = "Key:";
            obfukeytext.Visible = false;
            // 
            // obfuKey
            // 
            obfuKey.Location = new Point(26, 107);
            obfuKey.Name = "obfuKey";
            obfuKey.Size = new Size(348, 23);
            obfuKey.TabIndex = 5;
            obfuKey.Visible = false;
            // 
            // noKeyError
            // 
            noKeyError.ContainerControl = this;
            // 
            // AddDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 183);
            Controls.Add(obfuKey);
            Controls.Add(obfukeytext);
            Controls.Add(addButton);
            Controls.Add(button1);
            Controls.Add(Method);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            HelpButton = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add...";
            ((System.ComponentModel.ISupportInitialize)noKeyError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox Method;
        private Button button1;
        private Button addButton;
        private Label obfukeytext;
        private TextBox obfuKey;
        private ErrorProvider noKeyError;
    }
}