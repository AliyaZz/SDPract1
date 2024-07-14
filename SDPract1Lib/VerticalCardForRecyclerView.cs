using Android.Widget;
using Android.Content;
using Android.Views;
using Android.OS;
using Android.Graphics;
using Android.Graphics.Drawables;
using System.Numerics;
using static Android.Preferences.PreferenceActivity;

namespace SDPract1Lib
{
    public class VerticalCardForRecyclerView : LinearLayout
    {
        string titleInput;
        string descriptionInput;
        bool isDark;

        LinearLayout textLayout;
        LinearLayout imageLayout;
        TextView title;
        TextView description;
        LinearLayout blockLayout;

        public bool IsDark
        {
            get => isDark; 
            set 
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

        public VerticalCardForRecyclerView(Context context) : base(context)
        {
            Android.Graphics.Typeface typeface1 = Resources.GetFont(Resource.Font.Roboto);
            textLayout = new LinearLayout(context)
            {
                LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent),
                Orientation = Orientation.Vertical
            };
            imageLayout = new LinearLayout(context)
            {
                Orientation = Orientation.Vertical,
                LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent)
            };
            imageLayout.SetPadding(0, 0, 32, 0);
            var imageView = new ImageView(context);
            imageView.SetImageResource(Resource.Drawable.starblue);
            imageLayout.AddView(imageView);
            title = new TextView(context)
            {
                TextSize = 16,
                Typeface = typeface1,
            };
            title.SetTextColor(Android.Graphics.Color.Black);
            title.Visibility = ViewStates.Gone;

            description = new TextView(context)
            {
                TextSize = 14,
                Typeface = typeface1
            };
            description.SetTextColor(Android.Graphics.Color.Gray);
            description.SetPadding(0, 8, 0, 0);
            description.Visibility = ViewStates.Gone;

            textLayout.AddView(title);
            textLayout.AddView(description);

            blockLayout = new LinearLayout(context)
            {
                Orientation = Orientation.Horizontal,
                LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.MatchParent)
            };
            blockLayout.SetPadding(0, 0, 0, 50);
            blockLayout.SetGravity(GravityFlags.CenterVertical);
        }

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
    }
}
