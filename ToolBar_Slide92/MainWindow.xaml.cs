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

namespace ToolBar_Slide92
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
        private void IncreaseFont_Click(object sender, RoutedEventArgs e)
        {

            if (textBox.FontSize < 48) 
            {
                textBox.FontSize += 2;
            }
        }


        private void DecreaseFont_Click(object sender, RoutedEventArgs e)
        {

            if (textBox.FontSize > 8) 
            {
                textBox.FontSize -= 2;
            }
        }

        private void Bold_Checked(object sender, RoutedEventArgs e)
        {
            textBox.FontWeight = FontWeights.Bold; 
        }

        private void Bold_Unchecked(object sender, RoutedEventArgs e)
        {
            textBox.FontWeight = FontWeights.Normal; 
        }

        // Toggle italic font style
        private void Italic_Checked(object sender, RoutedEventArgs e)
        {
            textBox.FontStyle = FontStyles.Italic; 
        }

        private void Italic_Unchecked(object sender, RoutedEventArgs e)
        {
            textBox.FontStyle = FontStyles.Normal; 
        }
    }
}