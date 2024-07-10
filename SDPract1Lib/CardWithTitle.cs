using Android.Widget;
using Android.Content;
using Android.Views;

namespace SDPract1Lib
{
    public class CardWithTitle : LinearLayout
    {
        public CardWithTitle(Context context, bool isDark, string titleInput, string descriptionInput) : base(context)
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
            SetGravity(GravityFlags.CenterVertical | GravityFlags.CenterHorizontal);

            var textLayout = new LinearLayout(context);
            textLayout.Orientation = Orientation.Vertical;
            textLayout.LayoutParameters = new LinearLayout.LayoutParams(0, ViewGroup.LayoutParams.WrapContent, 1);

            var title = new TextView(Context);
            title.Text = titleInput;
            title.TextSize = 16;
            title.SetTextColor(Android.Graphics.Color.Black);
            Android.Graphics.Typeface typeface1 = Resources.GetFont(Resource.Font.Roboto);
            title.Typeface = typeface1;

            var description = new TextView(Context);
            description.Text = descriptionInput;
            description.TextSize = 14;
            description.SetTextColor(Android.Graphics.Color.Gray);
            description.SetPadding(0, 8, 0, 0);
            description.Typeface = typeface1;

            textLayout.AddView(title);
            textLayout.AddView(description);

            var imageLayout = new LinearLayout(context);
            imageLayout.Orientation = Orientation.Vertical;
            imageLayout.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);
            imageLayout.SetPadding(0, 0, 32, 0);

            var image = new ImageView(context);
            image.SetImageResource(Resource.Drawable.starblue);

            imageLayout.AddView(image);

            AddView(imageLayout);
            AddView(textLayout);
        }
    }
}
