using Android.Widget;
using Android.Content;
using Android.Views;
using Android.OS;
using Android.Graphics;
using Android.Graphics.Drawables;
using System.Numerics;

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

        public List<string> Titles
        {
            get => titleInputs;
            set
            {
                titleInputs = value;
                UpdateTitles();
            }
        }

        public List<string> Descriptions
        {
            get => descriptionInputs; 
            set
            {
                descriptionInputs = value;
                UpdateDescriptions();
            }
        }

        #endregion

        #region ctor

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

        void UpdateTitles()
        {
            textLayouts = new List<LinearLayout>();
            imageLayouts = new List<LinearLayout>();
            titles = new List<TextView>();
            blockLayouts = new List<LinearLayout>();

            layoutOfTextLayouts = new LinearLayout(context);

            Android.Graphics.Typeface typeface1 = Resources.GetFont(Resource.Font.Roboto);

            for (int i = 0; i < titleInputs.Count; i++)
            {
                textLayouts.Add(new LinearLayout(context)
                {
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent),
                    Orientation = Orientation.Vertical
                });
                imageLayouts.Add(new LinearLayout(context)
                {
                    Orientation = Orientation.Vertical,
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent)
                });
                imageLayouts[i].SetPadding(0, 0, 32, 0);
                imageView = new ImageView(context);
                imageView.SetImageResource(Resource.Drawable.starblue);
                imageLayouts[i].AddView(imageView);
                titles.Add(new TextView(context)
                {
                    Text = titleInputs[i],
                    TextSize = 16,
                    Typeface = typeface1
                });
                titles[i].SetTextColor(Android.Graphics.Color.Black);
                textLayouts[i].AddView(titles[i]);

                if (descriptionInputs != null && (!string.IsNullOrEmpty(descriptionInputs[i])))
                {
                    textLayouts[i].RemoveView(descriptions[i]);
                }

                blockLayouts.Add(new LinearLayout(context)
                {
                    Orientation = Orientation.Horizontal,
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.MatchParent)
                });
                blockLayouts[i].SetPadding(0, 0, 0, 50);
                blockLayouts[i].SetGravity(GravityFlags.CenterVertical);
                if (i == titleInputs.Count - 1)
                {
                    blockLayouts[i].SetPadding(0, 0, 0, 0);
                }
                blockLayouts[i].AddView(imageLayouts[i]);
                blockLayouts[i].AddView(textLayouts[i]);

                layoutOfTextLayouts.AddView(blockLayouts[i]);
            }
        }

        void UpdateDescriptions()
        {
            textLayouts = new List<LinearLayout>();
            imageLayouts = new List<LinearLayout>();
            descriptions = new List<TextView>();
            blockLayouts = new List<LinearLayout>();
            layoutOfTextLayouts = new LinearLayout(context);

            Android.Graphics.Typeface typeface1 = Resources.GetFont(Resource.Font.Roboto);

            for (int i = 0; i < descriptionInputs.Count; i++)
            {
                textLayouts.Add(new LinearLayout(context)
                {
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent),
                    Orientation = Orientation.Vertical
                });
                imageLayouts.Add(new LinearLayout(context)
                {
                    Orientation = Orientation.Vertical,
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent)
                });
                imageLayouts[i].SetPadding(0, 0, 32, 0);
                imageView = new ImageView(context);
                imageView.SetImageResource(Resource.Drawable.starblue);
                imageLayouts[i].AddView(imageView);

                if (titleInputs != null && !string.IsNullOrEmpty(titleInputs[i]))
                {
                    textLayouts[i].RemoveView(titles[i]);
                }

                descriptions.Add(new TextView(context)
                {
                    Text = descriptionInputs[i],
                    TextSize = 14,
                    Typeface = typeface1
                });
                descriptions[i].SetTextColor(Android.Graphics.Color.Gray);
                descriptions[i].SetPadding(0, 8, 0, 0);
                textLayouts[i].AddView(descriptions[i]);

                blockLayouts.Add(new LinearLayout(context)
                {
                    Orientation = Orientation.Horizontal,
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.MatchParent)
                });
                blockLayouts[i].SetPadding(0, 0, 0, 50);
                blockLayouts[i].SetGravity(GravityFlags.CenterVertical);
                if (i == descriptionInputs.Count - 1)
                {
                    blockLayouts[i].SetPadding(0, 0, 0, 0);
                }
                blockLayouts[i].AddView(imageLayouts[i]);
                blockLayouts[i].AddView(textLayouts[i]);

                layoutOfTextLayouts.AddView(blockLayouts[i]);
            }
        }

        #endregion
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

            textLayouts = new List<LinearLayout>();
            imageLayouts = new List<LinearLayout>();
            titles = new List<TextView>();
            descriptions = new List<TextView>();
            blockLayouts = new List<LinearLayout>();

            layoutOfTextLayouts = new LinearLayout(context);
            layoutOfTextLayouts.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
            layoutOfTextLayouts.Orientation = Orientation.Vertical;
            
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
    }
}
