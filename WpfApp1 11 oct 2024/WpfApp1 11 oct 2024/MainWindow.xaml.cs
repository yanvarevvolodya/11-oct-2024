using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1_11_oct_2024
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик:\n" +
                "nedoprogrammist2006");
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

       

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            mainGrid.Background = Brushes.Red;
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            mainGrid.Background = Brushes.Green;
        }

        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {
            mainGrid.Background = Brushes.Blue;
        }

        private void RadioButton_Click_3(object sender, RoutedEventArgs e)
        {
            mainGrid.Background = Brushes.AliceBlue;
        }

        //строка состояния
        private void MenuItem_MouseEnter(object sender, MouseEventArgs e)
        {
            MenuItem menuItem = sender as MenuItem;
            if (menuItem != null)
            {
                textBlock1.Text = $"{menuItem.Header}";
            }
        }

        private void MenuItem_MouseLeave(object sender, MouseEventArgs e)
        {
            textBlock1.Text = "Строка состояния";
        }

    }
}