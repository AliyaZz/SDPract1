using Android.Widget;
using Android.Content;
using Android.Views;

namespace SDPract1Lib
{
    public class CardWithHeader : LinearLayout
    {
        public CardWithHeader(Context context, bool isDark, string headerInput = "Header", string subheaderInput = "Undefined") : base(context)
        {
            Orientation = Orientation.Horizontal;
            SetPadding(16, 16, 16, 16);
            if (isDark == false)
            {
                SetBackgroundResource(Resource.Drawable.backgroundcardlight);
                Elevation = 40;
            }
            else
            {
                SetBackgroundResource(Resource.Drawable.backgroundcarddark);
            }
            var mainLayout = new LinearLayout(context);
            mainLayout.Orientation = Orientation.Horizontal;
            mainLayout.SetPadding(32, 32, 32, 32);
            mainLayout.LayoutParameters = new LinearLayout.LayoutParams(0, ViewGroup.LayoutParams.WrapContent, 1);
            mainLayout.SetGravity(GravityFlags.CenterVertical | GravityFlags.CenterHorizontal);

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

            if (subheaderInput != "Undefined")
            {
                var subheader = new TextView(Context);
                subheader.Text = subheaderInput;
                subheader.TextSize = 14;
                subheader.SetTextColor(Android.Graphics.Color.Gray);
                subheader.SetPadding(0, 20, 0, 0);
                Android.Graphics.Typeface typeface2 = Resources.GetFont(Resource.Font.Roboto);
                textLayout.AddView(subheader);
                subheader.Typeface = typeface2;
                mainLayout.SetPadding(32, 32, 32, 32);
                mainLayout.SetGravity(GravityFlags.Top);
            }

            var image = new ImageView(context);
            image.SetImageResource(Resource.Drawable.starblue);
            
            mainLayout.AddView(textLayout);
            mainLayout.AddView(image);

            AddView(mainLayout);
        }
    }
}
