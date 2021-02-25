using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Security;

namespace A153_OpenFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.FileName = "select a text file";           // 파일명에 들어가는 부분
            openFileDialog1.Filter = "text files (*.txt) | *.txt";     // 파일 필터에 들어가는 부분
            openFileDialog1.Title = "Open text file";                  // 타이틀 바에 들어가는 부분

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // 파일을 열때는 try, catch문을 사용해 예외처리를 해야한다.
                try
                {
                    var filePath = openFileDialog1.FileName;
                    using(FileStream fs = File.Open(filePath, FileMode.Open))
                    {
                        Process.Start("notepad.exe", filePath);
                    }
                }catch(SecurityException ex)
                {
                    MessageBox.Show($"보안 에러.\n\nError Message:{ex.Message}\n\n" + $"디테일 : \n\n{ex.StackTrace}");
                }
            }
        }
    }
}
