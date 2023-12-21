using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for PicturePost.xaml
    /// </summary>
    public partial class PicturePost : UserControl
    {
        //TODO: Step 2: Change the constructor to take the model class as parameter
        //GOTO MockDb.cs
        public PicturePost(PicturePostModel inPicPostModel)
        {
            InitializeComponent();
            //TODO: Step 8: Set is as the source of the post's image
            //GOTO MainWindow.xaml.cs
            ImageOfPost.Source = inPicPostModel.PostsImage;
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
