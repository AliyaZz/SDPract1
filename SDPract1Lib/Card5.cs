using Android.Widget;
using Android.Content;
using Android.Views;
using Android.OS;

namespace SDPract1Lib
{
    public class Card5 : LinearLayout
    {
        public Card5(Context context) : base(context)
        {
            Orientation = Orientation.Horizontal;
            SetPadding(16, 16, 16, 16);
            SetBackgroundResource(Resource.Drawable.backgroundcardlight);
            Elevation = 40;

            LinearLayout linearLayout = new LinearLayout(context);
            linearLayout.Orientation = Orientation.Horizontal;
            linearLayout.SetPadding(32, 32, 32, 32);
            linearLayout.LayoutParameters = new LinearLayout.LayoutParams(0, ViewGroup.LayoutParams.WrapContent, 1f);
            linearLayout.SetGravity(GravityFlags.Top | GravityFlags.CenterHorizontal);

            LinearLayout linearLayout1 = new LinearLayout(context);
            linearLayout1.Orientation = Orientation.Vertical;
            linearLayout1.LayoutParameters = new LinearLayout.LayoutParams(0, ViewGroup.LayoutParams.WrapContent, 1f);

            TextView label = new TextView(Context);
            label.Text = "Title";
            label.TextSize = 16;
            label.SetTextColor(Android.Graphics.Color.Black);
            Android.Graphics.Typeface typeface1 = this.Resources.GetFont(Resource.Font.Roboto);
            label.Typeface = typeface1;

            TextView label1 = new TextView(Context);
            label1.Text = "Description";
            label1.TextSize = 14;
            label1.SetTextColor(Android.Graphics.Color.Gray);
            label1.SetPadding(0, 8, 0, 0);
            label1.Typeface = typeface1;

            linearLayout1.AddView(label);
            linearLayout1.AddView(label1);

            LinearLayout linearLayout2 = new LinearLayout(context);
            linearLayout2.Orientation = Orientation.Vertical;
            linearLayout2.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);
            linearLayout2.SetPadding(0, 0, 32, 0);

            ImageView imageView = new ImageView(context);
            imageView.SetImageResource(Resource.Drawable.starblue);
            imageView.SetMinimumHeight(130);
            imageView.SetMinimumWidth(130);

            linearLayout2.AddView(imageView);

            LinearLayout linearLayout3 = new LinearLayout(context);
            linearLayout3.Orientation = Orientation.Horizontal;
            linearLayout3.SetVerticalGravity(GravityFlags.Top);
            linearLayout3.SetHorizontalGravity(GravityFlags.End);
            //linearLayout3.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);

            ImageView button = new ImageView(context);
            button.SetBackgroundResource(Resource.Drawable.closebutton);
            //button.SetMaxHeight(20);
            //button.SetMaxWidth(20);
            linearLayout3.AddView(button);

            linearLayout.AddView(linearLayout2);
            linearLayout.AddView(linearLayout1);
            linearLayout.AddView(linearLayout3);

            AddView(linearLayout);
        }
    }
}
