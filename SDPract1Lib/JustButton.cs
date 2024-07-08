using Android.Widget;
using Android.Content;
using Android.Views;
using Android.Content.Res;

namespace SDPract1Lib
{
    public class JustButton : Button
    {
        public JustButton(Context context, bool isHighlighted, string buttonInput = "Button") : base(context)
        {
            Text = buttonInput;
            Android.Graphics.Typeface typeface1 = Resources.GetFont(Resource.Font.Roboto);
            Typeface = typeface1;
            TextSize = 14;
            SetTextColor(Android.Graphics.Color.Rgb(66, 139, 249));
            if (isHighlighted)
            {
                SetBackgroundResource(Resource.Drawable.buttonhighlighted);
            }
            else
            {
                SetBackgroundResource(Resource.Drawable.buttons);
            }
        }
    }
}
