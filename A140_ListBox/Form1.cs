using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A140_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 2번 직접 Add하는 방법
            listBox2.Items.Add("오스트리아, 빈");
            listBox2.Items.Add("호주, 애들레이드");

            // 3번 리스트로 받아서 넣는법
            List<String> lstGDP = new List<String> { "미국", "러시아", "중국", "영국", "독일", "프랑스", "일본", "이스라엘", "사우디아라비아", "UAE" };
            listBox3.DataSource = lstGDP;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lst = sender as ListBox;
            txtSIndex1.Text = lst.SelectedIndex.ToString();
            txtSItem1.Text = lst.SelectedItem.ToString();

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lst = sender as ListBox;
            txtSIndex2.Text = lst.SelectedIndex.ToString();
            txtSItem2.Text = lst.SelectedItem.ToString();

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lst = sender as ListBox;
            txtSIndex3.Text = lst.SelectedIndex.ToString();
            txtSItem3.Text = lst.SelectedItem.ToString();
        }
    }
}
