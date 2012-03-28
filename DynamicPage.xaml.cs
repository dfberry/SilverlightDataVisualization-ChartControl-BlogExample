// Copyright (C) Microsoft Corporation. All Rights Reserved.
// This code released under the terms of the Microsoft Public License
// (Ms-PL, http://opensource.org/licenses/ms-pl.html).

using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Phone.Controls;

namespace DataVisualizationOnWindowsPhone
{
    
    public partial class DynamicPage : PhoneApplicationPage
    {


        public DynamicPage()
        {
            InitializeComponent();

            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
        }
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            ChartActivity.DataContext = App.activities2;

        }

    }


}
