using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace MyFragment.Droid
{
    public class StoryFragment : Fragment
    {
        public static StoryFragment NewInstance(int headlineID)
        {
            var storyFrag = new StoryFragment { Arguments = new Bundle() };
            storyFrag.Arguments.PutInt("current_headline_id", headlineID);
            return storyFrag;
        }

        public int ShowHeadlineId
        {
            get { return Arguments.GetInt("current_headline_id", 0); }
        }
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            View view = inflater.Inflate(Resource.Layout.StoryFragment, container, false);
            TextView displayStory = (TextView)view.FindViewById(Resource.Id.newsStory_tv);
            int headlineId = ShowHeadlineId;
            displayStory.Text = FinancialNews.Stories[headlineId];
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            return view;
        }
    }
}