using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISPRToolsApp
{
    public partial class frmMain : Form
    {


        public frmMain()
        {
            InitializeComponent();

            GetAppSettings();

            txtProgeny.Text = Tools.CodeFolder();
            txtOrigin.Text = Tools.OriginFolder();
            txtSavePath.Text = Tools.ExportFolder();
        }

        private void GetAppSettings()
        {
            var builder = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile(Tools.AppSettngs, optional: true, reloadOnChange: true);
            Tools.Configuration = builder.Build();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            var frm = new FrmCompare();
            ShowFrom(frm);
        }

        private void ShowFrom(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnExtractCode_Click(object sender, EventArgs e)
        {
            var frm = new FrmExtractCode();
            ShowFrom(frm);
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

        private void btnSet_Click(object sender, EventArgs e)
        {
            Tools.AddOrUpdateAppSetting("OriginFolder", txtOrigin.Text.Trim());
            Tools.AddOrUpdateAppSetting("ExportFolder", txtSavePath.Text.Trim());
            Tools.AddOrUpdateAppSetting("CodeFolder", txtProgeny.Text.Trim());
            GetAppSettings();
        }
    }
}
