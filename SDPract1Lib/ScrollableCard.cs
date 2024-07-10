using Android.Widget;
using Android.Content;
using Android.Views;
using Android.Graphics.Drawables;

namespace SDPract1Lib
{
    public class ScrollableCard : LinearLayout
    {
        public ScrollableCard(Context context, string topButtonInput, string headerInput, 
            List<string> titleInputs = default, List<string> subtitleInputs = default, string buttonInput = default) : base(context)
        {
            Orientation = Orientation.Vertical;
            SetPadding(48, 32, 48, 66);
            SetBackgroundResource(Resource.Drawable.backgroundcardlight);
            Elevation = 40;
            SetGravity(GravityFlags.Top | GravityFlags.CenterHorizontal);

            var headerLayout = new LinearLayout(context);
            headerLayout.Orientation = Orientation.Horizontal;
            headerLayout.SetGravity(GravityFlags.Top);
            headerLayout.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent, 1);
            headerLayout.SetPadding(0, 0, 16, 0);

            var header = new TextView(Context);
            header.Text = headerInput;
            header.TextSize = 20;
            header.SetTextColor(Android.Graphics.Color.Black);
            Android.Graphics.Typeface typeface2 = Resources.GetFont(Resource.Font.RobotoBold);
            header.SetTypeface(typeface2, Android.Graphics.TypefaceStyle.Bold);

            var topButton = new Button(context);
            Android.Graphics.Typeface typeface1 = Resources.GetFont(Resource.Font.Roboto);
            topButton.SetTypeface(typeface1, Android.Graphics.TypefaceStyle.Bold);
            topButton.SetTextColor(Android.Graphics.Color.Rgb(66, 139, 249));
            topButton.Text = topButtonInput;
            topButton.Gravity = GravityFlags.Right;
            topButton.SetBackgroundDrawable(new ColorDrawable(Android.Graphics.Color.Transparent));
            topButton.LayoutParameters = new LinearLayout.LayoutParams(0, ViewGroup.LayoutParams.WrapContent, 1);

            headerLayout.AddView(header);
            headerLayout.AddView(topButton);

            AddView(headerLayout);

            var scrollView = new HorizontalScrollView(context);
            scrollView.HorizontalScrollBarEnabled = false;
            var textLayouts = new List<LinearLayout>();
            var imageLayouts = new List<LinearLayout>();
            var titles = new List<TextView>();
            var subtitles = new List<TextView>();
            var blockLayouts = new List<LinearLayout>();
            var cardLayouts = new List<LinearLayout>();
            var layoutOfBlockLayouts = new LinearLayout(context);

            if (titleInputs != null)
            {
                for (int i = 0; i < titleInputs.Count; i++)
                {
                    textLayouts.Add(new LinearLayout(context)
                    {
                        LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent, 1),
                        Orientation = Orientation.Vertical
                    });
                    textLayouts[i].SetGravity(GravityFlags.CenterVertical);

                    imageLayouts.Add(new LinearLayout(context)
                    {
                        Orientation = Orientation.Vertical,
                        LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.MatchParent, 1)
                    });
                    imageLayouts[i].SetPadding(0, 0, 32, 0);
                    imageLayouts[i].SetGravity(GravityFlags.CenterVertical);

                    var imageView = new ImageView(context);
                    imageView.SetImageResource(Resource.Drawable.starblue);
                    imageLayouts[i].AddView(imageView);

                    titles.Add(new TextView(context)
                    {
                        Text = titleInputs[i],
                        TextSize = 16
                    });
                    titles[i].SetTypeface(typeface1, Android.Graphics.TypefaceStyle.Bold);
                    titles[i].SetTextColor(Android.Graphics.Color.Black);

                    subtitles.Add(new TextView(context)
                    {
                        Text = subtitleInputs[i],
                        TextSize = 14,
                        Typeface = typeface1
                    });
                    subtitles[i].SetTextColor(Android.Graphics.Color.Black);
                    subtitles[i].SetPadding(0, 8, 0, 0);

                    textLayouts[i].AddView(titles[i]);
                    textLayouts[i].AddView(subtitles[i]);

                    cardLayouts.Add(new LinearLayout(context));
                    cardLayouts[i].SetPadding(0, 0, 40, 0);
                    if (i == titleInputs.Count - 1)
                    {
                        cardLayouts[i].SetPadding(0, 0, 0, 0);
                    }

                    blockLayouts.Add(new LinearLayout(context)
                    {
                        Orientation = Orientation.Vertical,
                        LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.MatchParent)
                    });
                    blockLayouts[i].SetPadding(32, 0, 0, 0);
                    blockLayouts[i].SetMinimumHeight(460);
                    blockLayouts[i].SetMinimumWidth(460);
                    blockLayouts[i].SetBackgroundResource(Resource.Drawable.scrollviewcards);
                    blockLayouts[i].AddView(imageLayouts[i]);
                    blockLayouts[i].AddView(textLayouts[i]);

                    cardLayouts[i].AddView(blockLayouts[i]);

                    layoutOfBlockLayouts.AddView(cardLayouts[i]);
                }
            }
            layoutOfBlockLayouts.SetPadding(16, 0, 16, 0);
            scrollView.AddView(layoutOfBlockLayouts);

            AddView(scrollView);

            if (buttonInput != null)
            {
                var buttonLayout = new LinearLayout(context);
                buttonLayout.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent, 1);
                buttonLayout.SetPadding(0, 50, 0, 0);
                buttonLayout.Orientation = Orientation.Vertical;

                var button = new Button(context);
                button.Text = buttonInput;
                button.SetBackgroundResource(Resource.Drawable.buttons);
                button.Typeface = typeface1;
                button.TextSize = 14;
                button.SetTextColor(Android.Graphics.Color.Rgb(66, 139, 249));
                buttonLayout.AddView(button);

                AddView(buttonLayout);
            }
        }
    }
}
