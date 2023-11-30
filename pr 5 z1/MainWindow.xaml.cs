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

namespace pr_5_z1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            double X = Convert.ToDouble(textBoxX.Text);
            int N = Convert.ToInt32(textBoxN.Text);
            double result = 0.0;

            for (int i = 1; i <= N; i++)
            {
                result += Math.Pow(-1, i - 1) * Math.Pow(X, i) / i;
            }

            resultTextBlock.Text = $"ln(1 + {X}) ≈ {result}";
        }
    }
}
 