using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace ISPRToolsApp
{
    public partial class FrmCompare : Form
    {
        public FrmCompare()
        {
            InitializeComponent();
            txtFolders.Text = "packages,.nuget,App_Data,bin,Debug,Release,node_modules,dist,.vs,.git,UploadFiles";
            txtSuffixs.Text = "";
            txtResult.ReadOnly = true;
            txtProgeny.Text = Tools.CodeFolder();
            txtOrigin.Text = Tools.OriginFolder();
        }

        private void btnProgeny_Click(object sender, EventArgs e)
        {
            OpenFolder(txtProgeny);
        }

        private void btnOrigin_Click(object sender, EventArgs e)
        {
            OpenFolder(txtOrigin);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = " txt files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                var str = txtResult.Text;
                StreamWriter sw = new StreamWriter(saveDialog.FileName, false, Encoding.UTF8);
                sw.Write(str);
                sw.Close();
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            var folders = string.IsNullOrWhiteSpace(txtFolders.Text) ? null : txtFolders.Text.Split(',');
            var suffixs = (txtSuffixs.Text + ",.csproj,.user,.dll,.pubxml,.gitkeep").TrimStart(',').Split(',');

            var leftFiles = GetFiles(txtProgeny.Text, folders, suffixs);
            var rightFiles = GetFiles(txtOrigin.Text, folders, suffixs);
            var added = new List<string>();
            var modified = new List<string>();
            var deleted = new List<string>();

            foreach (var left in leftFiles)
            {
                var right = rightFiles.FirstOrDefault(x => x.Equals(left));
                if (right != null)
                {
                    var leftFilePath = Path.Combine(txtProgeny.Text, left);
                    var rightFilePath = Path.Combine(txtOrigin.Text, right);
                    var leftfile = File.ReadAllText(leftFilePath).Replace("\r\n", "\n").Replace("\r", "\n");
                    var rightfile = File.ReadAllText(rightFilePath).Replace("\r\n", "\n").Replace("\r", "\n");
                    if (!leftfile.Equals(rightfile, StringComparison.OrdinalIgnoreCase))
                    {
                        modified.Add(left);
                    }
                }
                else
                {
                    added.Add(left);
                }
            }

            foreach (var right in rightFiles)
            {
                if (!leftFiles.Any(x => x.Equals(right)))
                {
                    deleted.Add(right);
                }
            }

            StringBuilder reslutsb = new StringBuilder();

            BuildResult("新增", added, reslutsb);
            BuildResult("修改", modified, reslutsb);
            BuildResult("删除", deleted, reslutsb);
            txtResult.Text = reslutsb.ToString();

        }

        private void BuildResult(string name, List<string> list, StringBuilder sb)
        {
            if (list.Count > 0)
            {
                sb.AppendLine($"---------{name}---------");
                foreach (var item in list)
                {
                    sb.AppendLine(item);
                }
                sb.AppendLine($"---------{name}---------");
            }
        }

        private IEnumerable<string> GetFiles(string path, string[] excludedFolders, string[] excludedSuffixs)
        {
            var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
            var list = new List<string>();
            foreach (var file in files)
            {
                var shortFilePath = file.Replace(path + Path.DirectorySeparatorChar, "");
                var tmp = shortFilePath.Split(Path.DirectorySeparatorChar);
                if (excludedFolders.Any(x => tmp.Any(y => y.Equals(x, StringComparison.OrdinalIgnoreCase))))
                {
                    continue;
                }
                if (excludedSuffixs.Any(x => x == Path.GetExtension(file)))
                {
                    continue;
                }
                list.Add(shortFilePath);
            }
            return list;
        }
    }
}
