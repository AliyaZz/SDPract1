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
            Touch += Button_Click;
        }

        #endregion

        #region Events

        private async void Button_Click(object sender, TouchEventArgs e)
        {
            if (e.Event.Action == MotionEventActions.Up || e.Event.Action == MotionEventActions.Cancel)
            {
                SetBackgroundResource(Resource.Drawable.buttons);
            }
            if (e.Event.Action == MotionEventActions.Down)
            {
                SetBackgroundResource(Resource.Drawable.buttonhighlighted);
            }
        }

        #endregion
    }
}
