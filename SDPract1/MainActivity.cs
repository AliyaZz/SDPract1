using Android.Views;
using Android.Content;
using Android.Widget;
using SDPract1Lib;
using AndroidX.RecyclerView.Widget;
using static Android.Views.ViewGroup;
using static Android.Preferences.PreferenceActivity;

namespace SDPract1
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        RecyclerView recyclerView;
        RecyclerView.LayoutManager layoutManager;
        Adapterclass adapter;
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
            linearLayout.SetPadding(40, 40, 40, 40);

            var scrollView = new ScrollView(BaseContext);
            scrollView.SetClipToPadding(false);
            scrollView.SetClipChildren(false);
            scrollView.AddView(linearLayout);
            scrollView.VerticalScrollBarEnabled = false;
            AddContentView(scrollView, new LinearLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent));

            recyclerView = new RecyclerView(BaseContext);
            layoutManager = new LinearLayoutManager(BaseContext);
            recyclerView.SetLayoutManager(layoutManager);
            recyclerView.HorizontalScrollBarEnabled = false;
            recyclerView.VerticalScrollBarEnabled = true;
            recyclerView.SetClipToPadding(false);
            recyclerView.SetClipChildren(false);
            adapter = new Adapterclass(linearLayout);
            recyclerView.SetAdapter(adapter);
            
            AddContentView(scrollView, new LinearLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent));

            var list = new List<View> {
                new CardWithHeader(this)
                {
                    IsDark = false,
                    Header = "Header"
                },
                new CardWithHeader(this)
                {
                    IsDark = true,
                    Header = "Header"
                },
                new CardWithHeader(this)
                {
                    IsDark = false,
                    Header = "Header",
                    Subheader = "Subheader"
                },
                new CardWithHeader(this)
                {
                    IsDark = true,
                    Header = "Header",
                    Subheader = "Subheader"
                },
                new CardWithHeaderAndButton(this, false, "Header", "Subheader", "Button"),
                new CardWithHeaderAndButton(this, true, "Header", "Subheader", "Button"),
                new CardWithTitle(this, false, "Title", "Description"),
                new CardWithTitle(this, true, "Title", "Description"),
                new CardWithTitleAndCloseButton(this, "Title", "Description"),
                new CardWithHeaderAnd4Titles(this)
                {
                    IsDark = false,
                    TopButton = "Button",
                    BottomButton = "Button",
                    Header = "Header",
                    Titles =  new List<string> {"Title", "Title", "Title"},
                    Descriptions = new List<string> {"Description", "Description", "Description"}
                },
                new CardWithHeaderAnd4Titles(this)
                {
                    IsDark = true,
                    Header = "Header"
                },
                new CardWithHeaderAnd4Titles(this)
                {
                    IsDark = false,
                    TopButton = "Button",
                    Titles =  new List<string> {"Title", "Title", "Title"},
                    Descriptions = new List<string> {"Description", "Description", "Description"}
                },
                new CardWithHeaderAnd4Titles(this)
                {
                    IsDark = true,
                    TopButton = "Button",
                    BottomButton = "Button",
                    Header = "Header",
                    Titles =  new List<string> {"Title", "Title", "Title"},
                    Descriptions = new List<string> {"Description", "Description", "Description"}
                },
                new ScrollableCard(this, "Button", "Header", new List<string>{}, new List<string>{}, "Button"),
                new ScrollableCard(this, "Button", "Header", new List<string> {"Title", "Title", "Title"}, new List<string> {"Description", "Description", "Description"}, "Button"),
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
