using Android.Widget;
using Android.Content;
using Android.Views;
using Android.OS;
using Android.Graphics;
using Android.Graphics.Drawables;

namespace SDPract1Lib
{
    public class CardWithHeaderAnd4Titles : LinearLayout
    {
        public CardWithHeaderAnd4Titles(Context context, bool isDark, string buttonInput = "Undefined", string headerInput = "Header", string topButtonInput = "Button", 
            string titleInput1 = "Title", string descriptionInput1 = "Description", 
            string titleInput2 = "Title", string descriptionInput2 = "Description", 
            string titleInput3 = "Title", string descriptionInput3 = "Description", 
            string titleInput4 = "Title", string descriptionInput4 = "Description") : base(context)
        {
            Orientation = Orientation.Horizontal;
            SetPadding(16, 16, 16, 16);

            var mainLayout = new LinearLayout(context);
            mainLayout.Orientation = Orientation.Vertical;
            mainLayout.SetPadding(32, 16, 32, 32);
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

            var titleInputs = new List<string>() { titleInput1, titleInput2, titleInput3, titleInput4};
            var descriptionInputs = new List<string> {descriptionInput1, descriptionInput2, descriptionInput3, descriptionInput4};

            var textLayouts = new List<LinearLayout>();
            var imageLayouts = new List<LinearLayout>();
            var titles = new List<TextView>();
            var descriptions = new List<TextView>();
            var blockLayouts = new List<LinearLayout>();

            var layoutOfTextLayouts = new LinearLayout(context);
            layoutOfTextLayouts.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
            layoutOfTextLayouts.Orientation = Orientation.Vertical;

            for (int i = 0; i < 4; i++)
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

                var imageView = new ImageView(context);
                imageView.SetImageResource(Resource.Drawable.starblue);
                imageLayouts[i].AddView(imageView);

                titles.Add(new TextView(context)
                {
                    Text = titleInputs[i],
                    TextSize = 16,
                    Typeface = typeface1
                });
                titles[i].SetTextColor(Android.Graphics.Color.Black);

                descriptions.Add(new TextView(context)
                {
                    Text = descriptionInputs[i],
                    TextSize = 14,
                    Typeface = typeface1
                });
                descriptions[i].SetTextColor(Android.Graphics.Color.Gray);
                descriptions[i].SetPadding(0, 8, 0, 0);

                textLayouts[i].AddView(titles[i]);
                textLayouts[i].AddView(descriptions[i]);

                blockLayouts.Add(new LinearLayout(context)
                {
                    Orientation = Orientation.Horizontal,
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.MatchParent)
                });
                blockLayouts[i].SetPadding(0, 0, 0, 50);
                blockLayouts[i].SetGravity(GravityFlags.CenterVertical);

                if (i == 3)
                {
                    blockLayouts[i].SetPadding(0, 0, 0, 0);
                }
                blockLayouts[i].AddView(imageLayouts[i]);
                blockLayouts[i].AddView(textLayouts[i]);

                layoutOfTextLayouts.AddView(blockLayouts[i]);
            }

            if (isDark == false)
            {
                SetBackgroundResource(Resource.Drawable.backgroundcardlight);
                Elevation = 40;
            }
            else
            {
                SetBackgroundResource(Resource.Drawable.backgroundcarddark);
            }

            mainLayout.AddView(headerLayout);
            mainLayout.AddView(layoutOfTextLayouts);

            if (buttonInput != "Undefined")
            {
                var buttonLayout = new LinearLayout(context);
                buttonLayout.SetPadding(0, 50, 0, 0);
                buttonLayout.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent);

                var button = new Button(context);
                button.Text = buttonInput;
                button.Typeface = typeface1;
                button.TextSize = 14;
                button.SetTextColor(Android.Graphics.Color.Rgb(66, 139, 249));
                button.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent);

                buttonLayout.AddView(button);
                mainLayout.AddView(buttonLayout);

                button.SetBackgroundResource(Resource.Drawable.buttons);
            }

            AddView(mainLayout);
        }
    }
}
