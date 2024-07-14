using Android.Widget;
using Android.Content;
using Android.Views;
using Android.OS;
using Android.Graphics;
using Android.Graphics.Drawables;
using System.Numerics;
using AndroidX.RecyclerView.Widget;
using static AndroidX.RecyclerView.Widget.RecyclerView;

namespace SDPract1Lib
{
    public class CardWithHeaderAnd4Titles : LinearLayout
    {
        #region Fields

        bool isDark;

        string headerInput;

        string buttonInput;

        string topButtonInput;

        List<string> titleInputs;

        List<string> descriptionInputs;

        Context context;

        RecyclerView recyclerView;
        
        RecyclerView.LayoutManager layoutManager;
        
        Adapterclass adapter;

        List<VerticalCardForRecyclerView> list;

        #region Internal Fields

        LinearLayout headerLayout;

        LinearLayout buttonLayout;

        LinearLayout layoutOfTextLayouts;

        TextView header;

        Button topButton;

        Button button;

        List<LinearLayout> textLayouts;

        List<LinearLayout> imageLayouts;

        List<TextView> titles;

        List<TextView> descriptions;

        List<LinearLayout> blockLayouts;

        ImageView imageView;

        #endregion

        #endregion

        #region Properties

        public bool IsDark {  get => isDark; set
            {
                isDark = value;
                UpdateDark();
            } 
        }

        public string Header {  get => headerInput; set 
            { 
                headerInput = value;
                UpdateHeader();
            }
        }

        public string TopButton { get => topButtonInput; set
            {
                topButtonInput = value;
                UpdateTopButton();
            }
        }

        public string BottomButton
        {
            get => buttonInput; set
            {
                buttonInput = value;
                UpdateButton();
            }
        }

        public List<VerticalCardForRecyclerView> Cards
        {
            get => list;
            set
            {
                list = value;
                foreach (var item in list)
                {
                    item.IsDark = isDark;
                }
                UpdateList();
            }
        }

        #endregion

        #region ctor

        public CardWithHeaderAnd4Titles(Context context) : base(context)
        {
            this.context = context;
            SetPadding(48, 32, 48, 48);
            Orientation = Orientation.Vertical;
            SetGravity(GravityFlags.Top | GravityFlags.CenterHorizontal);

            headerLayout = new LinearLayout(context);
            headerLayout.Orientation = Orientation.Horizontal;
            headerLayout.SetGravity(GravityFlags.Top);
            headerLayout.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent, 1);
            headerLayout.SetPadding(0, 0, 16, 0);

            header = new TextView(Context);
            header.TextSize = 20;
            header.SetTextColor(Android.Graphics.Color.Black);
            Android.Graphics.Typeface typeface2 = Resources.GetFont(Resource.Font.RobotoBold);
            header.SetTypeface(typeface2, Android.Graphics.TypefaceStyle.Bold);
            header.Visibility = ViewStates.Gone;

            topButton = new Button(context);
            Android.Graphics.Typeface typeface1 = Resources.GetFont(Resource.Font.Roboto);
            topButton.SetTypeface(typeface1, Android.Graphics.TypefaceStyle.Bold);
            topButton.SetTextColor(Android.Graphics.Color.Rgb(66, 139, 249));
            topButton.Text = topButtonInput;
            topButton.Gravity = GravityFlags.Right;
            topButton.SetBackgroundDrawable(new ColorDrawable(Android.Graphics.Color.Transparent));
            topButton.LayoutParameters = new LinearLayout.LayoutParams(0, ViewGroup.LayoutParams.WrapContent, 1);
            topButton.Visibility = ViewStates.Gone;

            headerLayout.AddView(header);
            headerLayout.AddView(topButton);

            recyclerView = new RecyclerView(context);
            layoutManager = new LinearLayoutManager(context, LinearLayoutManager.Vertical, false);
            recyclerView.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent);

            recyclerView.SetLayoutManager(layoutManager);
            recyclerView.HorizontalScrollBarEnabled = false;
            recyclerView.VerticalScrollBarEnabled = false;
            recyclerView.SetClipToPadding(false);
            recyclerView.SetClipChildren(false);

            layoutOfTextLayouts = new LinearLayout(context);
            layoutOfTextLayouts.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
            layoutOfTextLayouts.Orientation = Orientation.Vertical;
            layoutOfTextLayouts.AddView(recyclerView);

            AddView(headerLayout);
            AddView(layoutOfTextLayouts);

            buttonLayout = new LinearLayout(context);
            buttonLayout.SetPadding(0, 50, 0, 0);
            buttonLayout.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent);

            button = new Button(context);
            button.Text = buttonInput;
            button.Typeface = typeface1;
            button.TextSize = 14;
            button.SetTextColor(Android.Graphics.Color.Rgb(66, 139, 249));
            button.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent);
            button.SetBackgroundResource(Resource.Drawable.buttons);

            buttonLayout.AddView(button);
            AddView(buttonLayout);

            buttonLayout.Visibility = ViewStates.Gone;
        }

        #endregion

        #region Methods

        void UpdateDark()
        {
            if (isDark == false)
            {
                SetBackgroundResource(Resource.Drawable.backgroundcardlight);
                Elevation = 40;
            }
            else
            {
                SetBackgroundResource(Resource.Drawable.backgroundcarddark);
            }
        }

        void UpdateHeader()
        {
            header.Text = headerInput;
            header.Visibility = ViewStates.Visible;
        }

        void UpdateTopButton()
        {
            topButton.Text = topButtonInput;
            topButton.Visibility = ViewStates.Visible;
        }

        void UpdateButton()
        {
            button.Text = topButtonInput;
            buttonLayout.Visibility = ViewStates.Visible;
        }

        void UpdateList()
        {
            adapter = new Adapterclass(list);
            recyclerView.SetAdapter(adapter); 
        }

        #endregion
        
    }
}
