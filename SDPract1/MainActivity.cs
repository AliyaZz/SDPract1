using Android.Views;
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

            var card1light = new SDPract1Lib.CardWithHeader(this, false, "Header", "Subheader");
            var card1dark = new SDPract1Lib.CardWithHeader(this, true, "Header", "Subheader");
            var card2light = new SDPract1Lib.CardWithHeader(this, false, "Header");
            var card2dark = new SDPract1Lib.CardWithHeader(this, true, "Header");
            var card3light = new SDPract1Lib.CardWithHeaderAndButton(this, false);
            var card3dark = new SDPract1Lib.CardWithHeaderAndButton(this, true);
            var card4light = new SDPract1Lib.CardWithTitle(this, false);
            var card4dark = new SDPract1Lib.CardWithTitle(this, true);
            var card5 = new SDPract1Lib.CardWithTitleAndCloseButton(this);
            var card6light = new SDPract1Lib.CardWithHeaderAnd4Titles(this, false, "Button");
            var card6dark = new SDPract1Lib.CardWithHeaderAnd4Titles(this, true, "Button");
            var card7light = new SDPract1Lib.CardWithHeaderAnd4Titles(this, false);
            var card7dark = new SDPract1Lib.CardWithHeaderAnd4Titles(this, true);
            var card8 = new SDPract1Lib.ScrollableCardWithButton(this, true);

            var list = new List<View> {card1light, card1dark, card2light, card2dark, card3light, card3dark, card4light, card4dark, card5, card6light, card6dark, card7light, card7dark, card8 };

            foreach (var item in list)
            {
                linearLayout.AddView(item);
                linearLayout.AddView(new Space(this)
                {
                    LayoutParameters = new LinearLayout.LayoutParams(LayoutParams.MatchParent, 40)
                });
            }
        }
    }
}
