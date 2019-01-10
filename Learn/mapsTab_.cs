using Foundation;
using System;
using UIKit;
using MapKit;
using CoreGraphics;
using System.IO;
using CoreLocation;

namespace Learn
{
    public partial class mapsTab : UIViewController
    {
        public mapsTab (IntPtr handle) : base (handle)
        {
        }

        public void alertView(string Title, string Message)
        {
            UIAlertView alert = new UIAlertView
            {
                Title = Title,
                Message = Message
            };
            alert.AddButton("Ok");
            alert.Show();
        }

        public void ShowLogin()
        {
            UIStoryboard storyboard = this.Storyboard;
            ViewController viewController = (ViewController)
            storyboard.InstantiateViewController("ViewController");
            this.PresentViewController(viewController, true, null);
        }

        MKMapView mapView;
        UISegmentedControl mapTypes;
        CLLocationManager locationManager = new CLLocationManager();

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Title = "User Location";

            mapView = new MKMapView(View.Bounds);
            mapView.AutoresizingMask = UIViewAutoresizing.FlexibleDimensions;
            //mapView.MapType = MKMapType.Standard; // this is the default
            //mapView.MapType = MKMapType.Satellite;
            //mapView.MapType = MKMapType.Hybrid;
            View.AddSubview(mapView);

            //Request permission to access device location - necessary on iOS 8.0 and above
            //Don't forget to set NSLocationWhenInUseUsageDescription in Info.plist
            locationManager.RequestWhenInUseAuthorization();

            // this is required to show the blue dot indicating user-location
            mapView.ShowsUserLocation = true;

            Console.WriteLine("initial loc:" + mapView.UserLocation.Coordinate.Latitude + "," + mapView.UserLocation.Coordinate.Longitude);

            mapView.DidUpdateUserLocation += (sender, e) => {
                if (mapView.UserLocation != null)
                {
                    Console.WriteLine("userloc:" + mapView.UserLocation.Coordinate.Latitude + "," + mapView.UserLocation.Coordinate.Longitude);
                    CLLocationCoordinate2D coords = mapView.UserLocation.Coordinate;
                    MKCoordinateSpan span = new MKCoordinateSpan(MilesToLatitudeDegrees(2), MilesToLongitudeDegrees(2, coords.Latitude));
                    mapView.Region = new MKCoordinateRegion(coords, span);
                }
            };

            if (!mapView.UserLocationVisible)
            {
                // user denied permission, or device doesn't have GPS/location ability
                Console.WriteLine("userloc not visible, show cupertino");
                CLLocationCoordinate2D coords = new CLLocationCoordinate2D(37.33233141, -122.0312186); // cupertino
                MKCoordinateSpan span = new MKCoordinateSpan(MilesToLatitudeDegrees(20), MilesToLongitudeDegrees(20, coords.Latitude));
                mapView.Region = new MKCoordinateRegion(coords, span);
            }

            int typesWidth = 260, typesHeight = 30, distanceFromBottom = 60;
            mapTypes = new UISegmentedControl(new CGRect((View.Bounds.Width - typesWidth) / 2, View.Bounds.Height - distanceFromBottom, typesWidth, typesHeight));
            mapTypes.BackgroundColor = UIColor.White;
            mapTypes.Layer.CornerRadius = 5;
            mapTypes.ClipsToBounds = true;

            View.AddSubview(mapTypes);
        }

        public double MilesToLatitudeDegrees(double miles)
        {
            double earthRadius = 3960.0;
            double radiansToDegrees = 180.0 / Math.PI;
            return (miles / earthRadius) * radiansToDegrees;
        }

        public double MilesToLongitudeDegrees(double miles, double atLatitude)
        {
            double earthRadius = 3960.0;
            double degreesToRadians = Math.PI / 180.0;
            double radiansToDegrees = 180.0 / Math.PI;

            // derive the earth's radius at that point in latitude
            double radiusAtLatitude = earthRadius * Math.Cos(atLatitude * degreesToRadians);
            return (miles / radiusAtLatitude) * radiansToDegrees;

        }
    }
}
