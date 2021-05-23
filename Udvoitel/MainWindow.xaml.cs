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

namespace Udvoitel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Гришель
        //1.
        //а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
        //б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.Игрок должен получить это число за минимальное количество ходов.
        //Вся логика игры должна быть реализована в классе с удвоителем.

        Random r;
        int n;
        int a;
        public MainWindow()
        {
            InitializeComponent();
            btnCommand1.Content = "+1";
            btnCommand2.Content = "x2";
            btnReset.Content = "Сброс и игра";
            lblNumber.Content = "0";
            lblCount.Content = "0";
            Title = "Удвоитель";
            r = new Random();

        }

        int count;
        private void btnCommand1_Click(object sender, RoutedEventArgs e)
        {
            var t = GetContent();
            if (t != n)
            {
                t++;
                lblNumber.Content = t.ToString();
                count++;
                lblCount.Content = count;
            }
            Equality(t);
        }

        private void btnCommand2_Click(object sender, RoutedEventArgs e)
        {
            var t = GetContent();
            if (t != n)
            {
                t *= 2;
                lblNumber.Content = t.ToString();
                count++;
                lblCount.Content = count;
            }
            Equality(t);
        }
        void Equality(int t) 
        {
            if (t == n)
            {
                if (a == count) MessageBox.Show("Красавчик");
                else MessageBox.Show("Молодец, но много ходов");
                Reset();
            }
        }
        int GetContent() => Convert.ToInt32(lblNumber.Content); 
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            lblNumber.Content = "1";
            count = 0;
            lblCount.Content = count;
            n = r.Next(10, 40);
            a = MinCount(n);
            MessageBox.Show($"Угадать {n} за {a} ходов");
        }
        
        public int MinCount(int n)
        {
            int minCount = 0;
            for (;;)
            {
                if (n == 1) { return minCount; }
                else if (n % 2 == 0)
                {
                    n = n / 2; // если число делится на 2 без ост. разделить его на 2
                    minCount++;
                    Debug.WriteLine(n);
                    Debug.WriteLine(minCount);

                }
                else if (n % 2 == 1)
                {
                    n--; // если число делится на 2 с ост. 1 отнять единицу
                    minCount++;
                    Debug.WriteLine(n);
                    Debug.WriteLine(minCount);
                }
            }
        }
        private void newGameClick(object sender, RoutedEventArgs e)
        {
            Reset();
        }
    }
}
