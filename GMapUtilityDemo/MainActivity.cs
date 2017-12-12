using Android.App;
using Android.OS;
using Android.Gms.Maps;
using Com.Google.Maps.Android.Clustering;
using System.Collections.Generic;

namespace GMapUtilityDemo
{
    [Activity(Label = "GoogleMapUtilityDemo", MainLauncher = true)]
    public class MainActivity : Activity, IOnMapReadyCallback
    {
        private GoogleMap _map;
        private ClusterManager _clusterManager;
       

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Map);

            MapFragment mapFragment = (MapFragment)FragmentManager.FindFragmentById(Resource.Id.map);
            mapFragment.GetMapAsync(this);
        }


        /// <summary>
        /// Called when map is ready.
        /// </summary>
        /// <param name="googleMap">The google map.</param>
        public void OnMapReady(GoogleMap googleMap)
        {
            _map = googleMap;

            if (_map != null)
            {
                // Initializing the ClusterManager and calling AddClusterItem method.
                _clusterManager = new ClusterManager(this, _map);
                AddClusterItems();
            }
        }


        /// <summary>
        /// Adds the cluster item to the ClusterManager. 
        /// Example method from: https://developers.google.com/maps/documentation/android-api/utility/marker-clustering
        /// </summary>
        private void AddClusterItems()
        {
            // Set some lat/lng coordinates to start with.
            double lat = 51.5145160;
            double lng = -0.1270060;

            // List of ClusterItems.
            List<ClusterItem> items = new List<ClusterItem>();

            // Add ten cluster items in close proximity, for purposes of this example.
            for (int i = 0; i < 10; i++)
            {
                double offset = i / 60d;
                lat = lat + offset;
                lng = lng + offset;

                ClusterItem clusterItem = new ClusterItem(lat, lng);
                items.Add(clusterItem);

                _clusterManager.AddItems(items);
            }
        }
    }

}

