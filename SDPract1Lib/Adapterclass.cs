using System;
using Android.Accounts;
using Android.Views;
using AndroidX.RecyclerView.Widget;

namespace SDPract1Lib
{
    public class Adapterclass : RecyclerView.Adapter
    {
        List<VerticalCardForRecyclerView> cards;

        public List<VerticalCardForRecyclerView> Cards { get => cards; set => cards = value;}

        public Adapterclass(List<VerticalCardForRecyclerView> cards)
        {
            this.cards = cards;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var frame = new FrameLayout(parent.Context);
            frame.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);

            var cardViewTitle = new VerticalCardForRecyclerView(parent.Context);
            cardViewTitle.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
            frame.AddView(cardViewTitle);
            return new ViewHolderClass(frame);
        }

        public override int ItemCount => cards.Count;
    }
}
