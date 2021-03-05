using System;
using System.Windows;

using System.Windows.Threading;// DispatcherTimer를 위해 추가

namespace A164_WPF_DigitalClock
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1); // 1초
            timer.Tick += Timer_Tick; // 이벤트 처리 메소드 지정
            timer.Start();  // 타이머 시작
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            dClock.Text = DateTime.Now.ToString();
        }
    }
}
