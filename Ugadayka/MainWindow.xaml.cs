using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Ugadayka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Гришель
        //2. Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток. Компьютер говорит, больше или меньше загаданное число введенного.
        //a) Для ввода данных от человека используется элемент TextBox;
        Random r;
        int n;
        public MainWindow()
        {
            Initialize();
        }
        public void Initialize()
        {
            InitializeComponent();
            Btn.Content = "Ввести число";
            Player.Text = "50";
            Title = "Угадайка";
            r = new Random();
            n = r.Next(1, 100);
        }

        public void Btn_Click(object sender, RoutedEventArgs e)
        {
            int a = GetContent();
            if (a==n) MessageBox.Show("Круть");
            if (a<n) Answer.Content = ($"Загаданное число больше");
            if (a > n) Answer.Content = ($"Загаданное число меньше");
        }
        int GetContent() => Convert.ToInt32(Player.Text);
    }
}
/*InitializeComponent();
            btnCommand1.Content = "+1";
            btnCommand2.Content = "x2";
            btnReset.Content = "Сброс и игра";
            lblNumber.Content = "0";
            lblCount.Content = "0";
            Title = "Удвоитель";
            r = new Random();
*/