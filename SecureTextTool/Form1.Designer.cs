namespace SecureTextTool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            inputText = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            Methods = new ListBox();
            button1 = new Button();
            label3 = new Label();
            output_text = new RichTextBox();
            EncryptButton = new Button();
            removeButton = new Button();
            decryptButton = new Button();
            copyButton = new Button();
            copiedText = new Label();
            copiedTextTimer = new System.Windows.Forms.Timer(components);
            doDecryptReverseOrder = new CheckBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // inputText
            // 
            inputText.Location = new Point(12, 30);
            inputText.Name = "inputText";
            inputText.Size = new Size(207, 408);
            inputText.TabIndex = 0;
            inputText.Text = "";
            inputText.TextChanged += richTextBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "Input:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 9);
            label2.Name = "label2";
            label2.Size = new Size(168, 15);
            label2.TabIndex = 2;
            label2.Text = "Encryptions and Obfuscations:";
            // 
            // Methods
            // 
            Methods.FormattingEnabled = true;
            Methods.ItemHeight = 15;
            Methods.Location = new Point(245, 30);
            Methods.Name = "Methods";
            Methods.Size = new Size(235, 379);
            Methods.TabIndex = 3;
            Methods.SelectedIndexChanged += Methods_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(283, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Add...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(568, 9);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 6;
            label3.Text = "Output:";
            // 
            // output_text
            // 
            output_text.Location = new Point(568, 30);
            output_text.Name = "output_text";
            output_text.ReadOnly = true;
            output_text.Size = new Size(207, 379);
            output_text.TabIndex = 5;
            output_text.Text = "";
            // 
            // EncryptButton
            // 
            EncryptButton.Enabled = false;
            EncryptButton.Location = new Point(487, 191);
            EncryptButton.Name = "EncryptButton";
            EncryptButton.Size = new Size(75, 23);
            EncryptButton.TabIndex = 7;
            EncryptButton.Text = "Encrypt";
            EncryptButton.UseVisualStyleBackColor = true;
            EncryptButton.Click += EncryptButton_Click;
            // 
            // removeButton
            // 
            removeButton.Enabled = false;
            removeButton.Location = new Point(364, 415);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(75, 23);
            removeButton.TabIndex = 8;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // decryptButton
            // 
            decryptButton.Enabled = false;
            decryptButton.Location = new Point(487, 220);
            decryptButton.Name = "decryptButton";
            decryptButton.Size = new Size(75, 23);
            decryptButton.TabIndex = 9;
            decryptButton.Text = "Decrypt";
            decryptButton.UseVisualStyleBackColor = true;
            decryptButton.Click += decryptButton_Click;
            // 
            // copyButton
            // 
            copyButton.Enabled = false;
            copyButton.Location = new Point(568, 415);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(75, 23);
            copyButton.TabIndex = 10;
            copyButton.Text = "Copy";
            copyButton.UseVisualStyleBackColor = true;
            copyButton.Click += button2_Click;
            // 
            // copiedText
            // 
            copiedText.AutoSize = true;
            copiedText.ForeColor = Color.FromArgb(0, 192, 0);
            copiedText.Location = new Point(649, 419);
            copiedText.Name = "copiedText";
            copiedText.Size = new Size(48, 15);
            copiedText.TabIndex = 11;
            copiedText.Text = "Copied!";
            copiedText.Visible = false;
            // 
            // copiedTextTimer
            // 
            copiedTextTimer.Enabled = true;
            copiedTextTimer.Interval = 5000;
            copiedTextTimer.Tick += copiedTextTimer_Tick;
            // 
            // doDecryptReverseOrder
            // 
            doDecryptReverseOrder.AutoSize = true;
            doDecryptReverseOrder.Checked = true;
            doDecryptReverseOrder.CheckState = CheckState.Checked;
            doDecryptReverseOrder.Location = new Point(487, 249);
            doDecryptReverseOrder.Name = "doDecryptReverseOrder";
            doDecryptReverseOrder.Size = new Size(67, 64);
            doDecryptReverseOrder.TabIndex = 12;
            doDecryptReverseOrder.Text = "Decrypt\r\nin\r\nreverse\r\norder";
            doDecryptReverseOrder.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(703, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "About";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(doDecryptReverseOrder);
            Controls.Add(copiedText);
            Controls.Add(copyButton);
            Controls.Add(decryptButton);
            Controls.Add(removeButton);
            Controls.Add(EncryptButton);
            Controls.Add(label3);
            Controls.Add(output_text);
            Controls.Add(button1);
            Controls.Add(Methods);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inputText);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SecureTextTool";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox inputText;
        private Label label1;
        private Label label2;
        private ListBox Methods;
        private Button button1;
        private Label label3;
        private RichTextBox output_text;
        private Button EncryptButton;
        private Button removeButton;
        private Button decryptButton;
        private Button copyButton;
        private Label copiedText;
        private System.Windows.Forms.Timer copiedTextTimer;
        private CheckBox doDecryptReverseOrder;
        private Button button2;
    }
}
