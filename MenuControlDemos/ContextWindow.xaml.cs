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
using System.Windows.Shapes;

namespace MenuControlDemos
{
    /// <summary>
    /// Interaction logic for ContextWindow.xaml
    /// </summary>
    public partial class ContextWindow : Window
    {
        public ContextWindow()
        {
            InitializeComponent();
        }

        private void miItalic_Click(object sender, RoutedEventArgs e)
        {
            myTxt.FontStyle = FontStyles.Italic;
        }

        private void miBold_Checked(object sender, RoutedEventArgs e)
        {
            myTxt.FontWeight = FontWeights.Bold;
        }

        private void miBold_Unchecked(object sender, RoutedEventArgs e)
        {
            myTxt.FontWeight = FontWeights.Normal;
        }
    }
}
