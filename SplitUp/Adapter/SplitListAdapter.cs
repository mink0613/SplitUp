using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SplitUp.DataStructs;
using System.Collections.Generic;

namespace SplitUp.Adapter
{
    class SplitListAdapter : BaseAdapter
    {
        private List<MeetingData> data;
        Context context;

        public SplitListAdapter(Context context)
        {
            this.context = context;
            data = new List<MeetingData>();

            data.Add(new MeetingData(null, -1, -1, null));
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
            SplitListAdapterViewHolder holder = null;

            if (view != null)
                holder = view.Tag as SplitListAdapterViewHolder;

            if (holder == null)
            {
                holder = new SplitListAdapterViewHolder();
                var inflater = context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();
                //replace with your item and your holder items
                //comment back in
                view = inflater.Inflate(Resource.Layout.split_fragment, parent, false);
                view.Tag = holder;
            }

            view.Click += View_Click;

            //fill in your items
            TextView meeting = (TextView)view.FindViewById(Resource.Id.meeting);
            TextView totalParticipate = (TextView)view.FindViewById(Resource.Id.totalParticipate);
            TextView totalAmount = (TextView)view.FindViewById(Resource.Id.amount);
            TextView date = (TextView)view.FindViewById(Resource.Id.date);
            ImageView plusView = (ImageView)view.FindViewById(Resource.Id.plus);

            if (position < data.Count - 1)
            {
                meeting.Text = data[position].GetName();
                totalParticipate.Text = data[position].GetTotalParticipate().ToString();
                totalAmount.Text = data[position].GetTotalAmount().ToString();

                plusView.Visibility = ViewStates.Gone;
            }
            else
            {
                meeting.Visibility = ViewStates.Gone;
                totalParticipate.Visibility = ViewStates.Gone;
                totalAmount.Visibility = ViewStates.Gone;
                date.Visibility = ViewStates.Gone;

                plusView.Visibility = ViewStates.Visible;
                plusView.SetImageResource(Resource.Drawable.plus);
            }

            return view;
        }

        private void View_Click(object sender, System.EventArgs e)
        {
            
        }

        //Fill in cound here, currently 0
        public override int Count
        {
            get
            {
                return data.Count;
            }
        }

        public void AddItem(string name, int totalParticipate, int totalAmount, List<SplitData> split)
        {
            MeetingData newData = new MeetingData(name, totalParticipate, totalAmount, split);
            data.Insert(0, newData);
        }

        public MeetingData GetSelectedItem(int index)
        {
            return data[index];
        }
    }

    class SplitListAdapterViewHolder : Java.Lang.Object
    {
        //Your adapter views to re-use
        //public TextView Title { get; set; }
    }
}