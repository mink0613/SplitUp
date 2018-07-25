using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SplitUp.DataStructs;
using System.Collections.Generic;

namespace SplitUp.Adapter
{
    class FriendCheckViewAdapter : BaseAdapter<Participant>
    {
        private Context context;
        private List<Participant> participants;

        public FriendCheckViewAdapter(Context context, List<Participant> participants)
        {
            this.context = context;
            this.participants = participants == null ? new List<Participant>() : participants;
        }

        public override Participant this[int position]
        {
            get
            {
                return participants[position];
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
            FriendCheckViewAdapterViewHolder holder = null;

            if (view != null)
                holder = view.Tag as FriendCheckViewAdapterViewHolder;

            if (holder == null)
            {
                holder = new FriendCheckViewAdapterViewHolder();
                var inflater = context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();
                
                view = inflater.Inflate(Resource.Layout.FriendCheckView, parent, false);
                view.Tag = holder;
            }

            TextView friendNameTextView = (TextView) view.FindViewById(Resource.Id.friendName);
            friendNameTextView.Text = participants[position].GetName();

            CheckBox participateCheckBox = (CheckBox) view.FindViewById(Resource.Id.participateCheckBox);
            participateCheckBox.Checked = participants[position].GetIsParticipate();

            CheckBox payCheckBox = (CheckBox) view.FindViewById(Resource.Id.payCheckBox);
            payCheckBox.Checked = participants[position].GetIsPay();

            return view;
        }

        //Fill in cound here, currently 0
        public override int Count
        {
            get
            {
                return participants.Count;
            }
        }

    }

    class FriendCheckViewAdapterViewHolder : Java.Lang.Object
    {
        //Your adapter views to re-use
        //public TextView Title { get; set; }
    }
}