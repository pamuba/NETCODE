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
    /// Interaction logic for ToolBarWindow.xaml
    /// </summary>
    public partial class ToolBarWindow : Window
    {
        public ToolBarWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myTxt.Text = "";
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cBox = (ComboBox)sender;
            ComboBoxItem cbItem = (ComboBoxItem)cBox.SelectedItem;
            string fontSize = (string)cbItem.Content;

            int temp;
            if (Int32.TryParse(fontSize, out temp)) {
                if (myTxt != null) {
                    myTxt.FontSize = temp;
                }
            }
        }
    }
}
