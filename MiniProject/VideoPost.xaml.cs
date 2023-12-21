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

namespace MiniProject
{
    /// <summary>
    /// Interaction logic for VideoPost.xaml
    /// </summary>
    public partial class VideoPost : UserControl
    {
        public VideoPost(VideoPostModel inModel)
        {
            InitializeComponent();
            VideoPlayer.Source = inModel.VideoPlayersSource;
        }

        private void ContentControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (!PostOps.PostLiked)
                PostOps.LikePost();
            else
                PostOps.UnLikePost();
        }
    }
}
