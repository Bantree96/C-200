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

namespace A166_WPF_AnalogClock
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Field
        private Point _center;
        private double _radius;
        private int _hourHand;
        private int _minHand;
        private int _secHand;


        #endregion

        #region Constructor
        public MainWindow()
        {
            InitializeComponent();

            aClock_Setting();
            TimerSetting();
        }
        #endregion

        #region Method
        private void aClock_Setting()
        {
            _center = new Point(canvas1.Width / 2, canvas1.Height / 2);
            _radius = canvas1.Width / 2;
            _hourHand = (int)(_radius * 0.45);
            _minHand = (int)(_radius * 0.55);
            _secHand = (int)(_radius * 0.65);
        }

        private void TimerSetting()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 10); // 0.01초에 한번씩
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime c = DateTime.Now;

            canvas1.Children.Clear(); // 현재 화면 지우기
            DrawClockFace();

            double radHr = (c.Hour % 12 + c.Minute / 60.0) * 30 * Math.PI / 180;
            double radMin = (c.Minute + c.Second / 60.0) * 6 * Math.PI / 180;
            double radSec = (c.Second + c.Millisecond / 1000.0) * 6 * Math.PI / 180;

            DrawHands(radHr, radMin, radSec);
        }

        /// <summary>
        /// 시계판 그리기
        /// </summary>
        private void DrawClockFace()
        {
            aClock.Stroke = Brushes.LightSteelBlue;
            aClock.StrokeThickness = 30;
            canvas1.Children.Add(aClock);
        }

        /// <summary>
        /// 시계바늘 그리기
        /// </summary>
        /// <param name="radHr">시침</param>
        /// <param name="radMin">분침</param>
        /// <param name="radSec">초침</param>
        private void DrawHands(double radHr, double radMin, double radSec)
        {

            // 시침
            DrawLine(_hourHand * Math.Sin(radHr), -_hourHand * Math.Cos(radHr), 0, 0, Brushes.RoyalBlue, 8, new Thickness(_center.X, _center.Y, 0, 0));

            // 분침
            DrawLine(_minHand * Math.Sin(radMin), -_minHand * Math.Cos(radMin), 0, 0, Brushes.SkyBlue, 6, new Thickness(_center.X, _center.Y, 0, 0));

            // 초침
            DrawLine(_secHand * Math.Sin(radSec), -_secHand * Math.Cos(radSec), 0, 0, Brushes.OrangeRed, 3, new Thickness(_center.X, _center.Y, 0, 0));

            Ellipse core = new Ellipse();
            core.Margin = new Thickness(canvas1.Width / 2 - 10, canvas1.Height / 2 - 10, 0, 0);
            core.Stroke = Brushes.SteelBlue;
            core.Fill = Brushes.LightSteelBlue;
            core.Width = 20;
            core.Height = 20;
            canvas1.Children.Add(core);
        }

        private void DrawLine(double x1, double y1, int x2, int y2, SolidColorBrush color, int thick, Thickness margin)
        {
            Line line = new Line();
            line.X1 = x1;
            line.Y1 = y1;
            line.X2 = x2;
            line.Y2 = y2;
            line.Stroke = color;
            line.StrokeThickness = thick;
            line.Margin = margin;
            line.StrokeStartLineCap = PenLineCap.Round;
            canvas1.Children.Add(line);
        }
        #endregion
    }
}
