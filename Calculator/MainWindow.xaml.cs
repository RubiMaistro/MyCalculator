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

namespace Calculator
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

        private MyCalculator calc = new MyCalculator();
       

        private void OnNumber(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (calc.Operator != null)
            {
                calc.Number = calc.Number*10 + float.Parse(button.Content.ToString());
                calc.Statement += float.Parse(button.Content.ToString());
            }
            else
            {
                calc.Result = calc.Result*10 + float.Parse(button.Content.ToString());
                calc.Statement += float.Parse(button.Content.ToString());
            }
            setStatement();
        }

        private void OnMultiplicate(object sender, RoutedEventArgs e)
        {
            calc.Operator = "x";
            calc.Statement += calc.Operator;
            setStatement();
        }

        private void OnDivide(object sender, RoutedEventArgs e)
        {
            calc.Operator = "/";
            calc.Statement += calc.Operator;
            setStatement();
        }

        private void OnSubtract(object sender, RoutedEventArgs e)
        {
            calc.Operator = "-";
            calc.Statement += calc.Operator;
            setStatement();
        }

        private void OnAdd(object sender, RoutedEventArgs e)
        {
                calc.Operator = "+";
                calc.Statement += calc.Operator;
                setStatement();
        }

        private void OnResult(object sender, RoutedEventArgs e)
        {
            switch (calc.Operator)
            {
                case "+":
                    calc.Result += calc.Number;
                    break;
                case "-":
                    calc.Result -= calc.Number;
                    break;
                case "/":
                    calc.Result /= calc.Number;
                    break;
                case "x":
                    calc.Result *= calc.Number;
                    break;
                default:
                    break;
            }
            resultLabel.Content = calc.Result;
            setStatement();
            cleanCalculator();
        }

        private void OnDelete(object sender, RoutedEventArgs e)
        {
            
        }

        private void cleanCalculator()
        {
            calc.Number = 0;
            calc.Operator = null;
            calc.Statement = calc.Result.ToString();
        }
        private void setStatement()
        {
            statementLabel.Content = calc.Statement;
        }
    }
}
