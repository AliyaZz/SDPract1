using Android.Widget;
using Android.Content;
using Android.Views;
using Android.Graphics.Drawables;

namespace SDPract1Lib
{
    public class ScrollableCardWithButton : LinearLayout
    {
        public ScrollableCardWithButton(Context context, bool isDark, string headerInput = "Header", string topButtonInput = "Button",
            string titleInput1 = "Title", string descriptionInput1 = "Description",
            string titleInput2 = "Title", string descriptionInput2 = "Description",
            string titleInput3 = "Title", string descriptionInput3 = "Description",
            string titleInput4 = "Title", string descriptionInput4 = "Description") : base(context)
        {
            Orientation = Orientation.Horizontal;
            SetPadding(16, 16, 16, 16);
            SetBackgroundResource(Resource.Drawable.backgroundcardlight);
            Elevation = 40;

            LinearLayout mainLayout = new LinearLayout(context);
            mainLayout.Orientation = Orientation.Vertical;
            mainLayout.SetPadding(32, 16, 32, 32);
            mainLayout.LayoutParameters = new LinearLayout.LayoutParams(0, ViewGroup.LayoutParams.WrapContent, 1);
            mainLayout.SetGravity(GravityFlags.Top | GravityFlags.CenterHorizontal);

            LinearLayout headerLayout = new LinearLayout(context);
            headerLayout.Orientation = Orientation.Horizontal;
            headerLayout.SetGravity(GravityFlags.Top);
            headerLayout.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent, 1);
            headerLayout.SetPadding(0, 0, 16, 0);

            TextView header = new TextView(Context);
            header.Text = headerInput;
            header.TextSize = 20;
            header.SetTextColor(Android.Graphics.Color.Black);
            Android.Graphics.Typeface typeface2 = Resources.GetFont(Resource.Font.RobotoBold);
            header.SetTypeface(typeface2, Android.Graphics.TypefaceStyle.Bold);

            LinearLayout topButtonLayout = new LinearLayout(context);
            topButtonLayout.SetGravity(GravityFlags.Top | GravityFlags.Right);
            topButtonLayout.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);

            Button topButton = new Button(context);
            Android.Graphics.Typeface typeface1 = Resources.GetFont(Resource.Font.Roboto);
            topButton.SetTypeface(typeface1, Android.Graphics.TypefaceStyle.Bold);
            topButton.SetTextColor(Android.Graphics.Color.Rgb(66, 139, 249));
            topButton.Text = topButtonInput;
            topButton.Gravity = GravityFlags.Right;
            topButton.SetBackgroundDrawable(new ColorDrawable(Android.Graphics.Color.Transparent));
            topButtonLayout.AddView(topButton);

