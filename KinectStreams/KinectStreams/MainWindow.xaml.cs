using Microsoft.Kinect;
using System;
using System.Collections.Generic;
using System.Windows;

namespace KinectStreams
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Members

        Mode _mode = Mode.Color;

        KinectSensor _sensor;
        MultiSourceFrameReader _reader;
        IList<Body> _bodies;

        bool _displayBody = false;

        #endregion

        #region Constructor

        public MainWindow()
        {
            InitializeComponent();
        }

        #endregion

        #region Event handlers

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _sensor = KinectSensor.GetDefault();

            if (_sensor != null)
            {
                _sensor.Open();

                _reader = _sensor.OpenMultiSourceFrameReader(FrameSourceTypes.Color | FrameSourceTypes.Depth | FrameSourceTypes.Infrared | FrameSourceTypes.Body);
                _reader.MultiSourceFrameArrived += Reader_MultiSourceFrameArrived;
            }
        }
        static Boolean check = true;
        static int count = 0;
        private void Window_Closed(object sender, EventArgs e)
        {
            if (_reader != null)
            {
                _reader.Dispose();
            }

            if (_sensor != null)
            {
                _sensor.Close();
            }
        }

        void Reader_MultiSourceFrameArrived(object sender, MultiSourceFrameArrivedEventArgs e)
        {
            var reference = e.FrameReference.AcquireFrame();

            // Color
            using (var frame = reference.ColorFrameReference.AcquireFrame())
            {
                if (frame != null)
                {
                    if (_mode == Mode.Color)
                    {
                        camera.Source = frame.ToBitmap();
                    }
                }
            }

            // Depth
            using (var frame = reference.DepthFrameReference.AcquireFrame())
            {
                if (frame != null)
                {
                    if (_mode == Mode.Depth)
                    {
                        camera.Source = frame.ToBitmap();
                    }
                }
            }

            // Infrared
            using (var frame = reference.InfraredFrameReference.AcquireFrame())
            {
                if (frame != null)
                {
                    if (_mode == Mode.Infrared)
                    {
                        camera.Source = frame.ToBitmap();
                    }
                }
            }

            // Body
            using (var frame = reference.BodyFrameReference.AcquireFrame())
            {
                if (frame != null)
                {
                    canvas.Children.Clear();

                    _bodies = new Body[frame.BodyFrameSource.BodyCount];

                    frame.GetAndRefreshBodyData(_bodies);

                    foreach (var body in _bodies)
                    {
                        if (body != null)
                        {
                            if (body.IsTracked)
                            {
                                // Draw skeleton.
                                if (_displayBody)
                                {
                                    canvas.DrawSkeleton(body);
                                }

                                // co-ordinates
                                var headX = body.Joints[JointType.Head].Position.X;
                                var headY = body.Joints[JointType.Head].Position.Y;
                                var leftHandX = body.Joints[JointType.HandLeft].Position.X;
                                var leftHandY = body.Joints[JointType.HandLeft].Position.Y;
                                var rightHandX = body.Joints[JointType.HandRight].Position.X;
                                var rightHandY = body.Joints[JointType.HandRight].Position.Y;
                                var rightHandZ = body.Joints[JointType.HandRight].Position.Z;
                                var hipY = body.Joints[JointType.HipLeft].Position.Y;
                                var rightKneeX = body.Joints[JointType.KneeRight].Position.X;
                                var leftKneeX = body.Joints[JointType.KneeLeft].Position.X;
                                var rightKneeY = body.Joints[JointType.KneeRight].Position.Y;
                                var leftKneeY = body.Joints[JointType.KneeLeft].Position.Y;
                                var rightHipX = body.Joints[JointType.HipRight].Position.X;
                                var rightHipY = body.Joints[JointType.HipRight].Position.Y;
                                var rightHipZ = body.Joints[JointType.HipRight].Position.Z;
                                var rightShoulderX = body.Joints[JointType.ShoulderRight].Position.X;
                                var rightShoulderY = body.Joints[JointType.ShoulderRight].Position.Y;
                                var rightShoulderZ = body.Joints[JointType.ShoulderRight].Position.Z;
                                var neckY = body.Joints[JointType.Neck].Position.Y;
                                var spineShoulderX = body.Joints[JointType.SpineShoulder].Position.X;
                                var spineShoulderY = body.Joints[JointType.SpineShoulder].Position.Y;
                                var spineShoulderZ = body.Joints[JointType.SpineShoulder].Position.Z;
                                var rightElbowX = body.Joints[JointType.ElbowRight].Position.X;
                                var rightElbowY = body.Joints[JointType.ElbowRight].Position.Y;
                                var rightElbowZ = body.Joints[JointType.ElbowRight].Position.Z;
                                var righthand = body.Joints[JointType.HandTipRight].Position;
                                var head = body.Joints[JointType.Head].Position;
                                var neck = body.Joints[JointType.Neck].Position;
                                var rightHandTipY = body.Joints[JointType.HandTipRight].Position.Y;
                                var spineMidY = body.Joints[JointType.SpineMid].Position.Y;
                                var spineMidZ = body.Joints[JointType.SpineMid].Position.Z;
                                var hipRightY = body.Joints[JointType.HipRight].Position.Y;


                                // co-ordinates


                                /*         if (headY < rightHandY)
                                         {
                                             if (check == true)
                                                 count++;
                                             points.Text = count.ToString();
                                             check = false;

                                         }
                                         else if (rightHandY < hipY)
                                         {
                                             check = true;
                                         } end */
                                //----------------------------------------------------------------------------------------------------------------------------------------------//

                                //--- EXERCISE 2


                                /*
                                if (rightHandY < rightKneeY)
                                { 

                                    if (rightHandX < leftKneeX)
                                    {   if (check == true)
                                        {
                                            count++;

                                            points.Text = count.ToString();
                                            check = false;
                                        }
                                    }

                                    else if (rightHandX > rightKneeX)
                                    {
                                        check = true;
                                    }

                                }
                                
  */


                                //no money stretch----


                                /*
                                if (rightHandZ < rightShoulderZ)
                                {

                                    if (rightHandX > rightHipX)
                                    {
                                        if (check == true)
                                        {
                                            count++;

                                            points.Text = count.ToString();
                                            check = false;
                                        }
                                    }

                                    else if (rightHandX <  rightHipX)
                                    {
                                        check = true;
                                    }

                                }
                                */


                                //    ---end no money stretch


                                //Wall


                                /*
                                    if ( rightHandY > spineMidY)
                                    {
                                        if (check == true)
                                        {
                                        if (rightHandY > rightShoulderY)
                                        {
                                            count++;

                                            points.Text = count.ToString();
                                            check = false;
                                        }
                                        }
                                    }

                                    else if (  rightHandY < spineMidY)
                                    {
                                        check = true;
                                    }

                              
                                   */

                                // punches 


                               // cross mid spinebase
                              /*  if (spineMidZ > rightHandZ )
                                {
                                    if (check == true)
                                        count++;
                                    points.Text = count.ToString();
                                    check = false;
                                }
                                else if(spineMidZ < rightHandZ )
                                {
                                    check = true;
                                }
                                

                            */
  


                                // elbow bent


                                /*
                                if (rightElbowZ > rightHipZ) {
                                    if (rightHandY > rightShoulderY)
                                    {
                                        if (check == true)
                                            count++;
                                        points.Text = count.ToString();
                                        check = false;
                                    }

                                    else if (rightHandY < rightShoulderY)
                                    {
                                        check = true;
                                    }
                                }
                                */



                            }
                        }
                    }
                }
            }
        }

        private void Color_Click(object sender, RoutedEventArgs e)
        {
            _mode = Mode.Color;
        }

        private void Depth_Click(object sender, RoutedEventArgs e)
        {
            _mode = Mode.Depth;
        }

        private void Infrared_Click(object sender, RoutedEventArgs e)
        {
            _mode = Mode.Infrared;
        }

        private void Body_Click(object sender, RoutedEventArgs e)
        {
            _displayBody = !_displayBody;
        }

     
        #endregion
    }

    public enum Mode
    {
        Color,
        Depth,
        Infrared
       
    }
}
