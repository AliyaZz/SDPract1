using static Android.Views.ViewGroup;

namespace SDPract1
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_main);
            //SetWallpaper(Android.Graphics.Bitmap())
            ActionBar.Hide();

            LinearLayout linearLayout = new LinearLayout(BaseContext)
            {
                Orientation = Orientation.Vertical
            };
            linearLayout.SetClipToPadding(false);
            linearLayout.SetClipChildren(false);

            LinearLayout linearLayout2 = new LinearLayout(BaseContext);
            linearLayout2.SetClipToPadding(false);
            linearLayout2.SetClipChildren(false);

            linearLayout.SetPadding(40, 40, 40, 40);

            AddContentView(linearLayout, new LinearLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent)
            {

            });

            SDPract1Lib.Card1Light card1light = new SDPract1Lib.Card1Light(this);
            SDPract1Lib.Card1Dark card1dark = new SDPract1Lib.Card1Dark(this);
            SDPract1Lib.Card2Light card2light = new SDPract1Lib.Card2Light(this);
            SDPract1Lib.Card2Dark card2dark = new SDPract1Lib.Card2Dark(this);
            SDPract1Lib.Card3ButtonLight card3light = new SDPract1Lib.Card3ButtonLight(this);
            SDPract1Lib.Card3ButtonDark card3dark = new SDPract1Lib.Card3ButtonDark(this);

            linearLayout.AddView(card1light);
            linearLayout.AddView(new Space(this)
            {
                LayoutParameters = new LinearLayout.LayoutParams(LayoutParams.MatchParent, 40)
            });

            linearLayout.AddView(card1dark);
            linearLayout.AddView(new Space(this)
            {
                LayoutParameters = new LinearLayout.LayoutParams(LayoutParams.MatchParent, 40)
            });
            linearLayout.AddView(card2light);
            linearLayout.AddView(new Space(this)
            {
                LayoutParameters = new LinearLayout.LayoutParams(LayoutParams.MatchParent, 40)
            });
            linearLayout.AddView(card2dark);
            linearLayout.AddView(new Space(this)
            {
                LayoutParameters = new LinearLayout.LayoutParams(LayoutParams.MatchParent, 40)
            });
            linearLayout.AddView(card3light);
            linearLayout.AddView(new Space(this)
            {
                LayoutParameters = new LinearLayout.LayoutParams(LayoutParams.MatchParent, 40)
            });
            linearLayout.AddView(card3dark);
        }
    }
}
