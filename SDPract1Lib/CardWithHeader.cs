using Android.Widget;
using Android.Content;
using Android.Views;

namespace SDPract1Lib
{
    public class CardWithHeader : LinearLayout
    {
        public CardWithHeader(Context context, bool isDark, string headerInput, string subheaderInput) : base(context)
        {
            Orientation = Orientation.Horizontal;
            SetPadding(48, 48, 48, 48);
            if (isDark == false)
            {
                SetBackgroundResource(Resource.Drawable.backgroundcardlight);
                Elevation = 40;
            }
            else
            {
                SetBackgroundResource(Resource.Drawable.backgroundcarddark);
            }
            LayoutParameters = new LinearLayout.LayoutParams(0, ViewGroup.LayoutParams.WrapContent, 1);
            SetGravity(GravityFlags.CenterVertical | GravityFlags.CenterHorizontal);

            var textLayout = new LinearLayout(context);
            textLayout.Orientation = Orientation.Vertical;
            textLayout.LayoutParameters = new LinearLayout.LayoutParams(0, ViewGroup.LayoutParams.WrapContent, 1);

            var header = new TextView(Context);
            header.Text = headerInput;
            header.TextSize = 20;
            header.SetTextColor(Android.Graphics.Color.Black);
            header.SetPadding(0, 0, 0, 0);
            Android.Graphics.Typeface typeface1 = Resources.GetFont(Resource.Font.RobotoBold);
            header.SetTypeface(typeface1, Android.Graphics.TypefaceStyle.Bold);
            textLayout.AddView(header);

            if (string.IsNullOrEmpty(subheaderInput))
            {
                var subheader = new TextView(Context);
                subheader.Text = subheaderInput;
                subheader.TextSize = 14;
                subheader.SetTextColor(Android.Graphics.Color.Gray);
                subheader.SetPadding(0, 20, 0, 0);
                Android.Graphics.Typeface typeface2 = Resources.GetFont(Resource.Font.Roboto);
                textLayout.AddView(subheader);
                subheader.Typeface = typeface2;
                SetGravity(GravityFlags.Top);
            }
            var image = new ImageView(context);
            image.SetImageResource(Resource.Drawable.starblue);
            
            AddView(textLayout);
            AddView(image);
        }
    }
}
