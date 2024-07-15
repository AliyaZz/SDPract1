using Android.Views;
using AndroidX.RecyclerView.Widget;

namespace SDPract1Lib
{
    public class Adapterclass : RecyclerView.Adapter
    {
        #region Fields

        List<CardForRecyclerView> cards;

        int pos;

        #endregion

        #region Properties
        bool IsHorizontal { get; set; }

        bool IsDark { get; set; }

        public List<string> TitleInputs {  get; set; }

        public List<string> DescriptionInputs {  get; set; }

        #endregion

        #region ctor

        public Adapterclass(bool isHorizontal, bool isDark)
        {
            IsHorizontal = isHorizontal;
            IsDark = isDark;
        }

        #endregion

        #region Overridden base members
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            pos = position;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var frame = new FrameLayout(parent.Context);
            frame.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);

            var cardView = new CardForRecyclerView(parent.Context, IsHorizontal);
            cardView.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);

            if (IsDark == false)
            {
                cardView.SetBackgroundResource(Resource.Drawable.backgroundcardlight);
            }
            else
            {
                cardView.SetBackgroundResource(Resource.Drawable.backgroundcarddark);
            }

            if (IsHorizontal)
            {
                frame.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);
                cardView.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
            }

            cardView.Title = TitleInputs[pos];
            cardView.Description = DescriptionInputs[pos];

            frame.AddView(cardView);

            if (IsHorizontal)
                frame.SetPadding(10, 10, 10, 10);

            var holder = new ViewHolderClass(frame);
            return holder;
        }

        public override int ItemCount => TitleInputs.Count;

        #endregion
    }
}
