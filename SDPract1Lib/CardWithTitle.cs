using Android.Content;
using Android.Views;

namespace SDPract1Lib
{
    public class CardWithTitle : LinearLayout
    {
        #region Fields

        string titleInput;

        string descriptionInput;

        bool isDark;

        LinearLayout textLayout;

        LinearLayout imageLayout;

        TextView title;

        TextView description;

        ImageView image;

        #endregion

        #region Properties

        public bool IsDark
        {
            get => isDark; set
            {
                isDark = value;
                UpdateDark();
            }
        }

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

        public CardWithTitle(Context context) : base(context)
        {
            Orientation = Orientation.Horizontal;
            SetPadding(48, 48, 48, 48);
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

            AddView(imageLayout);
            AddView(textLayout);
        }

        #endregion

        #region Private methods

        void UpdateDark()
        {
            if (isDark == false)
            {
                SetBackgroundResource(Resource.Drawable.backgroundcardlight);
                Elevation = 40;
            }
            else
            {
                SetBackgroundResource(Resource.Drawable.backgroundcarddark);
            }
        }

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
