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

namespace DependencyDemo
{
    /// <summary>
    /// Interaction logic for MyUC.xaml
    /// </summary>
    public partial class MyUC : UserControl
    {


        public int Awesomeness
        {
            get { return (int)GetValue(AwesomenessProperty); }
            set { SetValue(AwesomenessProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Awesomeness.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AwesomenessProperty =
            DependencyProperty.Register("Awesomeness", typeof(int), typeof(MyUC), new PropertyMetadata(0));


        public MyUC()
        {
            InitializeComponent();
        }
    }
}
