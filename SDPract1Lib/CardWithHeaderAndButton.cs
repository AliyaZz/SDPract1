using Android.Widget;
using Android.Content;
using Android.Views;

namespace SDPract1Lib
{
    public class CardWithHeaderAndButton : LinearLayout
    {
        #region Fields

        Context context;

        #region Internal Fields

        #endregion

        #endregion

        #region Properties



        #endregion

        #region ctor

        #endregion

        #region Methods

        #endregion
        public CardWithHeaderAndButton(Context context, bool isDark, string headerInput, string subheaderInput, string buttonInput) : base(context)
        {
            Orientation = Orientation.Vertical;
            SetPadding(48, 48, 48, 16);
            SetGravity(GravityFlags.Top | GravityFlags.CenterHorizontal);

            var headerLayout = new LinearLayout(context);
            headerLayout.Orientation = Orientation.Horizontal;
            headerLayout.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);

            var textLayout = new LinearLayout(context);
            textLayout.Orientation = Orientation.Vertical;
            textLayout.LayoutParameters = new LinearLayout.LayoutParams(0, ViewGroup.LayoutParams.WrapContent, 1);

            var header = new TextView(Context);
            header.Text = headerInput;
            header.TextSize = 20;
            header.SetTextColor(Android.Graphics.Color.Black);
            header.SetPadding(0, 0, 0, 0);
            Android.Graphics.Typeface typeface1 = Resources.GetFont(Resource.Font.RobotoBold);
            header.SetTypeface(typeface1, Android.Graphics.TypefaceStyle.Bold);

            var subheader = new TextView(Context);
            subheader.Text = subheaderInput;
            subheader.TextSize = 14;
            subheader.SetTextColor(Android.Graphics.Color.Gray);
            subheader.SetPadding(0, 20, 0, 0);
            Android.Graphics.Typeface typeface2 = Resources.GetFont(Resource.Font.Roboto);
            subheader.Typeface = typeface2;

            textLayout.AddView(header);
            textLayout.AddView(subheader);

            var image = new ImageView(context);
            image.SetImageResource(Resource.Drawable.starblue);

            headerLayout.AddView(textLayout);
            headerLayout.AddView(image);

            AddView(headerLayout);

            var button = new Button(context);
            button.Text = buttonInput;
            button.Typeface = typeface2;
            button.TextSize = 14;
            button.SetTextColor(Android.Graphics.Color.Rgb(66, 139, 249));
            button.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);

            if (isDark == false)
            {
                SetBackgroundResource(Resource.Drawable.backgroundcardlight);
                Elevation = 40;
            }
            else
            {
                SetBackgroundResource(Resource.Drawable.backgroundcarddark);
                
            }
            button.SetBackgroundResource(Resource.Drawable.buttons);

            var buttonLayout = new LinearLayout(context);
            buttonLayout.Orientation = Orientation.Vertical;
            buttonLayout.SetPadding(0, 32, 0, 32);
            buttonLayout.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
            buttonLayout.SetGravity(GravityFlags.Top);

            buttonLayout.AddView(button);

            AddView(buttonLayout);
        }
    }
}
