using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A150_TabControl
{
    public partial class Form1 : Form
    {
        private Timer myTimer = new Timer();
        private DateTime dDay;  // 알람 날짜
        private DateTime tTime; // 알람 시간
        private bool setAlarm;  // 알람

        public Form1()
        {
            InitializeComponent();

            // 알람이 설정되어 있지 않음으로 회색처라
            lblAlarm.ForeColor = Color.Gray;
            lblAlarmSet.ForeColor = Color.Gray;

            // timePicker 포맷설정
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "tt hh:mm";

            // 타이머 1초에 한번씩 작동
            myTimer.Interval = 1000;
            myTimer.Tick += MyTimer_Tick;
            myTimer.Start();

            // 처음실행될때 두번째 탭 페이지가 표시되게 함
            tabControl1.SelectedTab = tabPage2;

        }

        // 타이머 메소드
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            DateTime cTime = DateTime.Now;
            lblDate.Text = cTime.ToShortDateString();
            lblTime.Text = cTime.ToLongTimeString();

            // 알람이 세팅되어있다면 
            if(setAlarm == true)
            {
                // 설정한 알람과 현재 시간이 동일할 때 알람을 울림
                if(dDay == DateTime.Today && cTime.Hour == tTime.Hour && cTime.Minute == tTime.Minute)
                {
                    setAlarm = false;
                    MessageBox.Show("Alarm!");

                }
            }
        }
        // 설정 버튼을 클릭했을 때
        private void btnSet_Click_1(object sender, EventArgs e)
        {
            // 날짜와 시간을 Parse하는 부분
            dDay = DateTime.Parse(datePicker.Text);
            tTime = DateTime.Parse(timePicker.Text);

            setAlarm = true;
            lblAlarmSet.ForeColor = Color.Red;
            lblAlarm.ForeColor = Color.Blue;
            lblAlarm.Text = "알람 : " + dDay.ToShortTimeString() + " " + tTime.ToLongTimeString();
            tabControl1.SelectedTab = tabPage2;

        }

        // 해제 버튼을 클릭했을 때
        private void btnReset_Click(object sender, EventArgs e)
        {
            setAlarm = false;
            lblAlarmSet.ForeColor = Color.Gray;
            lblAlarm.ForeColor = Color.Gray;
            lblAlarm.Text = "알람 : ";
            tabControl1.SelectedTab = tabPage2;

        }

        
    }
}
