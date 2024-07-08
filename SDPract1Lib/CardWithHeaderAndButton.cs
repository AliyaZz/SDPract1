using Android.Widget;
using Android.Content;
using Android.Views;

namespace SDPract1Lib
{
    public class CardWithHeaderAndButton : LinearLayout
    {
        public CardWithHeaderAndButton(Context context, bool isDark, string headerInput = "Header", string subheaderInput = "Subheader", string buttonInput = "Button") : base(context)
        {
            Orientation = Orientation.Vertical;
            SetPadding(16, 16, 16, 16);

            LinearLayout mainTextLayout = new LinearLayout(context);
            mainTextLayout.Orientation = Orientation.Horizontal;
            mainTextLayout.SetPadding(32, 32, 32, 0);
            mainTextLayout.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
            mainTextLayout.SetGravity(GravityFlags.Top | GravityFlags.CenterHorizontal);

            LinearLayout textLayout = new LinearLayout(context);
            textLayout.Orientation = Orientation.Vertical;
            textLayout.LayoutParameters = new LinearLayout.LayoutParams(0, ViewGroup.LayoutParams.WrapContent, 1);

            TextView header = new TextView(Context);
            header.Text = headerInput;
            header.TextSize = 20;
            header.SetTextColor(Android.Graphics.Color.Black);
            header.SetPadding(0, 0, 0, 0);
            Android.Graphics.Typeface typeface1 = Resources.GetFont(Resource.Font.RobotoBold);
            header.SetTypeface(typeface1, Android.Graphics.TypefaceStyle.Bold);

            TextView subheader = new TextView(Context);
            subheader.Text = subheaderInput;
            subheader.TextSize = 14;
            subheader.SetTextColor(Android.Graphics.Color.Gray);
            subheader.SetPadding(0, 20, 0, 0);
            Android.Graphics.Typeface typeface2 = Resources.GetFont(Resource.Font.Roboto);
            subheader.Typeface = typeface2;

            textLayout.AddView(header);
            textLayout.AddView(subheader);

            ImageView image = new ImageView(context);
            image.SetImageResource(Resource.Drawable.starblue);

            mainTextLayout.AddView(textLayout);
            mainTextLayout.AddView(image);

            AddView(mainTextLayout);

            Button button = new Button(context);
            button.Text = buttonInput;
            button.Typeface = typeface2;
            button.TextSize = 14;
            button.SetTextColor(Android.Graphics.Color.Rgb(66, 139, 249));

            if (isDark == false)
            {
                SetBackgroundResource(Resource.Drawable.backgroundcardlight);
                Elevation = 40;
                button.SetBackgroundResource(Resource.Drawable.buttonlight);
            }
            else
            {
                SetBackgroundResource(Resource.Drawable.backgroundcarddark);
                button.SetBackgroundResource(Resource.Drawable.buttondark);
            }

            LinearLayout buttonLayout = new LinearLayout(context);
            buttonLayout.Orientation = Orientation.Vertical;
            buttonLayout.SetPadding(32, 32, 32, 32);
            buttonLayout.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
            buttonLayout.SetGravity(GravityFlags.Top);

            buttonLayout.AddView(button);

            AddView(buttonLayout);
        }
    }
}
