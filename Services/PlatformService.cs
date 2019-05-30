using System;
using Android.Views;
using TwogapWallet.Core.Services;

namespace TwogapWallet.Droid.Services
{
    public class PlatformService : IPlatformService
    {
        public PlatformService()
        {
        }

        public void HideStatusBar()
        {
            MainActivity.CurrentWindow.AddFlags(WindowManagerFlags.Fullscreen);
        }

        public void ShowStatusBar()
        {
            MainActivity.CurrentWindow.ClearFlags(WindowManagerFlags.Fullscreen);
        }
    }
}
