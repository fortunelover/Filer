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
            level = new TextBox();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // FPath
            // 
            FPath.Location = new Point(98, 51);
            FPath.Name = "FPath";
            FPath.Size = new Size(687, 23);
            FPath.TabIndex = 0;
            FPath.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 49);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 1;
            label1.Text = "路径：";
            // 
            // File2Folder
            // 
            File2Folder.Location = new Point(23, 140);
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
            label3.Location = new Point(23, 187);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 4;
            label3.Text = "输出：";
            // 
            // level
            // 
            level.Location = new Point(98, 90);
            level.Name = "level";
            level.Size = new Size(50, 23);
            level.TabIndex = 5;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(98, 187);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(687, 251);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 90);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 7;
            label2.Text = "层数：";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(level);
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
        private TextBox level;
        private RichTextBox richTextBox1;
        private Label label2;
    }
}