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
    public class ClusterItem : IClusterItem
    {
        private LatLng _position;
        private string _title;
        private string _snippet;

        public ClusterItem()
        {
        }

        public ClusterItem(double lat, double lon)
        {
            _position = new LatLng(lat, lon);
        }

        public ClusterItem(double lat, double lon, string title, string snippet)
        {
            _position = new LatLng(lat, lon);
            _title = title;
            _snippet = snippet;
        }


        public LatLng Position { get { return _position; } }

        public string Snippet { get { return _snippet; } }

        public string Title { get { return _title; } }

        // This property is extra in contrast with original utility. I dont know ho to implement it.
        public IntPtr Handle { get; }

        // This method is extra in contrast with original utility. I dont know ho to implement it.
        public void Dispose()
        {
        }
    }
}