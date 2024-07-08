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
            ActionBar.Hide();

            LinearLayout linearLayout = new LinearLayout(BaseContext)
            {
                Orientation = Orientation.Vertical
            };
            linearLayout.SetClipToPadding(false);
            linearLayout.SetClipChildren(false);

            ScrollView scrollView = new ScrollView(BaseContext);
            scrollView.SetClipToPadding(false);
            scrollView.SetClipChildren(false);

            linearLayout.SetPadding(40, 40, 40, 40);
            AddContentView(scrollView, new LinearLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent));
            scrollView.AddView(linearLayout);

            SDPract1Lib.Card1 card1light = new SDPract1Lib.Card1(this, false);
            SDPract1Lib.Card1 card1dark = new SDPract1Lib.Card1(this, true);
            SDPract1Lib.Card2 card2light = new SDPract1Lib.Card2(this,false);
            SDPract1Lib.Card2 card2dark = new SDPract1Lib.Card2(this,true);
            SDPract1Lib.Card3Button card3light = new SDPract1Lib.Card3Button(this, false);
            SDPract1Lib.Card3Button card3dark = new SDPract1Lib.Card3Button(this, true);
            SDPract1Lib.Card4 card4light = new SDPract1Lib.Card4(this, true);
            SDPract1Lib.Card4 card4dark = new SDPract1Lib.Card4(this, false);
            SDPract1Lib.Card5 card5 = new SDPract1Lib.Card5(this);
            SDPract1Lib.Card6 card6light = new SDPract1Lib.Card6(this, false);
            SDPract1Lib.Card6 card6dark = new SDPract1Lib.Card6(this, true);

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
            linearLayout.AddView(new Space(this)
            {
                LayoutParameters = new LinearLayout.LayoutParams(LayoutParams.MatchParent, 40)
            });
            linearLayout.AddView(card4light);
            linearLayout.AddView(new Space(this)
            {
                LayoutParameters = new LinearLayout.LayoutParams(LayoutParams.MatchParent, 40)
            });
            linearLayout.AddView(card4dark);
            linearLayout.AddView(new Space(this)
            {
                LayoutParameters = new LinearLayout.LayoutParams(LayoutParams.MatchParent, 40)
            });
            linearLayout.AddView(card5);
            linearLayout.AddView(new Space(this)
            {
                LayoutParameters = new LinearLayout.LayoutParams(LayoutParams.MatchParent, 40)
            });
            linearLayout.AddView(card6light);
            linearLayout.AddView(new Space(this)
            {
                LayoutParameters = new LinearLayout.LayoutParams(LayoutParams.MatchParent, 40)
            });
            linearLayout.AddView(card6dark);
        }
    }
}
