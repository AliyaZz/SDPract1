using Android.Content;
using Android.Views;
using Android.Content.Res;

namespace SDPract1Lib
{
    public class JustButton : Button
    {
        #region Fields

        bool isHighlighted;

        string buttonInput;

        Context context;

        #endregion

        #region Properties

        public bool IsHighlighted
        {
            get => isHighlighted;
            set => isHighlighted = value;
        }

        public string ButtonInput
        {
            get => buttonInput;
            set
            {
                buttonInput = value;
                Text = value;
                Visibility = ViewStates.Visible;
            }
        }

        #endregion

        #region ctor

        public JustButton(Context context) : base(context)
        {
            LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
            Typeface = Resources.GetFont(Resource.Font.Roboto);
            TextSize = 14;
            SetTextColor(Android.Graphics.Color.Rgb(66, 139, 249));
            SetBackgroundResource(Resource.Drawable.buttons);
            Click += Button_Click;
        }

        #endregion

        #region Events

        private void Button_Click(object? sender, EventArgs e)
        {
            Button button = sender as Button;
            button.SetBackgroundResource(Resource.Drawable.buttonhighlighted);
        }

        #endregion
    }
}
