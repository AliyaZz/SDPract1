using Android.Widget;
using Android.Content;
using Android.Views;
using Android.OS;

namespace SDPract1Lib
{
    public class CardWithTitleAndCloseButton : LinearLayout
    {
        public CardWithTitleAndCloseButton(Context context, string titleInput, string descriptionInput) : base(context)
        {
            Orientation = Orientation.Horizontal;
            SetPadding(48, 48, 48, 48);
            SetBackgroundResource(Resource.Drawable.backgroundcardlight);
            Elevation = 40;
            LayoutParameters = new LinearLayout.LayoutParams(0, ViewGroup.LayoutParams.WrapContent, 1);
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

            var layoutToMakeButtonHigher = new LinearLayout(context);
            layoutToMakeButtonHigher.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.MatchParent);
            layoutToMakeButtonHigher.SetVerticalGravity(GravityFlags.Top);

            var buttonLayout = new LinearLayout(context);
            buttonLayout.Orientation = Orientation.Horizontal;
            buttonLayout.LayoutParameters = new LinearLayout.LayoutParams(64, 64);
            
            var closeButton = new Button(context);
            closeButton.SetBackgroundResource(Resource.Drawable.closebutton);
            buttonLayout.AddView(closeButton);

            layoutToMakeButtonHigher.AddView(buttonLayout);

            AddView(imageLayout);
            AddView(textLayout);
            AddView(layoutToMakeButtonHigher);
        }
    }
}
