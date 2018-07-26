using Android.App;
using Android.OS;
using Android.Support.V7.App;
using SplitUp.DataStructs;
using SplitUp.fragment;
using System;
using System.Collections.Generic;

namespace SplitUp
{
    //[Activity(Label = "@string/app_name", Theme = "@style/Theme.AppCompat", MainLauncher = true)]
    [Activity(Label = "@string/app_name", Theme = "@android:style/Theme.NoTitleBar", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private List<SplitData> data;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            data = GenerateSampleData();
            MeetingData meeting = new MeetingData("Test", data.Count, 100, data);

            SplitListFragment fragment = (SplitListFragment)FragmentManager.FindFragmentById(Resource.Layout.split_list_fragment);
            fragment.AddItem("Test", data.Count, 100, data);

            //listView = (ListView) FindViewById(Resource.Id.mainSplitResultListView);
            
        }

        private List<SplitData> GenerateSampleData()
        {
            List<SplitData> data = new List<SplitData>();
            List<Participant> part = new List<Participant>();
            part.Add(new Participant("Derrick Rose", true, true));
            part.Add(new Participant("James Harden", true, false));
            part.Add(new Participant("Chris Paul", true, false));

            SplitData sample = new SplitData(DateTime.Now, part, 100, "Derrick Rose");
            data.Add(sample);

            SplitData sample2 = new SplitData(DateTime.Now, part, 100, "Derrick Rose2");
            data.Add(sample2);

            return data;
        }
    }
}

