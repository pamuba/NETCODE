using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace MiniProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random Generator;
        public MainWindow()
        {
            InitializeComponent();
            Generator = new Random(DateTime.Now.Millisecond);
            MainStackPanel.Children.Add(new VideoPost(new VideoPostModel()));
            MainStackPanel.Children.Add(new PicturePost(new PicturePostModel()));
            MainStackPanel.Children.Add(new VideoPost(new VideoPostModel()));
            MainStackPanel.Children.Add(new PicturePost(new PicturePostModel()));
        }
    }
}
