using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Windows.Input;
using Leap;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsPresentation;
using GMap.NET.WindowsForms.Markers;
using System.Threading;
using GMap.NET.MapProviders;
using GMapRoute = GMap.NET.WindowsForms.GMapRoute;

namespace LeapMotionWindowsForms
{
    public partial class Form1 : Form
    {

        private byte[] imagedata = new byte[1];
        private Controller controller = new Controller();
        private int blokada = 0;
        private int blokada2 = 0;
        Bitmap bitmap = new Bitmap(640, 480, System.Drawing.Imaging.PixelFormat.Format8bppIndexed);
        private List<PointLatLng> _points;
        PointLatLng start = new PointLatLng(-25.974134, 32.593042);
        PointLatLng end = new PointLatLng(-25.959048, 32.592827);
        //private


        public Form1()
        {
            InitializeComponent();
            _points = new List<PointLatLng>();
            controller.EventContext = WindowsFormsSynchronizationContext.Current;
            controller.FrameReady += newFrameHandler;
            controller.ImageReady += onImageReady;
            controller.ImageRequestFailed += onImageRequestFailed;

            //set greyscale palette for image Bitmap object
            ColorPalette grayscale = bitmap.Palette;
            for (int i = 0; i < 256; i++)
            {
                grayscale.Entries[i] = Color.FromArgb((int)255, i, i, i);
            }
            bitmap.Palette = grayscale;
        }

        void newFrameHandler(object sender, FrameEventArgs eventArgs)
        {
            Frame frame = eventArgs.frame;
            //The following are Label controls added in design view for the form
            this.displayID.Text = frame.Id.ToString();
            this.displayTimestamp.Text = frame.Timestamp.ToString();
            this.displayFPS.Text = frame.CurrentFramesPerSecond.ToString();
            this.displayHandCount.Text = frame.Hands.Count.ToString();

            

            //Hand hand = new Hand();
            foreach (Hand hand in frame.Hands)
            {
                float pitch = hand.Direction.Pitch;
                float yaw = hand.Direction.Yaw;
                float roll = hand.PalmNormal.Roll;

                double degPitch = pitch * (180 / Math.PI);
                double degYaw = yaw * (180 / Math.PI);
                double degRoll = roll * (180 / Math.PI);

                int pit = (int)(degPitch/2);
                int yaw2 = (int)(degYaw/4);
                float roll2 = (float)(degRoll/5);

                txtPitch.Text = degPitch.ToString();
                txtYaw.Text = degYaw.ToString();
                txtRoll.Text = degRoll.ToString();


                map.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleMap; 
                map.MinZoom = 1;
                map.MaxZoom = 100;
                //map.Zoom = 1;
                //hand.PalmPosition;

                // map.ShowCenter = false;
                

                string handName = hand.IsLeft ? "Lewa ręka" : "Prawa ręka";
                txtDetectHand.Text = handName;

                if (frame.Hands.Count != 2)
                {
                    blokada2 = 0;
                    if(map.Zoom < 2)
                    {
                        map.Position = new PointLatLng(degPitch,degYaw);
                    }
                    else if( map.Zoom > 4)
                    {
                        map.Position = new PointLatLng(pit, yaw2);
                    }

                    
                    //int blokada = 0;
                    if (hand.PinchDistance < 20 && blokada < 2)
                    {
                        map.Zoom += 2;
                        blokada++;
                    }
                    else if (hand.PinchDistance > 90 && blokada > 0)
                    {
                        map.Zoom -= 2;
                        blokada--;
                    }
                }
                else if( blokada2 < 1)
                {
                    PointLatLng point = new PointLatLng(degPitch, degYaw);
                    //_points.Add(point);
                    GMap.NET.WindowsForms.GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_big_stop);
                    GMapOverlay markers = new GMapOverlay("markers");
                    markers.Markers.Add(marker);
                    map.Overlays.Add(markers);
                    blokada2++;

                    // txtPrzyklad.Text =;
                    if (!(point.IsEmpty))
                    {
                        _points.Add(point);
                    }
                    //if(!(marker.Size.IsEmpty))
                    //{
                    //    MapRoute route = GMap.NET.MapProviders.GoogleMapProvider.Instance.GetRoute(marker., end, false, false, 15);
                    //}
                    //txtPrzyklad.Text = marker.Size.ToString();
                    
                    //if (!(point.IsEmpty))
                    //{
                        
                    //    _points.Add(point);
                    //    //txtPrzyklad.Text = _points.Count.ToString();
                    //}
                    

                }

                if (_points.Count != null )
                {
                    txtPrzyklad.Text = _points.Count.ToString();
                    //var route = GoogleMapProvider.Instance.GetRoute(_points[0], _points[1], false, false, 14);

                    //var r = new GMapRoute(route.Points, "My route")
                    //{
                    //    Stroke = new Pen(Color.Red, 5)
                    //};
                    //var routes = new GMapOverlay("routes");
                    //routes.Routes.Add(r);
                    //map.Overlays.Add(routes);
                }
                //if(hand.IsLeft)
                //{
                //    map.Bearing = roll2;
                //}




                //while (map.Zoom <= 2)
                //{
                //    if (hand.PinchDistance < 15)
                //    {
                //        map.Zoom -= 2;
                //        Thread.Sleep(3000);
                //    }
                //}


                //Vector aPoint = new Vector(10f, 0f, 0f);
                //Vector origin = Vector.Zero;
                //float distance = origin.DistanceTo(aPoint); // distance = 10

                //Vector filteredHandPosition = hand.StabilizedPalmPosition;

                //filteredHandPosition.AngleTo

                txtZoom.Text = map.Zoom.ToString();

                //while(frame.Hands.Count == 2)
                //{
                //    if(hand.IsRight)
                //    {
                //        map.Position = new PointLatLng(pit, yaw2);
                //    }
                //    else
                //    {

                //    }


                //}\
                //float handS = hand.PinchStrength;
                //double handss = (double)handS;
                //if (hand.PinchDistance < 15 && map.Zoom < 50)
                //{
                //    map.Zoom = 20;
                //    Thread.Sleep(3000);
                //}

                //while(map.Zoom <= 2)
                //{
                //    if (hand.PinchDistance < 15)
                //    {
                //        map.Zoom -= 2;
                //        Thread.Sleep(3000);
                //    }
                //}
                //}
                //else if (hand.PinchDistance > 50)
                //{
                //    map.Zoom += 2;
                //}
                //else
                //{
                //    map.Zoom = 5;
                //}
                //map.Zoom = 2;

                // map.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleMap;
                map.CanDragMap = true;
                //map.Zoom = 2;
                //map.Position = new PointLatLng(pit,yaw2);
                // lets the user drag the map with the left mouse button
                //if (intPitch > 40)
                //{
                //    map.Zoom = 15;
                //}

                //if(hand.IsLeft)
                //{
                //    PointLatLng point = new PointLatLng(cos, cos2);
                //    GMap.NET.WindowsForms.GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_big_stop);
                //    GMapOverlay markers = new GMapOverlay("markers");
                //    markers.Markers.Add(marker);
                //    map.Overlays.Add(markers);
                //}
                //map.Position = new GMap.NET.PointLatLng(0,-180);
                //if (hand.IsRight)


            }
           

