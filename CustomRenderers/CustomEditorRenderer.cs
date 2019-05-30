using System;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Color = Xamarin.Forms.Color;

[assembly: ExportRenderer(typeof(Editor), typeof(TwogapWallet.Droid.CustomRenderers.CustomEditorRenderer))]
namespace TwogapWallet.Droid.CustomRenderers
{
    public class CustomEditorRenderer : EditorRenderer
    {
        public CustomEditorRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.Transparent);
                Control.SetPadding(0, 0, 0, 0);
                Control.SetHintTextColor(ColorStateList.ValueOf(global::Android.Graphics.Color.White));
            }
            if (e.NewElement != null)
            {
                e.NewElement.PlaceholderColor = Color.FromHex("afafaf");
                e.NewElement.FontFamily = "Arial Unicode.ttf";
            }
        }
    }
}
