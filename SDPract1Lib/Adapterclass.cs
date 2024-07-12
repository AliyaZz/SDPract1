using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Views;
using Android.Content;
using Android.Widget;
using static Android.Views.ViewGroup;
using AndroidX.RecyclerView.Widget;

namespace SDPract1Lib
{
    public class Adapterclass : RecyclerView.Adapter
    {
        public event EventHandler<int> ItemClick;
        public View view;

        public Adapterclass(View view)
        {
            this.view = view;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            ViewHolderClass viewHolderClass = holder as ViewHolderClass;
            if (viewHolderClass != null && viewHolderClass.nameTxt != null) viewHolderClass.nameTxt.Text = view.;
                            
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View view = LayoutInflater.From(parent.Context).Inflate( Resource.Layout.CardHorizontal, parent, false);
            return new ViewHolderClass(view);
        }

        public override int ItemCount => view.;
    }
}
