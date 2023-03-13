namespace Filer
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
            FPath = new TextBox();
            label1 = new Label();
            File2Folder = new Button();
            OutPut = new Label();
            label3 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // FPath
            // 
            FPath.Location = new Point(62, 51);
            FPath.Name = "FPath";
            FPath.Size = new Size(687, 23);
            FPath.TabIndex = 0;
            FPath.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 54);
            label1.Name = "label1";
            label1.Size = new Size(33, 17);
            label1.TabIndex = 1;
            label1.Text = "Path";
            // 
            // File2Folder
            // 
            File2Folder.Location = new Point(23, 107);
            File2Folder.Name = "File2Folder";
            File2Folder.Size = new Size(102, 27);
            File2Folder.TabIndex = 2;
            File2Folder.Text = "文件->文件夹";
            File2Folder.UseVisualStyleBackColor = true;
            File2Folder.Click += button1_Click;
            // 
            // OutPut
            // 
            OutPut.AutoSize = true;
            OutPut.Location = new Point(80, 195);
            OutPut.Name = "OutPut";
            OutPut.Size = new Size(0, 17);
            OutPut.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(4, 193);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 4;
            label3.Text = "输出：";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(OutPut);
            Controls.Add(File2Folder);
            Controls.Add(label1);
            Controls.Add(FPath);
            Name = "Form1";
            Text = "Filer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button File2Folder;
        private Label OutPut;
        private TextBox FPath;


        private Label label1;

        private Label label3;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}