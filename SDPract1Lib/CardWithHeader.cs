using Android.Widget;
using Android.Content;
using Android.Views;
using Android.Hardware;

namespace SDPract1Lib
{
    public class CardWithHeader : LinearLayout
    {
        #region Fields

        bool isDark;

        string headerInput;

        string subheaderInput;

        Context context;

        #region Internal Fields

        LinearLayout textLayout;

        TextView header;

        TextView subheader;

        ImageView image;

        #endregion

        #endregion

        #region Properties

        public bool IsDark { get => isDark; set
            {
                isDark = value;
                UpdateDark();
            }
        }

        public string Header { get => headerInput; set
            {
                headerInput = value;
                UpdateHeader();
            }
        }

        public string Subheader { get => subheaderInput; set
            {
                subheaderInput = value;
                UpdateSubheader();
            }
        }

        #endregion

        #region ctor

        public CardWithHeader(Context context) : base(context)
        {
            this.context = context;
            Orientation = Orientation.Horizontal;
            SetPadding(48, 48, 48, 48);
            SetGravity(GravityFlags.CenterVertical | GravityFlags.CenterHorizontal);

            textLayout = new LinearLayout(context);
            textLayout.Orientation = Orientation.Vertical;
            textLayout.LayoutParameters = new LinearLayout.LayoutParams(0, ViewGroup.LayoutParams.WrapContent, 1);

            header = new TextView(context);
            header.TextSize = 20;
            header.SetTextColor(Android.Graphics.Color.Black);
            Android.Graphics.Typeface typeface1 = Resources.GetFont(Resource.Font.RobotoBold);
            header.SetTypeface(typeface1, Android.Graphics.TypefaceStyle.Bold);
            textLayout.AddView(header);
            header.Visibility = ViewStates.Gone;

            subheader = new TextView(context);
            subheader.TextSize = 14;
            subheader.SetTextColor(Android.Graphics.Color.Gray);
            Android.Graphics.Typeface typeface2 = Resources.GetFont(Resource.Font.Roboto);
            subheader.Typeface = typeface2;
            subheader.SetPadding(0, 20, 0, 0);
            textLayout.AddView(subheader);
            subheader.Visibility = ViewStates.Gone;

            image = new ImageView(context);
            image.SetImageResource(Resource.Drawable.starblue);
            
            AddView(textLayout);
            AddView(image);
        }

        #endregion

        #region Methods

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

        void UpdateHeader()
        {
            header.Text = headerInput;
            header.Visibility = ViewStates.Visible;
        }

        void UpdateSubheader()
        {
            subheader.Text = subheaderInput;
            SetGravity(GravityFlags.Top);
            subheader.Visibility = ViewStates.Visible;
        }

        #endregion
    }
}
