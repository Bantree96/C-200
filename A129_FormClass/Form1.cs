using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A129_FormClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.ClientSize = new Size(500, 500); // 객체가 생성될때 ClientSize 속성을 500 x 500으로 바꿉니다.

            Form f2 = new Form2(); // Form2를 생성
            this.AddOwnedForm(f2); // Form1에 Form2를 추가

            f2.Show();
        }
    }
}
