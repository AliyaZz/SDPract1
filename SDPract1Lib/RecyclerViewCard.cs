using Android.Content;
using Android.Views;
using Android.Graphics.Drawables;
using AndroidX.RecyclerView.Widget;

namespace SDPract1Lib
{
    public class RecyclerViewCard : LinearLayout
    {
        #region Fields

        bool isHorizontal;

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

        JustButton button;

        #region Internal Fields

        LinearLayout headerLayout;

        LinearLayout buttonLayout;

        TextView header;

        Button topButton;

        #endregion

        #endregion

        #region Properties

        public bool IsHorizontal
        {
            get => isHorizontal;
            set => isHorizontal = value;
        }

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
            get => buttonInput; set => button.ButtonInput = value;
        }

        public List<string> Titles
        {
            get => titleInputs; set
            {
                titleInputs = value;
            }
        }

        public List<string> Descriptions
        {
            get => descriptionInputs; set
            {
                descriptionInputs = value;
                UpdateList();
            }
        }


        #endregion

        #region ctor

        public RecyclerViewCard(Context context) : base(context)
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
            topButton.Gravity = GravityFlags.Right;
            topButton.SetBackgroundDrawable(new ColorDrawable(Android.Graphics.Color.Transparent));
            topButton.LayoutParameters = new LinearLayout.LayoutParams(0, ViewGroup.LayoutParams.WrapContent, 1);
            topButton.Visibility = ViewStates.Gone;

            headerLayout.AddView(header);
            headerLayout.AddView(topButton);

            recyclerView = new RecyclerView(context);

            AddView(headerLayout);
            AddView(recyclerView);

            buttonLayout = new LinearLayout(context);
            buttonLayout.SetPadding(0, 50, 0, 0);
            buttonLayout.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent);

            button = new JustButton(context);

            buttonLayout.AddView(button);
            AddView(buttonLayout);

            buttonLayout.Visibility = ViewStates.Gone;
        }

        #endregion

        #region Private methods

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

        void UpdateList()
        {
            if (isHorizontal)
            {
                layoutManager = new LinearLayoutManager(context, LinearLayoutManager.Horizontal, false);
                recyclerView.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
            }
            else
            {
                layoutManager = new LinearLayoutManager(context, LinearLayoutManager.Vertical, false);
                recyclerView.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, 400);
            }

            recyclerView.SetLayoutManager(layoutManager);
            adapter = new Adapterclass(isHorizontal, isDark);
            adapter.TitleInputs = titleInputs;
            adapter.DescriptionInputs = descriptionInputs;
            recyclerView.SetAdapter(adapter); 
        }

        #endregion
        
    }
}
