using System.IO;

namespace Filer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var path = this.FPath.Text;
                DirectoryInfo root = new DirectoryInfo(path);
                DirectoryInfo[] directoryInfos = root.GetDirectories();
                if (level.Text == "2")
                {
                    foreach (DirectoryInfo directoryInfo in directoryInfos)
                    {
                        FileInfo[] files = directoryInfo.GetFiles();
                        foreach (FileInfo file in files)
                        {
                            var HouZhui = Path.GetExtension(file.FullName);
                            var newWenJianJia = file.FullName.Replace(HouZhui, "");
                            if (!Directory.Exists(newWenJianJia))
                            {
                                Directory.CreateDirectory(newWenJianJia);
                            }
                            file.MoveTo($@"{newWenJianJia}\{file.Name}");
                        }
                    }
                }
                if (level.Text == "1")
                {
                    FileInfo[] files = root.GetFiles();
                    foreach (FileInfo file in files)
                    {
                        var HouZhui = Path.GetExtension(file.FullName);
                        var newWenJianJia = file.FullName.Replace(HouZhui, "");
                        if (!Directory.Exists(newWenJianJia))
                        {
                            Directory.CreateDirectory(newWenJianJia);
                        }
                        file.MoveTo($@"{newWenJianJia}\{file.Name}");
                    }
                }
                this.OutPut.Text = "³É¹¦";

            }
            catch (Exception ex)
            {
                this.OutPut.Text = "Ê§°Ü\n" + ex;
            }


        }
    }
}