            controller.RequestImages(frame.Id, Leap.Image.ImageType.DEFAULT, imagedata);
        }

        void onImageRequestFailed(object sender, ImageRequestFailedEventArgs e)
        {
            if (e.reason == Leap.Image.RequestFailureReason.Insufficient_Buffer)
            {
                imagedata = new byte[e.requiredBufferSize];
            }
            Console.WriteLine("Image request failed: " + e.message);
        }

        void onImageReady(object sender, ImageEventArgs e)
        {
            Rectangle lockArea = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            BitmapData bitmapData = bitmap.LockBits(lockArea, ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);
            byte[] rawImageData = imagedata;
            System.Runtime.InteropServices.Marshal.Copy(rawImageData, 0, bitmapData.Scan0, e.image.Width * e.image.Height * 2 * e.image.BytesPerPixel);
            bitmap.UnlockBits(bitmapData);
            displayImages.Image = bitmap;
        }

  

        private void btnLoadIntoMap_Click(object sender, EventArgs e)
        {
            map.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleMap;
            map.MinZoom = 2;
            map.MaxZoom = 17;
            // whole world zoom
            map.Zoom = 2;
            // lets the map use the mousewheel to zoom
            map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            // lets the user drag the map
            map.CanDragMap = true;
            // lets the user drag the map with the left mouse button
            map.DragButton = MouseButtons.Left;
        }

        private void txtGetRoute_Click(object sender, EventArgs e)
        {

            txtLat.Text =  _points.Last().Lat.ToString();
            txtLong.Text = _points.Last().Lng.ToString();

            //PointLatLng start = new PointLatLng(-25.974134, 32.593042);
            //PointLatLng end = new PointLatLng(-25.959048, 32.592827);
            //var route = GoogleMapProvider.Instance.GetRoadsRoute(_points,false);

            //GDirections ss;
            //var xx = GMapProviders.GoogleMap.GetDirections(out ss, _points.First(), _points.Last(), false, false, false, false, false);
            //GMapRoute r = new GMapRoute(ss.Route, "My route");

            //RoutingProvider routingProvider =
            //    map.MapProvider as RoutingProvider ?? GMapProviders.OpenStreetMap;



            //var route = GoogleMapProvider.Instance.GetRoute(_points.First(),_points.Last(), false,false,2);

            //GMapRoute r = new GMapRoute(route.Points, "My route");
            //////{
            //////    Stroke = new Pen(Color.Red, 5)
            //////};
            //GMapOverlay routes = new GMapOverlay("routes");
            //routes.Routes.Add(r);
            //map.Overlays.Add(routes);
            //map.Refresh();
            //////txtPrzyklad.Text = ;
            //MessageBox.Show(_points.First().Lat.ToString() + " " + _points.First().Lng.ToString() + " " + _points.Last().Lat.ToString() + " " + _points.Last().Lng.ToString() + " " );  


            ///dziala usuwanie
            //if(map.Overlays.Count > 0)
            //{
            //    map.Overlays.RemoveAt(0);
            //    map.Refresh();
            //}


            ///dziala polygon
            //var polygon = new GMap.NET.WindowsForms.GMapPolygon(_points, "My Area")
            //{
            //    Stroke = new Pen(Color.DarkBlue, 3),
            //    Fill = new SolidBrush(Color.BurlyWood)
            //};
            //var polygons = new GMapOverlay("polygons");
            //polygons.Polygons.Add(polygon);
            //map.Overlays.Add(polygons);
        }



        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        //private void gMapControl2_Load(object sender, EventArgs e)
        //{

        //}
    }
}