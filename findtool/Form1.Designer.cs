namespace findtool
{
    partial class findTool
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Directory = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.directoryBox = new System.Windows.Forms.TextBox();
            this.findstringBox = new System.Windows.Forms.TextBox();
            this.dirbutton = new System.Windows.Forms.Button();
            this.findbutton = new System.Windows.Forms.Button();
            this.LUcheckBox = new System.Windows.Forms.CheckBox();
            this.subDirectorycheckBox = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.outtextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Directory
            // 
            this.Directory.AutoSize = true;
            this.Directory.Location = new System.Drawing.Point(18, 30);
            this.Directory.Name = "Directory";
            this.Directory.Size = new System.Drawing.Size(52, 12);
            this.Directory.TabIndex = 0;
            this.Directory.Text = "Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "検索文字";
            // 
            // directoryBox
            // 
            this.directoryBox.Location = new System.Drawing.Point(142, 32);
            this.directoryBox.Name = "directoryBox";
            this.directoryBox.Size = new System.Drawing.Size(776, 19);
            this.directoryBox.TabIndex = 2;
            // 
            // findstringBox
            // 
            this.findstringBox.Location = new System.Drawing.Point(142, 89);
            this.findstringBox.Name = "findstringBox";
            this.findstringBox.Size = new System.Drawing.Size(294, 19);
            this.findstringBox.TabIndex = 3;
            // 
            // dirbutton
            // 
            this.dirbutton.Location = new System.Drawing.Point(88, 27);
            this.dirbutton.Name = "dirbutton";
            this.dirbutton.Size = new System.Drawing.Size(48, 24);
            this.dirbutton.TabIndex = 4;
            this.dirbutton.Text = "...";
            this.dirbutton.UseVisualStyleBackColor = true;
            this.dirbutton.Click += new System.EventHandler(this.dirbutton_Click);
            // 
            // findbutton
            // 
            this.findbutton.Location = new System.Drawing.Point(90, 59);
            this.findbutton.Name = "findbutton";
            this.findbutton.Size = new System.Drawing.Size(48, 24);
            this.findbutton.TabIndex = 5;
            this.findbutton.Text = "検索";
            this.findbutton.UseVisualStyleBackColor = true;
            this.findbutton.Click += new System.EventHandler(this.findbutton_Click);
            // 
            // LUcheckBox
            // 
            this.LUcheckBox.AutoSize = true;
            this.LUcheckBox.Checked = true;
            this.LUcheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LUcheckBox.Location = new System.Drawing.Point(148, 64);
            this.LUcheckBox.Name = "LUcheckBox";
            this.LUcheckBox.Size = new System.Drawing.Size(115, 16);
            this.LUcheckBox.TabIndex = 7;
            this.LUcheckBox.Text = "文字の大小を区別";
            this.LUcheckBox.UseVisualStyleBackColor = true;
            // 
            // subDirectorycheckBox
            // 
            this.subDirectorycheckBox.AutoSize = true;
            this.subDirectorycheckBox.Location = new System.Drawing.Point(269, 64);
            this.subDirectorycheckBox.Name = "subDirectorycheckBox";
            this.subDirectorycheckBox.Size = new System.Drawing.Size(92, 16);
            this.subDirectorycheckBox.TabIndex = 11;
            this.subDirectorycheckBox.Text = "サブディレクトリ";
            this.subDirectorycheckBox.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(487, 59);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(431, 45);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // outtextBox
            // 
            this.outtextBox.Location = new System.Drawing.Point(20, 114);
            this.outtextBox.Multiline = true;
            this.outtextBox.Name = "outtextBox";
            this.outtextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outtextBox.Size = new System.Drawing.Size(898, 375);
            this.outtextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 24);
            this.button1.TabIndex = 18;
            this.button1.Text = "ファイル名検索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // findTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 501);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.subDirectorycheckBox);
            this.Controls.Add(this.LUcheckBox);
            this.Controls.Add(this.outtextBox);
            this.Controls.Add(this.findbutton);
            this.Controls.Add(this.dirbutton);
            this.Controls.Add(this.findstringBox);
            this.Controls.Add(this.directoryBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Directory);
            this.Name = "findTool";
            this.Text = "FindTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Directory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox directoryBox;
        private System.Windows.Forms.TextBox findstringBox;
        private System.Windows.Forms.Button dirbutton;
        private System.Windows.Forms.Button findbutton;
        private System.Windows.Forms.CheckBox LUcheckBox;
        private System.Windows.Forms.CheckBox subDirectorycheckBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox outtextBox;
        private System.Windows.Forms.Button button1;
    }
}

