using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace DialogFrag_GridView
{
    internal class TVShowFragment : DialogFragment
    {
        private GridView gv;

        private String[] tvshows =
        {
            "BlackList", "Crisis", "Blindspot", "Breaking Bad", "Gotham", "Banshee", "Suits",
            "Ghost Rider", "Game of Thrones"
        };

        private ArrayAdapter adapter;


        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View rootView = inflater.Inflate(Resource.Layout.fraglayout, container, false);

            //SET TITLE
            this.Dialog.SetTitle("Tv Shows");

            gv = rootView.FindViewById<GridView>(Resource.Id.gv);
            //ADAPTER
            adapter = new ArrayAdapter(this.Activity, Android.Resource.Layout.SimpleListItem1, tvshows);
            gv.Adapter = adapter;

            //ITEM CLICKS
            gv.ItemClick += gv_ItemClick;

            return rootView;
        }

        private void gv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this.Activity,tvshows[e.Position],ToastLength.Short).Show();
        }
    }
}
    