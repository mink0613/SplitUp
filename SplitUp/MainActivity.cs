using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using SplitUp.Adapter;
using System.Collections.Generic;
using SplitUp.DataStructs;
using System;

namespace SplitUp
{
    [Activity(Label = "@string/app_name", Theme = "@android:style/Theme.NoTitleBar", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private ListView listView;
        private SplitContentViewAdapter adapter;
        private List<SplitData> data;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            
            listView = (ListView) FindViewById(Resource.Id.mainSplitResultListView);
            data = GenerateSampleData();

            adapter = new SplitContentViewAdapter(this, data);
            listView.Adapter = adapter;
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

