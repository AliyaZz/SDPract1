using Android.Content;
using Android.Views;

namespace SDPract1Lib
{
    public class CardWithTitleAndCloseButton : LinearLayout
    {
        #region Fields

        string titleInput;

        string descriptionInput;

        LinearLayout textLayout;

        LinearLayout imageLayout;

        LinearLayout layoutToMakeButtonHigher;

        LinearLayout buttonLayout;

        TextView title;

        TextView description;

        Button closeButton;

        ImageView image;

        #endregion

        #region Properties

        public string Title
        {
            get => titleInput;
            set
            {
                titleInput = value;
                UpdateTitle();
            }
        }

        public string Description
        {
            get => descriptionInput;
            set
            {
                descriptionInput = value;
                UpdateDescription();
            }
        }

        #endregion

        #region ctor

        public CardWithTitleAndCloseButton(Context context) : base(context)
        {
            Orientation = Orientation.Horizontal;
            SetPadding(48, 48, 48, 48);
            SetBackgroundResource(Resource.Drawable.backgroundcardlight);
            Elevation = 40;
            SetGravity(GravityFlags.CenterVertical | GravityFlags.CenterHorizontal);

            textLayout = new LinearLayout(context);
            textLayout.Orientation = Orientation.Vertical;
            textLayout.LayoutParameters = new LinearLayout.LayoutParams(0, ViewGroup.LayoutParams.WrapContent, 1);

            title = new TextView(Context);
            title.TextSize = 16;
            title.SetTextColor(Android.Graphics.Color.Black);
            Android.Graphics.Typeface typeface1 = Resources.GetFont(Resource.Font.Roboto);
            title.Typeface = typeface1;
            title.Visibility = ViewStates.Gone;

            description = new TextView(Context);
            description.TextSize = 14;
            description.SetTextColor(Android.Graphics.Color.Gray);
            description.SetPadding(0, 8, 0, 0);
            description.Typeface = typeface1;
            description.Visibility = ViewStates.Gone;

            textLayout.AddView(title);
            textLayout.AddView(description);

            imageLayout = new LinearLayout(context);
            imageLayout.Orientation = Orientation.Vertical;
            imageLayout.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);
            imageLayout.SetPadding(0, 0, 32, 0);

            image = new ImageView(context);
            image.SetImageResource(Resource.Drawable.starblue);

            imageLayout.AddView(image);

            layoutToMakeButtonHigher = new LinearLayout(context);
            layoutToMakeButtonHigher.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.MatchParent);
            layoutToMakeButtonHigher.SetVerticalGravity(GravityFlags.Top);

            buttonLayout = new LinearLayout(context);
            buttonLayout.Orientation = Orientation.Horizontal;
            buttonLayout.LayoutParameters = new LinearLayout.LayoutParams(64, 64);

            closeButton = new Button(context);
            closeButton.SetBackgroundResource(Resource.Drawable.closebutton);
            buttonLayout.AddView(closeButton);

            layoutToMakeButtonHigher.AddView(buttonLayout);

            AddView(imageLayout);
            AddView(textLayout);
            AddView(layoutToMakeButtonHigher);
        }

        #endregion

        #region Private methods

        void UpdateTitle()
        {
            title.Text = titleInput;
            title.Visibility = ViewStates.Visible;
        }

        void UpdateDescription()
        {
            description.Text = descriptionInput;
            description.Visibility = ViewStates.Visible;
        }

        #endregion
    }
}
