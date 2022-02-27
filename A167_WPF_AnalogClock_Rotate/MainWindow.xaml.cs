using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace A167_WPF_AnalogClock_Rotate
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {

        #region Field
        private double _hourDeg;
        private double _minDeg;
        private double _secDeg;
        #endregion

        #region Constructor
        public MainWindow()
        {
            InitializeComponent();

            DrawFace();
            MakeClockHands();

            TimerSetting();

        }
        #endregion


        #region Method
        /// <summary>
        /// 타이머 세팅
        /// </summary>
        private void TimerSetting()
        {
            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = new TimeSpan(0, 0, 0, 0, 10);
            dt.Tick += Dt_Tick;
            dt.Start();
        }

        private void Dt_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;

            int hour = currentTime.Hour;
            int min = currentTime.Minute;
            int sec = currentTime.Second;
            _hourDeg = hour % 12 * 30 + min * 0.5;
            _minDeg = min * 6;
            _secDeg = sec * 6;

            // 시계바늘 Remove & Add
            aClock.Children.Remove(hourHand);
            RotateTransform hourRt = new RotateTransform(_hourDeg);
            hourRt.CenterX = hourHand.X1;
            hourRt.CenterY = hourHand.Y1;
            hourHand.RenderTransform = hourRt;
            aClock.Children.Add(hourHand);

            aClock.Children.Remove(minHand);
            RotateTransform minRt = new RotateTransform(_minDeg);
            minRt.CenterX = minHand.X1;
            minRt.CenterY = minHand.Y1;
            minHand.RenderTransform = minRt;
            aClock.Children.Add(minHand);

            aClock.Children.Remove(secHand);
            RotateTransform secRt = new RotateTransform(_secDeg);
            secRt.CenterX = secHand.X1;
            secRt.CenterY = secHand.Y1;
            secHand.RenderTransform = secRt;
            aClock.Children.Add(secHand);

            // 시계 중앙
            aClock.Children.Remove(center);
            aClock.Children.Add(center);
        }

        /// <summary>
        /// 시계판을 그린다.
        /// </summary>
        private void DrawFace()
        {
            // 눈금 60개를 Line 배열로 만든다.
            Line[] marking = new Line[60];
            // Width of Clock
            int W = 300; 

            for(int i =0; i<60; i++)
            {
                marking[i] = new Line();
                marking[i].Stroke = Brushes.LightSteelBlue;
                marking[i].X1 = W / 2;
                marking[i].Y1 = 2;
                marking[i].X2 = W / 2;
                // 매 다섯번째 눈금은 큰 눈금으로 한다.
                if( i % 5 ==0)
                {
                    marking[i].StrokeThickness = 5;
                    marking[i].Y2 = 20;
                } 
                else
                {
                    marking[i].StrokeThickness = 2;
                    marking[i].Y2 = 10;
                }
                // 눈금 하나 당 중심점을 기준으로 6도씩 회전(RoatationTransform)
                RotateTransform rt = new RotateTransform(6 * i);
                rt.CenterX = 150; // 회전 중심점
                rt.CenterY = 150; // 회전 중심점
                marking[i].RenderTransform = rt;
                aClock.Children.Add(marking[i]);
            }

        }

        /// <summary>
        /// 시계바늘을 그린다.
        /// </summary>
        private void MakeClockHands()
        {
            int W = 300;
            int H = 300;

            secHand.X1 = W / 2;
            secHand.Y1 = H / 2;
            secHand.X2 = W / 2;
            secHand.Y2 = 20;

            minHand.X1 = W / 2;
            minHand.Y1 = H / 2;
            minHand.X2 = W / 2;
            minHand.Y2 = 40;

            hourHand.X1 = W / 2;
            hourHand.Y1 = H / 2;
            hourHand.X2 = W / 2;
            hourHand.Y2 = 60;
        }
        #endregion
    }
}
