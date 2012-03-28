// Copyright (C) Microsoft Corporation. All Rights Reserved.
// This code released under the terms of the Microsoft Public License
// (Ms-PL, http://opensource.org/licenses/ms-pl.html).

using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Phone.Controls;
//using System.Windows.Controls.DataVisualization;
//using System.Windows.Controls.DataVisualization;
//using System.Windows.Controls.DataVisualization.Charting;

namespace DataVisualizationOnWindowsPhone
{
    public partial class MainPage2 : PhoneApplicationPage
    {
        public MainPage2()
        {
            InitializeComponent();

            myChart.DataContext = new Activities2();

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


}
