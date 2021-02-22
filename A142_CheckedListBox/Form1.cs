using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A142_CheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cLstBox.Items.Add("오스트리아, 빈");
            cLstBox.Items.Add("호주, 멜버른");
            cLstBox.Items.Add("일본, 오사카");
            cLstBox.Items.Add("캐나다, 캘거리");
            cLstBox.Items.Add("호주, 시드니");
            cLstBox.Items.Add("캐나다, 벤쿠버");
            cLstBox.Items.Add("캐나다, 토론토");
            cLstBox.Items.Add("덴마크, 코펜하겐");
            cLstBox.Items.Add("호주, 애틀레이드");

            lstBox.SelectionMode = SelectionMode.MultiExtended;
        }

        // cLstBox의 체크된 아이템 각각을 lstBox에 추가합니다
        private void btnTo_Click(object sender, EventArgs e)
        {
            foreach (var city in cLstBox.CheckedItems)
                lstBox.Items.Add(city);
        }

        // cLstBox의 모든 아이템을 lstBox에 추가합니다.
        private void btnAll_Click(object sender, EventArgs e)
        {
            foreach (var city in cLstBox.Items)
                lstBox.Items.Add(city);
        }

        // 리스트의 각 요소를 삭제합니다.
        private void btnBack_Click(object sender, EventArgs e)
        {
            List<string> lstRemove = new List<string>();

            foreach (string city in lstBox.SelectedItems)
                lstRemove.Add(city);

            foreach (string city in lstRemove)
                lstBox.Items.Remove(city);
        }

        // 모든 lstBox를 비웁니다.
        private void btnDelAll_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();
        }
    }
}
