﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A152_WMP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            WMP.uiMode = "full";
            WMP.stretchToFit = true;

            btnFile.Location = new Point(
                ClientSize.Width - btnFile.Size.Width - 5,
                ClientSize.Height - btnFile.Size.Height - 5
            );
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            // 파일선택 버튼을 누르면 showdialog로 파일을 선택할수있게 한다.
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                WMP.URL = ofd.FileName;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            WMP.Size = this.ClientSize;

            btnFile.Location = new Point(
                ClientSize.Width - btnFile.Size.Width - 5,
                ClientSize.Height - btnFile.Size.Height - 5
            );
        }
    }
}
