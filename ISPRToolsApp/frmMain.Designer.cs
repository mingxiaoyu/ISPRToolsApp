namespace ISPRToolsApp
{
    partial class frmMain
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
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnExtractCode = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtProgeny = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.btnSavePath = new System.Windows.Forms.Button();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(181, 104);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 0;
            this.btnCompare.Text = "代码比对";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnExtractCode
            // 
            this.btnExtractCode.Location = new System.Drawing.Point(262, 104);
            this.btnExtractCode.Name = "btnExtractCode";
            this.btnExtractCode.Size = new System.Drawing.Size(75, 23);
            this.btnExtractCode.TabIndex = 1;
            this.btnExtractCode.Text = "提取代码";
            this.btnExtractCode.UseVisualStyleBackColor = true;
            this.btnExtractCode.Click += new System.EventHandler(this.btnExtractCode_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "现有代码";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnProgeny_Click);
            // 
            // txtProgeny
            // 
            this.txtProgeny.Location = new System.Drawing.Point(89, 12);
            this.txtProgeny.Name = "txtProgeny";
            this.txtProgeny.Size = new System.Drawing.Size(248, 23);
            this.txtProgeny.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "原始代码";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnOrigin_Click);
            // 
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(89, 42);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(248, 23);
            this.txtOrigin.TabIndex = 3;
            // 
            // btnSavePath
            // 
            this.btnSavePath.Location = new System.Drawing.Point(8, 70);
            this.btnSavePath.Name = "btnSavePath";
            this.btnSavePath.Size = new System.Drawing.Size(75, 23);
            this.btnSavePath.TabIndex = 1;
            this.btnSavePath.Text = "保存路径";
            this.btnSavePath.UseVisualStyleBackColor = true;
            this.btnSavePath.Click += new System.EventHandler(this.btnOrigin_Click);
            // 
            // txtSavePath
            // 
            this.txtSavePath.Location = new System.Drawing.Point(89, 70);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(248, 23);
            this.txtSavePath.TabIndex = 3;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(100, 104);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 4;
            this.btnSet.Text = "保存设置";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 158);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.txtSavePath);
            this.Controls.Add(this.btnSavePath);
            this.Controls.Add(this.txtOrigin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtProgeny);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExtractCode);
            this.Controls.Add(this.btnCompare);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnExtractCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtProgeny;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.Button btnSavePath;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Button btnSet;
    }
}

