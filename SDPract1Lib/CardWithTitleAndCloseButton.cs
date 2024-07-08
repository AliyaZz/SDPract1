using Android.Widget;
using Android.Content;
using Android.Views;
using Android.OS;

namespace SDPract1Lib
{
    public class CardWithTitleAndCloseButton : LinearLayout
    {
        public CardWithTitleAndCloseButton(Context context, string titleInput = "Title", string descriptionInput = "Description") : base(context)
        {
            Orientation = Orientation.Horizontal;
            SetPadding(16, 16, 16, 16);
            SetBackgroundResource(Resource.Drawable.backgroundcardlight);
            Elevation = 40;

            LinearLayout mainLayout = new LinearLayout(context);
            mainLayout.Orientation = Orientation.Horizontal;
            mainLayout.SetPadding(32, 32, 32, 32);
            mainLayout.LayoutParameters = new LinearLayout.LayoutParams(0, ViewGroup.LayoutParams.WrapContent, 1);
            mainLayout.SetGravity(GravityFlags.CenterVertical | GravityFlags.CenterHorizontal);

            LinearLayout textLayout = new LinearLayout(context);
            textLayout.Orientation = Orientation.Vertical;
            textLayout.LayoutParameters = new LinearLayout.LayoutParams(0, ViewGroup.LayoutParams.WrapContent, 1);

            TextView title = new TextView(Context);
            title.Text = titleInput;
            title.TextSize = 16;
            title.SetTextColor(Android.Graphics.Color.Black);
            Android.Graphics.Typeface typeface1 = Resources.GetFont(Resource.Font.Roboto);
            title.Typeface = typeface1;

            TextView description = new TextView(Context);
            description.Text = descriptionInput;
            description.TextSize = 14;
            description.SetTextColor(Android.Graphics.Color.Gray);
            description.SetPadding(0, 8, 0, 0);
            description.Typeface = typeface1;

            textLayout.AddView(title);
            textLayout.AddView(description);

            LinearLayout imageLayout = new LinearLayout(context);
            imageLayout.Orientation = Orientation.Vertical;
            imageLayout.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);
            imageLayout.SetPadding(0, 0, 32, 0);

            ImageView image = new ImageView(context);
            image.SetImageResource(Resource.Drawable.starblue);

            imageLayout.AddView(image);

            LinearLayout buttonLayout = new LinearLayout(context);
            buttonLayout.Orientation = Orientation.Horizontal;
            buttonLayout.SetVerticalGravity(GravityFlags.Top);
            buttonLayout.SetHorizontalGravity(GravityFlags.End);

            ImageView closeButton = new ImageView(context);
            closeButton.SetBackgroundResource(Resource.Drawable.closebutton);
            buttonLayout.AddView(closeButton);

            mainLayout.AddView(imageLayout);
            mainLayout.AddView(textLayout);
            mainLayout.AddView(buttonLayout);

            AddView(mainLayout);
        }
    }
}
