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
            ExportCsvBtn = new Button();
            ExportJsonBtn = new Button();
            ObjectsCountBtn = new Button();
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
            richTextBox1.Location = new Point(228, 63);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(331, 233);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // ExportCsvBtn
            // 
            ExportCsvBtn.Location = new Point(313, 341);
            ExportCsvBtn.Name = "ExportCsvBtn";
            ExportCsvBtn.Size = new Size(130, 23);
            ExportCsvBtn.TabIndex = 3;
            ExportCsvBtn.Text = "Export as CSV";
            ExportCsvBtn.UseVisualStyleBackColor = true;
            ExportCsvBtn.Click += ExportCsvBtn_Click;
            // 
            // ExportJsonBtn
            // 
            ExportJsonBtn.Location = new Point(553, 341);
            ExportJsonBtn.Name = "ExportJsonBtn";
            ExportJsonBtn.Size = new Size(119, 23);
            ExportJsonBtn.TabIndex = 4;
            ExportJsonBtn.Text = "Export as JSON";
            ExportJsonBtn.UseVisualStyleBackColor = true;
            ExportJsonBtn.Click += ExportJsonBtn_Click;
            // 
            // ObjectsCountBtn
            // 
            ObjectsCountBtn.Location = new Point(313, 399);
            ObjectsCountBtn.Name = "ObjectsCountBtn";
            ObjectsCountBtn.Size = new Size(130, 23);
            ObjectsCountBtn.TabIndex = 5;
            ObjectsCountBtn.Text = "Total Count";
            ObjectsCountBtn.UseVisualStyleBackColor = true;
            ObjectsCountBtn.Click += ObjectsCountBtn_Click;
            // 
            // FileManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ObjectsCountBtn);
            Controls.Add(ExportJsonBtn);
            Controls.Add(ExportCsvBtn);
            Controls.Add(richTextBox1);
            Controls.Add(ChooseFileBtn);
            Name = "FileManagementForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button ChooseFileBtn;
        private RichTextBox richTextBox1;
        private Button ExportCsvBtn;
        private Button ExportJsonBtn;
        private Button ObjectsCountBtn;
    }
}
