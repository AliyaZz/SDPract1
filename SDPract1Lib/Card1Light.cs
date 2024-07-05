using Android.Widget;
using Android.Content;
using Android.Views;

namespace SDPract1Lib
{
    public class Card1Light : LinearLayout
    {
        public Card1Light(Context context) : base(context)
        {
            Orientation = Orientation.Horizontal;
            SetPadding(16, 16, 16, 16);
            SetBackgroundResource(Resource.Drawable.backgroundcardlight);
            Elevation = 40;

            LinearLayout linearLayout = new LinearLayout(context);
            linearLayout.Orientation = Orientation.Horizontal;
            linearLayout.SetPadding(40, 32, 40, 32);
            linearLayout.LayoutParameters = new LinearLayout.LayoutParams(0, ViewGroup.LayoutParams.WrapContent, 1f);
            linearLayout.SetGravity(GravityFlags.Top | GravityFlags.CenterHorizontal);

            LinearLayout linearLayout1 = new LinearLayout(context);
            linearLayout1.Orientation = Orientation.Vertical;
            linearLayout1.LayoutParameters = new LinearLayout.LayoutParams(0, ViewGroup.LayoutParams.WrapContent, 1f);

            TextView label = new TextView(Context);
            label.Text = "Header";
            label.TextSize = 20;
            label.SetTextColor(Android.Graphics.Color.Black);
            label.SetPadding(0, 0, 0, 0);
            Android.Graphics.Typeface typeface1 = this.Resources.GetFont(Resource.Font.RobotoBold);
            label.SetTypeface(typeface1, Android.Graphics.TypefaceStyle.Bold);

            TextView label1 = new TextView(Context);
            label1.Text = "Subheader";
            label1.TextSize = 14;
            label1.SetTextColor(Android.Graphics.Color.Gray);
            label1.SetPadding(0, 20, 0, 0);
            Android.Graphics.Typeface typeface2 = this.Resources.GetFont(Resource.Font.Roboto);
            label1.Typeface = typeface2;

            linearLayout1.AddView(label);
            linearLayout1.AddView(label1);

            ImageView imageView = new ImageView(context);
            imageView.SetImageResource(Resource.Drawable.starblue);
            imageView.SetMinimumHeight(130);
            imageView.SetMinimumWidth(130);
            
            linearLayout.AddView(linearLayout1);
            linearLayout.AddView(imageView);

            AddView(linearLayout);
        }
    }
}
