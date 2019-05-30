using System;
using System.Linq;
using Android.Content;
using Android.Graphics;
using TwogapWallet.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Color = Xamarin.Forms.Color;

[assembly: ExportRenderer(typeof(Button), typeof(CustomButtonRenderer))]
namespace TwogapWallet.Droid.CustomRenderers
{
    public class CustomButtonRenderer : ButtonRenderer
    {
        public CustomButtonRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            if (!e.NewElement.IsEnabled)
            {
                e.NewElement.FontFamily = "Arial Unicode.ttf";
                e.NewElement.TextColor = Color.Gray;
                e.NewElement.Text = e.NewElement.Text.First().ToString().ToUpper() + String.Join("", e.NewElement.Text.Skip(1));
            }
        }
    }
}
