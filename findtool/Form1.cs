using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace findtool
{
    public partial class findTool : Form
    {
        public findTool()
        {
            InitializeComponent();
            directoryBox.Text = Properties.Settings.Default.path;
            string[] exts = new string[] { "cs", "cpp","c", "h", "hpp", "txt", "php", "js", "css", "config", "xml", "json" };
            foreach (string txt in exts)
            {
                flowLayoutPanel1.Controls.Add(new CheckBox() { Text = txt, Checked = true , Width=60, Height=18});
            }
        }

        private void dirbutton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dirDia = new FolderBrowserDialog();
            if (directoryBox.Text != "") {
                dirDia.SelectedPath = directoryBox.Text;
            }
            else
            {
                dirDia.SelectedPath = @"C:\Users\sugiy\Local Sites";
            }

            if (dirDia.ShowDialog() == DialogResult.OK)
            {
                directoryBox.Text = dirDia.SelectedPath;
                Properties.Settings.Default.path = directoryBox.Text;
                Properties.Settings.Default.Save();
            }

        }

        private void findbutton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string toppath = directoryBox.Text;
            outtextBox.Text = "";
            //指定したディレクトリのファイルをすべて取得する
            DirectoryInfo di = new DirectoryInfo(toppath);
//            outtextBox.Text += toppath + Environment.NewLine;
            findstring(di);

            //サブディレクトリのファイルをすべて取得する
            IEnumerable<DirectoryInfo> subFolders = di.EnumerateDirectories("*", SearchOption.AllDirectories);
            //サブフォルダを列挙する
            foreach (DirectoryInfo subFolder in subFolders)
            {
                findstring(subFolder);
            }
            Cursor.Current = Cursors.Default;
        }

        private void findstring(DirectoryInfo di)
        {
            List<String> patterns = new List<string>();
            foreach (CheckBox ext in flowLayoutPanel1.Controls)
            {
                if (ext.Checked) patterns.Add("*." + ext.Text);
            }
            // php js cssで3回行う
            foreach (string pattern in patterns)
            {
                FileInfo[] files = di.GetFiles(pattern, SearchOption.TopDirectoryOnly);
                if (subDirectorycheckBox.Checked)
                {
                    files = di.GetFiles(pattern, SearchOption.AllDirectories);
                }
                StringBuilder sb = new StringBuilder();
                foreach (FileInfo f in files)
                {
                    if (f.Name.Contains("min.js")) continue; 
                    //"C:\test\1.txt"をShift-JISコードとして開く
                    StreamReader sr = new System.IO.StreamReader(f.FullName);
                    //内容を一行ずつ読み込む
                    int row = 1;
                    bool first = true;
                    while (sr.Peek() > -1)
                    {
                        string line = sr.ReadLine();
                        if (LUcheckBox.Checked)
                        {
                            if (line.Contains(findstringBox.Text))
                            {
                                if (first)
                                {
                                    sb.Append(Environment.NewLine);
                                    sb.Append(f.Name);
                                    sb.Append(Environment.NewLine);
                                    first = false;
                                }
                                sb.Append(row.ToString() + ": " + line);
                                sb.Append(Environment.NewLine);
                            }
                        }
                        else
                        {
                            if (line.ToLower().Contains(findstringBox.Text.ToLower()))
                            {
                                if (first)
                                {
                                    sb.Append(f.Name);
                                    sb.Append(Environment.NewLine);
                                    first = false;
                                }
                                sb.Append(row.ToString() + ": " + line);
                                sb.Append(Environment.NewLine);
                            }
                        }
                        row++;
                    }
                    //閉じる
                    sr.Close();
                }
                if (sb.Length > 1)
                {
                    outtextBox.Text += Environment.NewLine + Environment.NewLine + di.FullName + Environment.NewLine;
                }
                outtextBox.Text += sb.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string toppath = directoryBox.Text;
            outtextBox.Text = "";
            //指定したディレクトリのファイルをすべて取得する
            DirectoryInfo di = new DirectoryInfo(toppath);
            findfiles(di);

            //サブディレクトリのファイルをすべて取得する
            IEnumerable<DirectoryInfo> subFolders = di.EnumerateDirectories("*", SearchOption.AllDirectories);
            //サブフォルダを列挙する
            foreach (DirectoryInfo subFolder in subFolders)
            {
                findfiles(subFolder);
            }
            Cursor.Current = Cursors.Default;
        }

        private void findfiles(DirectoryInfo di)
        {
            FileInfo[] files = di.GetFiles();
            StringBuilder sb = new StringBuilder();
            foreach (FileInfo f in files)
            {
                if (f.Name.Contains(findstringBox.Text))
                {
                    sb.Append(f.FullName + Environment.NewLine);
                }
            }
            outtextBox.Text += sb.ToString();
        }
    }
}
