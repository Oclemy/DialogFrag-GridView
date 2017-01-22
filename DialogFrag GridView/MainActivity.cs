using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace DialogFrag_GridView
{
    [Activity(Label = "DialogFrag_GridView", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private FragmentManager fm;
        private TVShowFragment tv;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);
            button.Click += button_Click;

            fm = this.FragmentManager;
            tv=new TVShowFragment();
        }

        void button_Click(object sender, EventArgs e)
        {
            tv.Show(fm, "TV_tag");
        }

    }
}

