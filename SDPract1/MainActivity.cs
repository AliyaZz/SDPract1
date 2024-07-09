using Android.Views;
using SDPract1Lib;
using static Android.Provider.Settings;
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

            var linearLayout = new LinearLayout(BaseContext)
            {
                Orientation = Orientation.Vertical
            };
            linearLayout.SetClipToPadding(false);
            linearLayout.SetClipChildren(false);

            var scrollView = new ScrollView(BaseContext);
            scrollView.SetClipToPadding(false);
            scrollView.SetClipChildren(false);

            linearLayout.SetPadding(40, 40, 40, 40);
            AddContentView(scrollView, new LinearLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent));
            scrollView.AddView(linearLayout);

            var list = new List<View> {
                new CardWithHeader(this, false, "Header", "Subheader"),
                new CardWithHeader(this, true, "Header", "Subheader"),
                new CardWithHeader(this, false, "Header", "Subheader"),
                new CardWithHeader(this, true, "Header", "Subheader"),
                new CardWithHeaderAndButton(this, false, "Header", "Subheader", "Button"),
                new CardWithHeaderAndButton(this, true, "Header", "Subheader", "Button"),
                new CardWithTitle(this, false, "Title", "Description"),
                new CardWithTitle(this, true, "Title", "Description"),
                new CardWithTitleAndCloseButton(this, "Title", "Description"),
                new CardWithHeaderAnd4Titles(this, false, "Button", "Header", new List<string>{}, new List<string>{}, "Button"),
                new CardWithHeaderAnd4Titles(this, true, "Button", "Header", new List<string> {"Title", "Title"}, new List<string> {"Description", "Description"}, "Button"),
                new CardWithHeaderAnd4Titles(this, false, "Button", "Header"),
                new CardWithHeaderAnd4Titles(this, true,  "Button", "Header", new List<string> {"Title", "Title"}, new List<string> {"Description", "Description"}),
                new ScrollableCard(this, "Button", "Header", new List<string>{}, new List<string>{}, "Button"),
                new ScrollableCard(this, "Button", "Header", new List<string> {"Title", "Title"}, new List<string> {"Description", "Description"}, "Button"),
                new JustButton(this, false, "Button"),
                new JustButton(this, true, "Button highlighted")
            };

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
