using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using TwogapWallet.Core;
using Xamarin.Forms;
using Android.Support.V4.Content;
using Android.Support.V4.Content.Res;
using MvvmCross.Forms.Platforms.Android.Views;
using MvvmCross.Forms.Platforms.Android.Core;
using TwogapWallet.UI;

namespace TwogapWallet.Droid
{
    [Activity(Label = "Twogap Wallet", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : MvxFormsAppCompatActivity<MvxFormsAndroidSetup<App, FormsApp>, App, FormsApp>//global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            CurrentWindow = Window;

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            //CarouselView.FormsPlugin.Android.CarouselViewRenderer.Init();
            base.OnCreate(bundle);

            Xamarin.Essentials.Platform.Init(this, bundle);
            global::Xamarin.Forms.Forms.Init(this, bundle);

            Window.SetStatusBarColor(Android.Graphics.Color.White);
            Window.SetTitleColor(Android.Graphics.Color.Black);
            Window.SetNavigationBarColor(Android.Graphics.Color.White);

            MvvmCross.Mvx.IoCProvider.RegisterType<Core.Services.IPlatformService, Services.PlatformService>();
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public static Window CurrentWindow;
    }
}