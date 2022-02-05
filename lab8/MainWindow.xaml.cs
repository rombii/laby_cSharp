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

namespace lab8
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

        private void suma(object sender, RoutedEventArgs e)
        {
            
            float number1 = (float) Convert.ToDouble(n1.Text);
            float number2 = (float) Convert.ToDouble(n2.Text);
            setColor();
            setBold();
            wynikLabel.Content = "Suma " + number1 + "+" + number2 + " = " + (number1+number2);
            addToList(number1+number2);
        }


        private void iloczyn(object sender, RoutedEventArgs e)
        {
            float number1 = (float) Convert.ToDouble(n1.Text);
            float number2 = (float) Convert.ToDouble(n2.Text);
            setColor();
            setBold();
            wynikLabel.Content = "Iloczyn " + number1 + "*" + number2 + " = " + number1*number2;
            addToList(number1*number2);
        }
        
        private void roznica(object sender, RoutedEventArgs e)
        {
            float number1 = (float) Convert.ToDouble(n1.Text);
            float number2 = (float) Convert.ToDouble(n2.Text);
            setColor();
            setBold();
            wynikLabel.Content = "Różnica " + number1 + "-" + number2 + " = " + (number1-number2);
            addToList(number1-number2);
        }
        
        private void iloraz(object sender, RoutedEventArgs e)
        {
            float number1 = (float) Convert.ToDouble(n1.Text);
            float number2 = (float) Convert.ToDouble(n2.Text);
            if (number2 != 0f)
            {
                setBold();
                setColor();
                wynikLabel.Content = "Iloraz " + number1 + "/" + number2 + " = " + number1 / number2;
                addToList(number1/number2);
            }
            else
                MessageBox.Show("nie dzielimy przez 0");
        }


        private void addToList(float wynik)
        {
            listEquals.Items.Add(wynik.ToString());
        }

        private void setColor()
        {
            if ((bool) blue.IsChecked)
            {
                wynikLabel.Foreground = new SolidColorBrush(Colors.Blue);
            }
            else if((bool) green.IsChecked)
            {
                wynikLabel.Foreground = new SolidColorBrush(Colors.Green);
            }
            else if ((bool) red.IsChecked)
            {
                wynikLabel.Foreground = new SolidColorBrush(Colors.Red);
            }
            else
            {
                wynikLabel.Foreground = new SolidColorBrush(Colors.Black);
            }
        }
        private void setBold()
        {
            if ((bool) bold.IsChecked)
            {
                wynikLabel.FontWeight = FontWeights.Bold;
            }
            else
            {
                wynikLabel.FontWeight = FontWeights.Regular;
            }
        }
        
    }
}
