using Android.Content;
using Android.Views;

namespace SDPract1Lib
{
    public class CardWithHeaderAndButton : LinearLayout
    {
        #region Fields

        bool isDark;

        string headerInput;

        string subheaderInput;

        string buttonInput;

        Context context;

        LinearLayout textLayout;

        LinearLayout buttonLayout;

        LinearLayout headerLayout;

        TextView header;

        TextView subheader;

        JustButton button;

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

        public string Header
        {
            get => headerInput; set
            {
                headerInput = value;
                UpdateHeader();
            }
        }

        public string Subheader
        {
            get => subheaderInput; set
            {
                subheaderInput = value;
                UpdateSubheader();
            }
        }

        public string BottomButton
        {
            get => buttonInput; 
            set 
            {
                button.ButtonInput = value;
                buttonLayout.Visibility = ViewStates.Visible;
            } 
        }

        #endregion

        #region ctor

        public CardWithHeaderAndButton(Context context) : base(context)
        {
            Orientation = Orientation.Vertical;
            SetPadding(48, 48, 48, 16);
            SetGravity(GravityFlags.Top | GravityFlags.CenterHorizontal);

            headerLayout = new LinearLayout(context);
            headerLayout.Orientation = Orientation.Horizontal;
            headerLayout.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);

            textLayout = new LinearLayout(context);
            textLayout.Orientation = Orientation.Vertical;
            textLayout.LayoutParameters = new LinearLayout.LayoutParams(0, ViewGroup.LayoutParams.WrapContent, 1);

            header = new TextView(Context);
            header.TextSize = 20;
            header.SetTextColor(Android.Graphics.Color.Black);
            Android.Graphics.Typeface typeface1 = Resources.GetFont(Resource.Font.RobotoBold);
            header.SetTypeface(typeface1, Android.Graphics.TypefaceStyle.Bold);
            header.Visibility = ViewStates.Gone;

            subheader = new TextView(Context);
            subheader.TextSize = 14;
            subheader.SetTextColor(Android.Graphics.Color.Gray);
            subheader.SetPadding(0, 20, 0, 0);
            Android.Graphics.Typeface typeface2 = Resources.GetFont(Resource.Font.Roboto);
            subheader.Typeface = typeface2;
            subheader.Visibility = ViewStates.Gone;

            textLayout.AddView(header);
            textLayout.AddView(subheader);

            image = new ImageView(context);
            image.SetImageResource(Resource.Drawable.starblue);

            headerLayout.AddView(textLayout);
            headerLayout.AddView(image);

            AddView(headerLayout);

            button = new JustButton(context);

            buttonLayout = new LinearLayout(context);
            buttonLayout.Orientation = Orientation.Vertical;
            buttonLayout.SetPadding(0, 32, 0, 32);
            buttonLayout.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
            buttonLayout.SetGravity(GravityFlags.Top);

            buttonLayout.AddView(button);
            buttonLayout.Visibility = ViewStates.Gone;

            AddView(buttonLayout);
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
