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

namespace A156_WPF_HelloWorld
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // label1의 마우스 다운 이벤트 처리 메소드
        private void label1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // 처음 label1의 전경색이 흰색이 아니면 참 ( 처음엔 무조건 검정이라 참이됨 )
            if(label1.Foreground != Brushes.White)
            {
                label1.Foreground = Brushes.White;
                this.Background = Brushes.Blue;
            } else
            {
                label1.Foreground = SystemColors.WindowTextBrush;
                this.Background = SystemColors.WindowBrush;
            }
        }
    }
}
