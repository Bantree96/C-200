using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace A126_FormWithConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateMyForm();
        }

        private static void CreateMyForm()
        {
            Form form1 = new Form(); // 새로운 폼 객체 생성

            // 2개의 버튼 객체를 만듬
            Button button1 = new Button();
            Button button2 = new Button();

            button1.Text = "OK";
            button1.Location = new Point(10, 10);
            button2.Text = "Cancel";
            button2.Location = new Point(button1.Left, button1.Height + button1.Top + 10); // button2의 위치를 button1의 아래에 10만큼 떨어뜨려서 생성

            form1.Text = "My Dialog Box"; // 폼의 타이틀 바에 text를 적어줌

            button1.Click += Button1_Click; // 이벤트 처리 메소드를 정의함

            // 스타일 정의
            form1.FormBorderStyle = FormBorderStyle.FixedDialog;
            form1.StartPosition = FormStartPosition.CenterScreen;

            // 폼에 버튼을 추가
            form1.Controls.Add(button1);
            form1.Controls.Add(button2);

            // 폼1을 띄움
            form1.ShowDialog();

        }

        // 버튼 클릭 이벤트 메소드
        private static void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ok Button Clicked!");

        }
    }
}
