using Android.Widget;
using Android.Content;
using Android.Views;
using Android.Graphics.Drawables;

namespace SDPract1Lib
{
    public class ScrollableCard : LinearLayout
    {
        public ScrollableCard(Context context, string buttonInput = "Undefined", string headerInput = "Header", string topButtonInput = "Button",
            string titleInput1 = "Title", string subtitleInput1 = "Subtitle",
            string titleInput2 = "Title", string subtitleInput2 = "Subtitle",
            string titleInput3 = "Title", string subtitleInput3 = "Subtitle",
            string titleInput4 = "Title", string subtitleInput4 = "Subtitle",
            string titleInput5 = "Title", string subtitleInput5 = "Subtitle",
            string titleInput6 = "Title", string subtitleInput6 = "Subtitle") : base(context)
        {
            Orientation = Orientation.Horizontal;
            SetPadding(16, 16, 16, 16);
            SetBackgroundResource(Resource.Drawable.backgroundcardlight);
            Elevation = 40;

            var mainLayout = new LinearLayout(context);
            mainLayout.Orientation = Orientation.Vertical;
            mainLayout.SetPadding(32, 16, 32, 50);
            mainLayout.LayoutParameters = new LinearLayout.LayoutParams(0, ViewGroup.LayoutParams.WrapContent, 1);
            mainLayout.SetGravity(GravityFlags.Top | GravityFlags.CenterHorizontal);

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

            mainLayout.AddView(headerLayout);

            var scrollView = new HorizontalScrollView(context);

            var titleInputs = new List<string>() { titleInput1, titleInput2, titleInput3, titleInput4, titleInput5, titleInput6 };
            var subtitleInputs = new List<string>() { subtitleInput1, subtitleInput2, subtitleInput3, subtitleInput4, subtitleInput5, subtitleInput6 };

            var textLayouts = new List<LinearLayout>();
            var imageLayouts = new List<LinearLayout>();
            var titles = new List<TextView>();
            var subtitles = new List<TextView>();
            var blockLayouts = new List<LinearLayout>();
            var cardLayouts = new List<LinearLayout>();
            var layoutOfBlockLayouts = new LinearLayout(context);

            for (int i = 0; i < 6; i++)
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
                if (i == 5)
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

            layoutOfBlockLayouts.SetPadding(16, 0, 16, 0);
            scrollView.AddView(layoutOfBlockLayouts);

            mainLayout.AddView(scrollView);

            if (buttonInput != "Undefined")
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

                mainLayout.AddView(buttonLayout);
            }
            AddView(mainLayout);
        }
    }
}
