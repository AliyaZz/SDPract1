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

            var cards = new List<CardForRecyclerView>()
            {
                
            };

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
                new CardWithHeaderAndButton(this)
                {
                    IsDark = false,
                    Header = "Header",
                    Subheader = "Subheader",
                    BottomButton = "Button"
                },
                new CardWithHeaderAndButton(this)
                {
                    IsDark = true,
                    Header = "Header",
                    Subheader = "Subheader",
                    BottomButton = "Button"
                },
                new CardWithTitle(this)
                {
                    IsDark = false,
                    Title = "Title",
                    Description = "Description"
                },
                new CardWithTitle(this)
                {
                    IsDark = true,
                    Title = "Title",
                    Description = "Description"
                },
                new CardWithTitleAndCloseButton(this)
                {
                    Title = "Title",
                    Description = "Description"
                },
                new RecyclerViewCard(this)
                {
                    IsDark = false,
                    IsHorizontal = false,
                    TopButton = "Button",
                    Header = "Header",
                    Titles = new List<string>{"Title", "Title", "Title", "Title", "Title",},
                    Descriptions = new List<string> { "Description", "Description", "Description", "Description", "Description", }
                },
                new RecyclerViewCard(this)
                {
                    IsDark = true,
                    IsHorizontal = false,
                    TopButton = "Button",
                    Header = "Header",
                    Titles = new List<string>{"Title", "Title", "Title", "Title", "Title",},
                    Descriptions = new List<string> { "Description", "Description", "Description", "Description", "Description", }
                },
                new RecyclerViewCard(this)
                {
                    IsDark = false,
                    IsHorizontal = false,
                    TopButton = "Button",
                    BottomButton = "Button",
                    Header = "Header",
                    Titles = new List<string>{"Title", "Title", "Title", "Title", "Title",},
                    Descriptions = new List<string> { "Description", "Description", "Description", "Description", "Description", }
                },
                new RecyclerViewCard(this)
                {
                    IsDark = true,
                    IsHorizontal = false,
                    TopButton = "Button",
                    BottomButton = "Button",
                    Header = "Header",
                    Titles = new List<string>{"Title", "Title", "Title", "Title", "Title",},
                    Descriptions = new List<string> { "Description", "Description", "Description", "Description", "Description", }
                },
                new RecyclerViewCard(this){
                    IsDark = false,
                    IsHorizontal = true,
                    TopButton = "Button",
                    Header = "Header",
                    Titles = new List<string>{"Title", "Title", "Title", "Title", "Title",},
                    Descriptions = new List<string> { "Subtitle", "Subtitle", "Subtitle", "Subtitle", "Subtitle", }
                },
                new RecyclerViewCard(this){
                    IsDark = false,
                    IsHorizontal = true,
                    TopButton = "Button",
                    BottomButton = "Button",
                    Header = "Header",
                    Titles = new List<string>{"Title", "Title", "Title", "Title", "Title",},
                    Descriptions = new List<string> { "Subtitle", "Subtitle", "Subtitle", "Subtitle", "Subtitle", }
                },
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
