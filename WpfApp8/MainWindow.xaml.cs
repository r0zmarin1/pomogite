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

namespace WpfApp8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickNumber(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            input.Text += button.Content.ToString();
        }

        private void ClickClear(object sender, RoutedEventArgs e)
        {
            operation = ' ';
            x = 0;
            input.Text = null;
        }

        private void ClickDot(object sender, RoutedEventArgs e)
        {
            if (!input.Text.Contains(",")) 
                input.Text += ",";

        }

        private void ClickPlusMinus(object sender, RoutedEventArgs e)
        {
            if (input.Text.StartsWith("-"))
                input.Text = input.Text.Remove(0, 1);
            else
                input.Text = "-" + input.Text;
        }
        private void ClickDivideX(object sender, RoutedEventArgs e)
        {
            double.TryParse(input.Text, out double y );
            input.Text = (1 / y).ToString();
        }

        private void ClickProcent(object sender, RoutedEventArgs e)
        {
            double procent1 = x / 100;
            double.TryParse(input.Text, out double y);
            input.Text = (y * procent1).ToString();

        }

        private void ClickSQR(object sender, RoutedEventArgs e)
        {
            double.TryParse(input.Text,out double y);
            input.Text = (Math.Sqrt(y)).ToString();
        }

        private void ClickBackSpace(object sender, RoutedEventArgs e)
        {
            if (input.Text.Length > 0)
                input.Text = input.Text.Remove(input.Text.Length - 1);
        }

        double x = 0;
        char operation = ' ';
        private void ClickOperation(object sender, RoutedEventArgs e) //( + - * / ^)
        {
            Button button = (Button)sender;
            operation = button.Content.ToString()[0];
            double.TryParse(input.Text, out x);
            input.Text = null;

        }

        private void ClickRavno(object sender, RoutedEventArgs e)
        {
            double result = 0;
            double.TryParse(input.Text, out double y);
            switch (operation)
            {
                case '+': result = x + y; break;
                case '-': result = x - y; break;
                case '*': result = x * y; break;
                case '/': result = x / y; break;
                case 'x²': result = x * x; break;

            }
            input.Text = result.ToString();
        }
        private void ClickPi(object sender, RoutedEventArgs e)
        {
            
        }
        private void ClickSin(object sender, RoutedEventArgs e)
        {

        }

    }
}
