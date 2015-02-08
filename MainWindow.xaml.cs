﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using Microsoft.Kinect;
using Kinect.Toolbox;
using KinectMeasurementsLib;

namespace Harley
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// The kinect sensor object
        /// </summary>
        private KinectSensor kinectSensor;

        /// <summary>
        /// The speech object
        /// </summary>
        private Speech speech;

        public MainWindow()
        {
            InitializeComponent();

            this.SwitchToFaceRecognitionActivityWindow();

            // Initialize speech recognition here
        }

        /// <summary>
        /// Switches the window to Face Recognition activity window
        /// </summary>
        private void SwitchToFaceRecognitionActivityWindow()
        {
            Window faceRecogWindow = new FaceRecognitionActivityWindow();
            App.Current.MainWindow = faceRecogWindow;
            faceRecogWindow.Show();
            this.Close();
        }

        /// <summary>
        /// Switches the window to Gesture activity window
        /// </summary>
        private void SwitchToGestureActivityWindow()
        {
            Window gestureWindow = new GestureActivityWindow();
            App.Current.MainWindow = gestureWindow;
            gestureWindow.Show();
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Clean();
        }

        private void Clean()
        {
            // All cleanup work goes here
            // this includes uninitializing Sensors
        }
    }

}
