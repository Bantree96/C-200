using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A154_Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblTime.Text = "";
            lblTime.Font = new Font("맑은 고딕", 20, FontStyle.Bold);
            T.Interval = 1000;
            T.Tick += T_Tick;
            T.Start();

        }

        private void T_Tick(object sender, EventArgs e)
        {
            lblTime.Location = new Point(
                ClientSize.Width / 2 - lblTime.Width / 2,
                ClientSize.Height / 2 - lblTime.Height / 2);
            lblTime.Text = DateTime.Now.ToString();
        }

        private void 폰트ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fDlg = new FontDialog();

            fDlg.ShowColor = true;
            fDlg.ShowEffects = true;
            fDlg.Font = lblTime.Font;
            fDlg.Color = lblTime.ForeColor;

            // 폰트 변경하면 lblTime에 적용
            if(fDlg.ShowDialog() == DialogResult.OK)
            {
                lblTime.Font = fDlg.Font;
                lblTime.ForeColor = fDlg.Color;
            }
        }

        private void 배경색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cDlg = new ColorDialog();
            // 배경색 변경하면 배경색에 적용
            if (cDlg.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = cDlg.Color;
            }
        }

        // 끝내기
        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
