using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Grouping
{
    [Preserve(AllMembers = true)]
    public class ListViewGalleryInfoRepository
    {
        #region Constructor

        public ListViewGalleryInfoRepository()
        {

        }

        #endregion

        #region GetGalleryInfo

        internal ObservableCollection<ListViewGalleryInfo> GetGalleryInfo()
        {
            var galleryInfo = new ObservableCollection<ListViewGalleryInfo>();
            var random = new Random();
            Assembly assembly = typeof(GroupingPage).GetTypeInfo().Assembly;
            for (int i = 1; i <= 30; i++)
            {
                var gallery = new ListViewGalleryInfo()
                {
                    Image = ImageSource.FromResource("Grouping.Images.Image" + i + ".png", assembly),
                    ImageTitle = "IMG_" + random.Next(1242, 5383) + ".jpg",
                };
                galleryInfo.Add(gallery);
            }
            return galleryInfo;
        }
        
        #endregion
    }
}
