using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A165_WinForm_AnalogClock
{
    public partial class Form1 : Form
    {
        #region Field
        Graphics _g; // Graphics 객체
        private Point _center;
        private double _radius;
        private int _hourHand; // 시침의 길이
        private int _minHand;  // 분침의 길이
        private int _secHand;  // 초침의 길이
        private Timer _timer1;
        private const int _clientSize = 300;// clientSize
        private const int _clockSize = 200; // 시계판의 지름
        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();

            this.ClientSize = new Size(_clientSize, _clientSize);
            this.Text = "Analog Clock";
            panel1.BackColor = Color.WhiteSmoke;
            this.Padding = new Padding(10);

            _g = panel1.CreateGraphics();

            aClockSetting();
            TimerSetting();
        }
        #endregion

        #region Method
        /// <summary>
        /// 아날로그 시계 세팅
        /// </summary>
        private void aClockSetting()
        {
            _center = new Point(panel1.Width / 2, panel1.Height / 2);
            _radius = panel1.Height / 2;

            _hourHand = (int)(_radius * 0.45);
            _minHand = (int)(_radius * 0.55);
            _secHand = (int)(_radius * 0.65);

        }

        /// <summary>
        /// 타이머 세팅
        /// </summary>
        private void TimerSetting()
        {
            _timer1 = new Timer();
            _timer1.Interval = 1000; // 1초에 한번씩
            _timer1.Tick += Timer1_Tick;
            _timer1.Start();

        }

        /// <summary>
        /// 시계판 그리기
        /// </summary>
        private void DrawClockFace()
        {
            Pen pen = new Pen(Brushes.LightSteelBlue, 30);
            _g.DrawEllipse(pen, (_center.X - _clockSize / 2), (_center.Y - _clockSize / 2), _clockSize, _clockSize);
        }

        /// <summary>
        /// 바늘 그리기
        /// </summary>
        /// <param name="radHr">시침</param>
        /// <param name="radMin">분침</param>
        /// <param name="radSec">초침</param>
        private void DrawHands(double radHr, double radMin, double radSec)
        {
            // 시침
            DrawLine((int)(_hourHand * Math.Sin(radHr)),(int)(-_hourHand * Math.Cos(radHr)), 0, 0, Brushes.RoyalBlue, 8, _center.X, _center.Y);

            // 분침
            DrawLine((int)(_minHand * Math.Sin(radMin)),(int)(-_minHand * Math.Cos(radMin)), 0, 0, Brushes.SkyBlue, 6, _center.X, _center.Y);

            // 초침
            DrawLine((int)(_secHand * Math.Sin(radSec)),(int)(-_secHand * Math.Cos(radSec)), 0, 0, Brushes.OrangeRed, 3, _center.X, _center.Y);

            // 시계 배꼽
            int coreSize = 16;
            Rectangle r = new Rectangle(_center.X - coreSize / 2, _center.Y - coreSize / 2, coreSize, coreSize);

            _g.FillEllipse(Brushes.Gold, r);

            Pen p = new Pen(Brushes.DarkRed, 3);
            _g.DrawEllipse(p, r);

        }

        /// <summary>
        /// 선 그리는 메소드
        /// </summary>
        /// <param name="x1">x1</param>
        /// <param name="y1">y1</param>
        /// <param name="x2">x2</param>
        /// <param name="y2">y2</param>
        /// <param name="color">선의 색</param>
        /// <param name="thick">선의 두께</param>
        /// <param name="cx">센터 x</param>
        /// <param name="cy">센터 y</param>
        private void DrawLine(int x1, int y1, int x2, int y2, Brush color, int thick, int cx, int cy)
        {
            Pen pen = new Pen(color, thick);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            _g.DrawLine(pen, x1 + cx, y1 + cy, x2 + cx, y2 + cy);

        }
        #endregion

        /// <summary>
        /// 타이머 메소드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime c = DateTime.Now;

            panel1.Refresh();

            DrawClockFace();

            // 시침, 분침, 초침의 각도(단위 : 라디안)
            double radHr = (c.Hour % 12 + c.Minute / 60.0) * 30 * Math.PI / 180;
            double radMin = (c.Minute + c.Second / 60.0) * 6 * Math.PI / 180;
            double radSec = (c.Second) * 6 * Math.PI / 180;

            DrawHands(radHr, radMin, radSec);
        }
    }
}
