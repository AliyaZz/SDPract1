using Android.Views;
using AndroidX.RecyclerView.Widget;

namespace SDPract1Lib
{
    public class ViewHolderClass : RecyclerView.ViewHolder
    {
        #region Public methods
        public CardForRecyclerView Custom { get; set; }
        public ViewHolderClass(View view) : base(view)
        {

        }

        #endregion
    }
}
