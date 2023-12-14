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

namespace Events_Delegates
{
    /// <summary>
    /// Interaction logic for ValueControl.xaml
    /// </summary>
    public partial class ValueControl : UserControl
    {
        public delegate void OnMinReached(object sender, RoutedEventArgs e);
        public event OnMinReached MinReached;
        public ValueControl()
        {
            InitializeComponent();
        }

        private void Inc_Button_Click(object sender, RoutedEventArgs e)
        {
            ValueLabel.Text = (Int32.Parse(ValueLabel.Text) + 10).ToString();
        }

        private void Dec_Button_Click(object sender, RoutedEventArgs e)
        {
            ValueLabel.Text = (Int32.Parse(ValueLabel.Text) - 10).ToString();
        }

        private void ValueLabel_TextChanged(object sender, TextChangedEventArgs e)
        {
            //MessageBox.Show("Value Changed");
            if(Int32.Parse((sender as TextBox).Text) < 0){
                (sender as TextBox).Text = "0";
                MinReached(sender, e);
            }
        }
    }
}
