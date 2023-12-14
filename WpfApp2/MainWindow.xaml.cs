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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            myTextBlock.Text = "Hello from the CS Side";
            myTextBlock.Foreground = Brushes.Blue;

            TextBlock mytb = new TextBlock();
            mytb.Text = "Hello Wold!!";
            mytb.Inlines.Add("this is added using inlines");
            mytb.Inlines.Add(new Run("Run text that we added in Code Behind")
            {

                Foreground = Brushes.Blue,
                TextDecorations = TextDecorations.Underline

            });
            mytb.TextWrapping = TextWrapping.Wrap;
            //replpace the second textblock
            this.Content = mytb;
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }
    }
}
