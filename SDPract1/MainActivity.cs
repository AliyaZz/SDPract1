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

            LinearLayout linearLayout = new LinearLayout(BaseContext);
            linearLayout.Orientation = Orientation.Vertical;

            AddContentView(linearLayout, new LinearLayout.LayoutParams(LinearLayout.LayoutParams.MatchParent,
          LinearLayout.LayoutParams.MatchParent));

            

            SDPract1Lib.Card1Light card1light = new SDPract1Lib.Card1Light(this);
            SDPract1Lib.Card1Dark card1dark = new SDPract1Lib.Card1Dark(this);
            SDPract1Lib.Card2Light card2light = new SDPract1Lib.Card2Light(this);
            SDPract1Lib.Card2Dark card2dark = new SDPract1Lib.Card2Dark(this);

            linearLayout.AddView(card1light);
            linearLayout.AddView(card1dark);
            linearLayout.AddView(card2light);
            linearLayout.AddView(card2dark);
        }
    }
}