            LinearLayout linearLayout = new LinearLayout(context);
            linearLayout.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent, 1);
            linearLayout.AddView(header);

            headerLayout.AddView(linearLayout);
            headerLayout.AddView(topButtonLayout);

            mainLayout.AddView(headerLayout);

            ScrollView scrollView = new ScrollView(context);
            scrollView.CanScrollHorizontally(1);
            scrollView.CanScrollVertically(0);

            LinearLayout textLayout1 = new LinearLayout(context);
            textLayout1.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
            textLayout1.Orientation = Orientation.Vertical;

            LinearLayout textLayout2 = new LinearLayout(context);
            textLayout2.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
            textLayout2.Orientation = Orientation.Vertical;

            LinearLayout textLayout3 = new LinearLayout(context);
            textLayout3.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
            textLayout3.Orientation = Orientation.Vertical;

            LinearLayout textLayout4 = new LinearLayout(context);
            textLayout4.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
            textLayout4.Orientation = Orientation.Vertical;

            LinearLayout imageLayout1 = new LinearLayout(context);
            imageLayout1.Orientation = Orientation.Vertical;
            imageLayout1.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);
            imageLayout1.SetPadding(0, 0, 32, 0);

            LinearLayout imageLayout2 = new LinearLayout(context);
            imageLayout2.Orientation = Orientation.Vertical;
            imageLayout2.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);
            imageLayout2.SetPadding(0, 0, 32, 0);

            LinearLayout imageLayout3 = new LinearLayout(context);
            imageLayout3.Orientation = Orientation.Vertical;
            imageLayout3.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);
            imageLayout3.SetPadding(0, 0, 32, 0);

            LinearLayout imageLayout4 = new LinearLayout(context);
            imageLayout4.Orientation = Orientation.Vertical;
            imageLayout4.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);
            imageLayout4.SetPadding(0, 0, 32, 0);

            ImageView imageView1 = new ImageView(context);
            imageView1.SetImageResource(Resource.Drawable.starblue);

            ImageView imageView2 = new ImageView(context);
            imageView2.SetImageResource(Resource.Drawable.starblue);

            ImageView imageView3 = new ImageView(context);
            imageView3.SetImageResource(Resource.Drawable.starblue);

            ImageView imageView4 = new ImageView(context);
            imageView4.SetImageResource(Resource.Drawable.starblue);

            imageLayout1.AddView(imageView1);
            imageLayout2.AddView(imageView2);
            imageLayout3.AddView(imageView3);
            imageLayout4.AddView(imageView4);

            TextView title1 = new TextView(Context);
            title1.Text = titleInput1;
            title1.TextSize = 16;
            title1.SetTextColor(Android.Graphics.Color.Black);
            title1.Typeface = typeface1;

            TextView title2 = new TextView(Context);
            title2.Text = titleInput2;
            title2.TextSize = 16;
            title2.SetTextColor(Android.Graphics.Color.Black);
            title2.Typeface = typeface1;

            TextView title3 = new TextView(Context);
            title3.Text = titleInput3;
            title3.TextSize = 16;
            title3.SetTextColor(Android.Graphics.Color.Black);
            title3.Typeface = typeface1;

            TextView title4 = new TextView(Context);
            title4.Text = titleInput4;
            title4.TextSize = 16;
            title4.SetTextColor(Android.Graphics.Color.Black);
            title4.Typeface = typeface1;

            TextView description1 = new TextView(Context);
            description1.Text = descriptionInput1;
            description1.TextSize = 14;
            description1.SetTextColor(Android.Graphics.Color.Gray);
            description1.SetPadding(0, 8, 0, 0);
            description1.Typeface = typeface1;

            TextView description2 = new TextView(Context);
            description2.Text = descriptionInput2;
            description2.TextSize = 14;
            description2.SetTextColor(Android.Graphics.Color.Gray);
            description2.SetPadding(0, 8, 0, 0);
            description2.Typeface = typeface1;

            TextView description3 = new TextView(Context);
            description3.Text = descriptionInput3;
            description3.TextSize = 14;
            description3.SetTextColor(Android.Graphics.Color.Gray);
            description3.SetPadding(0, 8, 0, 0);
            description3.Typeface = typeface1;

            TextView description4 = new TextView(Context);
            description4.Text = descriptionInput4;
            description4.TextSize = 14;
            description4.SetTextColor(Android.Graphics.Color.Gray);
            description4.SetPadding(0, 8, 0, 0);
            description4.Typeface = typeface1;

            textLayout1.AddView(title1);
            textLayout1.AddView(description1);

            textLayout2.AddView(title2);
            textLayout2.AddView(description2);

            textLayout3.AddView(title3);
            textLayout3.AddView(description3);

            textLayout4.AddView(title4);
            textLayout4.AddView(description4);

            LinearLayout blockLayout1 = new LinearLayout(context);
            blockLayout1.Orientation = Orientation.Vertical;
            blockLayout1.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.MatchParent);
            blockLayout1.SetPadding(0, 0, 50, 0);
            blockLayout1.SetMinimumHeight(280);
            blockLayout1.SetMinimumWidth(280);

            LinearLayout blockLayout2 = new LinearLayout(context);
            blockLayout2.Orientation = Orientation.Vertical;
            blockLayout2.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.MatchParent);
            blockLayout2.SetPadding(0, 0, 50, 0);
            blockLayout2.SetMinimumHeight(280);
            blockLayout2.SetMinimumWidth(280);

            LinearLayout blockLayout3 = new LinearLayout(context);
            blockLayout3.Orientation = Orientation.Vertical;
            blockLayout3.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.MatchParent);
            blockLayout3.SetPadding(0, 0, 50, 0);
            blockLayout3.SetMinimumHeight(280);
            blockLayout3.SetMinimumWidth(280);

            LinearLayout blockLayout4 = new LinearLayout(context);
            blockLayout4.Orientation = Orientation.Vertical;
            blockLayout4.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.MatchParent);
            blockLayout4.SetMinimumHeight(140);
            blockLayout4.SetMinimumWidth(140);

            blockLayout1.AddView(imageLayout1);
            blockLayout1.AddView(textLayout1);

            blockLayout2.AddView(imageLayout2);
            blockLayout2.AddView(textLayout2);

            blockLayout3.AddView(imageLayout3);
            blockLayout3.AddView(textLayout3);

            blockLayout4.AddView(imageLayout4);
            blockLayout4.AddView(textLayout4);

            LinearLayout layoutOfBlockLayouts = new LinearLayout(context);
            layoutOfBlockLayouts.Orientation = Orientation.Horizontal;
            layoutOfBlockLayouts.AddView(blockLayout1);
            layoutOfBlockLayouts.AddView(blockLayout2);
            layoutOfBlockLayouts.AddView(blockLayout3);
            layoutOfBlockLayouts.AddView(blockLayout4);
            scrollView.AddView(layoutOfBlockLayouts);

            mainLayout.AddView(scrollView);
            AddView(mainLayout);
        }
    }
}
