using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Views;
using Android.Content;
using Android.Widget;
using AndroidX.RecyclerView.Widget;

namespace SDPract1Lib
{
    public class ViewHolderClass : RecyclerView.ViewHolder
    {
        public TextView nameTxt;
        public ImageView imageView;
        public ViewHolderClass (View view): base (view)
        {
            nameTxt = view.FindViewById<TextView>(Resource.Id.nameTxt);
            imageView = view.FindViewById<ImageView>(Resource.Id.imageView);
        }
    }
}
