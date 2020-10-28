using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ISPRToolsApp
{
    public partial class FrmExtractCode : Form
    {
        public FrmExtractCode()
        {
            InitializeComponent();
            txtFolderPath.Text = Tools.CodeFolder();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var path = txtFolderPath.Text.Trim();
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("请选择项目文件夹目录");
            }
            var list = textBox1.Text;
            if (string.IsNullOrEmpty(list))
            {
                MessageBox.Show("请输入要提交的文件列表");
            }
            string foldPath = Tools.ExportFolder();
            DeleteFilesAndFolders(foldPath);
            using (StringReader sr = new StringReader(list))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var destFileName = Path.Combine(foldPath, line);
                    var dir = new DirectoryInfo(destFileName).Parent;
                    if (!dir.Exists)
                    {
                        dir.Create();
                    }
                    File.Copy(Path.Combine(path, line), destFileName);
                }
            }
            MessageBox.Show("导出成功!");

        }

        private void DeleteFilesAndFolders(string path)
        {
            // Delete files.
            string[] files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                File.Delete(file);
            }

            // Delete folders.
            string[] folders = Directory.GetDirectories(path);
            foreach (var folder in folders)
            {
                DeleteFilesAndFolders(folder);
                Directory.Delete(folder);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFolder(txtFolderPath);
        }
        private void OpenFolder(TextBox textBox)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox.Text = dialog.SelectedPath;
            }
        }
    }
}
