using Android.Content;
using Android.Views;
using Android.Content.Res;
using Java.Lang;
using Android.Widget;
using Android.Views.Animations;

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

        private async void Button_Click(object sender, EventArgs e)
        {
            SetBackgroundResource(Resource.Drawable.buttonhighlighted);
            await Task.Delay(100);
            SetBackgroundResource(Resource.Drawable.buttons);
        }

        #endregion
    }
}
