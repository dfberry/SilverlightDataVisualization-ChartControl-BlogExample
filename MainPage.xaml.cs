// Copyright (C) Microsoft Corporation. All Rights Reserved.
// This code released under the terms of the Microsoft Public License
// (Ms-PL, http://opensource.org/licenses/ms-pl.html).

using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Phone.Controls;

namespace DataVisualizationOnWindowsPhone
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnOrientationChanged(OrientationChangedEventArgs e)
        {
            base.OnOrientationChanged(e);

            // Set appropriate template for new orientation
            ControlTemplate template;
            switch (e.Orientation)
            {
                case PageOrientation.Portrait:
                case PageOrientation.PortraitDown:
                case PageOrientation.PortraitUp:
                default:
                    template = Application.Current.Resources["PhoneChartPortraitTemplate"] as ControlTemplate;
                    break;
                case PageOrientation.Landscape:
                case PageOrientation.LandscapeLeft:
                case PageOrientation.LandscapeRight:
                    template = Application.Current.Resources["PhoneChartLandscapeTemplate"] as ControlTemplate;
                    break;
            }
            myChart.Template = template;
        }
    }
    // Class for storing information about an activity
    public class ActivityInfo
    {
        public string Activity { get; set; }
        public int Count { get; set; }
    }

    // Class for storing activities
    public class Activities : List<ActivityInfo>
    {
        public Activities()
        {
            Add(new ActivityInfo { Activity = "SMS", Count = 30 });
            Add(new ActivityInfo { Activity = "Email", Count = 20 });
            Add(new ActivityInfo { Activity = "Calls", Count = 10 });
        }
    }

}
