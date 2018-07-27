using Android.App;
using Android.OS;
using Android.Views;
using SplitUp.Adapter;
using SplitUp.DataStructs;
using System.Collections.Generic;

namespace SplitUp.fragment
{
    public class SplitListFragment : ListFragment
    {
        private SplitListAdapter adapter;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
            adapter = new SplitListAdapter(Activity);

            this.ListAdapter = adapter;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);
            
            return base.OnCreateView(inflater, container, savedInstanceState);
        }

        public void AddItem(string name, int totalParticipate, int totalAmount, List<SplitData> split)
        {
            adapter.AddItem(name, totalParticipate, totalAmount, split);
        }
    }
}