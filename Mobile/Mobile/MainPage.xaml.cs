using FFImageLoading.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mobile
{
    public partial class MainPage : ContentPage
    {
        public string ImgUrl { get; set; } 
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            SetImage();
        }

        private async void InvalidatedImgCach_Clicked(object sender, EventArgs e)
        {
            await CachedImage.InvalidateCache(ImgUrl, FFImageLoading.Cache.CacheType.All);
            SetImage();
        }

        private void SetImage()
        {
            ImgUrl = string.Empty;
            ImgUrl = "https://placeimg.com/640/480/animals";
        }
    }
}
