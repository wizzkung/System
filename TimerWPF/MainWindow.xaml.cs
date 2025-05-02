using System.Text;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TimerWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private System.Timers.Timer timer1, timer2, timer3;
        private double dir1 = 1, dir2 = 1, dir3 = 1;
        private bool isRunning = false;
        private const double ButtonWidth = 60;
        private const double CanvasWidth = 600;

        public MainWindow()
        {
            InitializeComponent();

            timer1 = new System.Timers.Timer(10);
            timer2 = new System.Timers.Timer(20);
            timer3 = new System.Timers.Timer(30);

            Canvas.SetLeft(but1, 0); 
            Canvas.SetLeft(but2, 0); 
            Canvas.SetLeft(but3, 0);

            timer1.Elapsed += (s, e) => MoveButton1();
            timer2.Elapsed += (s, e) => MoveButton2();
            timer3.Elapsed += (s, e) => MoveButton3();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window window = new Window();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!isRunning)
            {
                timer1.Start();
                timer2.Start();
                timer3.Start();
                isRunning = true;
                startStop.Content = "Stop";
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                isRunning = false;
                startStop.Content = "Start";
            }
        }

        private void MoveButton1()
        {
            Dispatcher.Invoke(() =>
            {
                double pos = Canvas.GetLeft(but1);
                pos += dir1 * 2;
                if (pos <= 0 || pos >= CanvasWidth - ButtonWidth) dir1 *= -1;
                Canvas.SetLeft(but1, pos);
            });
        }

        private void MoveButton2()
        {
            Dispatcher.Invoke(() =>
            {
                double pos = Canvas.GetLeft(but2);
                pos += dir2 * 2;
                if (pos <= 0 || pos >= CanvasWidth - ButtonWidth) dir2 *= -1;
                Canvas.SetLeft(but2, pos);
            });
        }

        private void MoveButton3()
        {
            Dispatcher.Invoke(() =>
            {
                double pos = Canvas.GetLeft(but3);
                pos += dir3 * 2;
                if (pos <= 0 || pos >= CanvasWidth - ButtonWidth) dir3 *= -1;
                Canvas.SetLeft(but3, pos);
            });
        }
    }



}

