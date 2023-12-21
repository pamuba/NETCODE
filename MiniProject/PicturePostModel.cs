using System.Windows.Media.Imaging;

namespace MiniProject
{
    public class PicturePostModel
    {
        //TODO: Step 7: Use the newly created GetPostPicture function in order to
        //properly define this property
        //GOTO PicturePost.xaml.cs
        BitmapImage _postsImage;
        public BitmapImage PostsImage 
        { 
            get
            {
                if (_postsImage == null)
                    return MockDb.GetPostPicture();
                else
                    return _postsImage;
            }
            set
            {
                _postsImage = value;
            }
        }
    }
}
