using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SplitUp.DataStructs;
using System.Collections.Generic;

namespace SplitUp.Adapter
{
    class SplitContentViewAdapter : BaseAdapter<SplitData>
    {
        private Context context;
        private List<SplitData> data;
        private EditText amountTextView;
        private ListView listView;
        private FriendCheckViewAdapter adapter;

        public SplitContentViewAdapter(Context context, List<SplitData> data) : base ()
        {
            this.context = context;
            this.data = data == null ? new List<SplitData>() : data;
        }

        public override SplitData this[int position]
        {
            get
            {
                return data[position];
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return position;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;
            SplitResultListViewAdapterViewHolder holder = null;

            if (view != null)
                holder = view.Tag as SplitResultListViewAdapterViewHolder;

            if (holder == null)
            {
                holder = new SplitResultListViewAdapterViewHolder();
                var inflater = context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();
                
                view = inflater.Inflate(Resource.Layout.SplitContentView, parent, false);
                view.Tag = holder;
            }

            //fill in your items
            //holder.Title.Text = "new text here";
            amountTextView = (EditText) view.FindViewById(Resource.Id.amount);
            listView = (ListView) view.FindViewById(Resource.Id.friendList);

            amountTextView.Text = data[position].GetAmount().ToString();
            adapter = new FriendCheckViewAdapter(view.Context, data[position].GetParticipants());
            listView.Adapter = adapter;

            return view;
        }

        //Fill in cound here, currently 0
        public override int Count
        {
            get
            {
                return data.Count;
            }
        }

    }

    class SplitResultListViewAdapterViewHolder : Java.Lang.Object
    {
        //Your adapter views to re-use
        //public TextView Title { get; set; }
    }
}