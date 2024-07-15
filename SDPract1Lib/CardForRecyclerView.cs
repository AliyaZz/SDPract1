using Android.Content;
using Android.Views;

namespace SDPract1Lib
{
    public class CardForRecyclerView : LinearLayout
    {
        #region Fields

        string titleInput;

        string descriptionInput;

        LinearLayout textLayout;

        LinearLayout imageLayout;

        TextView title;

        TextView description;

        LinearLayout blockLayout;

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

        public CardForRecyclerView(Context context, bool isHorizontal) : base(context)
        {
            Android.Graphics.Typeface typeface1 = Resources.GetFont(Resource.Font.Roboto);
            textLayout = new LinearLayout(context)
            {
                LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent,1),
                Orientation = Orientation.Vertical
            };

            imageLayout = new LinearLayout(context)
            {
                Orientation = Orientation.Vertical,
                LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent),
               
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

            description = new TextView(context)
            {
                TextSize = 14,
                Typeface = typeface1
            };
            description.SetTextColor(Android.Graphics.Color.Gray);
            description.SetPadding(0, 8, 0, 0);

            textLayout.AddView(title);
            textLayout.AddView(description);

            if (isHorizontal)
            {
                textLayout.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent, 1);
                textLayout.SetGravity(GravityFlags.CenterVertical);
                imageLayout.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.MatchParent, 1);
                imageLayout.SetGravity(GravityFlags.Top);
                imageLayout.SetPadding(0, 40, 0, 0);
                title.SetTypeface(typeface1, Android.Graphics.TypefaceStyle.Bold);
                SetPadding(0, 0, 32, 0);
                var blockLayout = new LinearLayout(context)
                {
                    Orientation = Orientation.Vertical,
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.MatchParent)
                };
                blockLayout.SetPadding(40, 0, 0, 0);
                blockLayout.SetMinimumHeight(460);
                blockLayout.SetMinimumWidth(460);
                blockLayout.SetBackgroundResource(Resource.Drawable.scrollviewcards);
                blockLayout.AddView(imageLayout);
                blockLayout.AddView(textLayout);
                AddView(blockLayout);
            }
            else
            {
                AddView(imageLayout);
                AddView(textLayout);
                Orientation = Orientation.Horizontal;
                SetPadding(0, 0, 0, 50);
            }
        }

        #endregion

        #region PrivateMethods

        void UpdateTitle()
        {
            title.Text = titleInput;
        }

        void UpdateDescription()
        {
            description.Text = descriptionInput;
        }

        #endregion
    }
}
