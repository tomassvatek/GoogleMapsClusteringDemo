using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Gms.Maps.Model;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Google.Maps.Android.Clustering;

namespace GMapUtilityDemo
{
    public class ClusterItem : Java.Lang.Object, IClusterItem
    {
        public ClusterItem(Tree tree)
        {
            Tree = tree;
            Position = new LatLng(tree.Lat, tree.Lon);
            Title = tree.Name;
            Snippet = tree.Description;
        }

        public ClusterItem(IntPtr handle, Android.Runtime.JniHandleOwnership transfer)
            : base(handle, transfer)
        {

        }

        public LatLng Position { get; set; }

        public string Snippet { get; set; }

        public string Title { get; set; }

        public Tree Tree { get; set; } 
    }
}