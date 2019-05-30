using System;
using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(NavigationPage), typeof(TwogapWallet.Droid.CustomRenderers.CustomNavigationPageRenderer))]
namespace TwogapWallet.Droid.CustomRenderers
{
    public class CustomNavigationPageRenderer : NavigationPageRenderer
    {
        public CustomNavigationPageRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<NavigationPage> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                e.NewElement.BarTextColor = Color.Black;
                e.NewElement.BarBackgroundColor = Color.White;
                NavigationPage.SetBackButtonTitle(e.NewElement, "Back");
            }
            if (e.OldElement != null)
            {
                e.OldElement.BarTextColor = Color.Black;
                e.OldElement.BarBackgroundColor = Color.White;
                NavigationPage.SetBackButtonTitle(e.OldElement, "Back");
            }
        }
    }
}
