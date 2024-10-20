namespace JermaineJacksonA6
{
    partial class FileManagementForm
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
            ChooseFileBtn = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // ChooseFileBtn
            // 
            ChooseFileBtn.Location = new Point(73, 341);
            ChooseFileBtn.Name = "ChooseFileBtn";
            ChooseFileBtn.Size = new Size(116, 23);
            ChooseFileBtn.TabIndex = 0;
            ChooseFileBtn.Text = "Choose File";
            ChooseFileBtn.UseVisualStyleBackColor = true;
            ChooseFileBtn.Click += ChooseFileBtn_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(73, 49);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(331, 233);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // FileManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(ChooseFileBtn);
            Name = "FileManagementForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button ChooseFileBtn;
        private RichTextBox richTextBox1;
    }
}
