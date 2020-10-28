namespace ISPRToolsApp
{
    partial class FrmCompare
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
            this.btnProgeny = new System.Windows.Forms.Button();
            this.btnOrigin = new System.Windows.Forms.Button();
            this.txtProgeny = new System.Windows.Forms.TextBox();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolders = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSuffixs = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProgeny
            // 
            this.btnProgeny.Location = new System.Drawing.Point(39, 12);
            this.btnProgeny.Name = "btnProgeny";
            this.btnProgeny.Size = new System.Drawing.Size(75, 23);
            this.btnProgeny.TabIndex = 0;
            this.btnProgeny.Text = "现有代码";
            this.btnProgeny.UseVisualStyleBackColor = true;
            this.btnProgeny.Click += new System.EventHandler(this.btnProgeny_Click);
            // 
            // btnOrigin
            // 
            this.btnOrigin.Location = new System.Drawing.Point(374, 12);
            this.btnOrigin.Name = "btnOrigin";
            this.btnOrigin.Size = new System.Drawing.Size(75, 23);
            this.btnOrigin.TabIndex = 1;
            this.btnOrigin.Text = "原始代码";
            this.btnOrigin.UseVisualStyleBackColor = true;
            this.btnOrigin.Click += new System.EventHandler(this.btnOrigin_Click);
            // 
            // txtProgeny
            // 
            this.txtProgeny.Location = new System.Drawing.Point(120, 12);
            this.txtProgeny.Name = "txtProgeny";
            this.txtProgeny.Size = new System.Drawing.Size(248, 23);
            this.txtProgeny.TabIndex = 2;
            // 
            // txtOrigin
            // 
            this.txtOrigin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrigin.Location = new System.Drawing.Point(455, 12);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(248, 23);
            this.txtOrigin.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "排除的文件夹：";
            // 
            // txtFolders
            // 
            this.txtFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolders.Location = new System.Drawing.Point(120, 47);
            this.txtFolders.Name = "txtFolders";
            this.txtFolders.Size = new System.Drawing.Size(583, 23);
            this.txtFolders.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "排除的文件类型：";
            // 
            // txtSuffixs
            // 
            this.txtSuffixs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSuffixs.Location = new System.Drawing.Point(120, 78);
            this.txtSuffixs.Name = "txtSuffixs";
            this.txtSuffixs.Size = new System.Drawing.Size(583, 23);
            this.txtSuffixs.TabIndex = 5;
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(120, 110);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(583, 262);
            this.txtResult.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "结果：";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(628, 402);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompare.Location = new System.Drawing.Point(547, 402);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 10;
            this.btnCompare.Text = "比较";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // FrmCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSuffixs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFolders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOrigin);
            this.Controls.Add(this.txtProgeny);
            this.Controls.Add(this.btnOrigin);
            this.Controls.Add(this.btnProgeny);
            this.Name = "FrmCompare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "代码比较";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProgeny;
        private System.Windows.Forms.Button btnOrigin;
        private System.Windows.Forms.TextBox txtProgeny;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSuffixs;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCompare;
    }
}