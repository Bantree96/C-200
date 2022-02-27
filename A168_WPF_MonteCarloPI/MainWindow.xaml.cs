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

namespace A168_WPF_MonteCarloPI
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Field 
        int iCnt = 0;
        int oCnt = 0;

        DispatcherTimer timer = new DispatcherTimer();
        Random r = new Random();

        #endregion

        #region Constructor
        public MainWindow()
        {
            InitializeComponent();

            SettingTimer();
        }
        #endregion

        #region Method
        /// <summary>
        /// 타이머 실행
        /// </summary>
        private void SettingTimer()
        {
            timer.Interval = new TimeSpan(10000); // 1ms
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle();
            rect.Width = 1;
            rect.Height = 1;

            int x = r.Next(0, 400);
            int y = r.Next(0, 400);

            if((x-200) * (x-200) + (y-200) *(y-200) <= 40000)
            {
                rect.Stroke = Brushes.Red;
                iCnt++;
            }
            else
            {
                rect.Stroke = Brushes.Blue;
                oCnt++;
            }

            int count = iCnt + oCnt;
            double pi = (double)iCnt / count * 4;
            txtStatus.Text = $"n = {count}, In : {iCnt}, Out : {oCnt}, PI = {pi}";
            Canvas.SetLeft(rect, x);
            Canvas.SetTop(rect, y);
            Canvas1.Children.Add(rect);
        }
        #endregion
    }
}
