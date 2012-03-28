// Copyright (C) Microsoft Corporation. All Rights Reserved.
// This code released under the terms of the Microsoft Public License
// (Ms-PL, http://opensource.org/licenses/ms-pl.html).

using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Phone.Controls;

namespace DataVisualizationOnWindowsPhone
{
    // Class for storing information about an activity
    public class ActivityInfo2
    {
        public string Activity2 { get; set; }
        public int Count2 { get; set; }
    }

    // Class for storing activities
    public class Activities2 : List<ActivityInfo2>
    {
        public Activities2()
        {
            Add(new ActivityInfo2 { Activity2 = "SMS2", Count2 = 1 });
            Add(new ActivityInfo2 { Activity2 = "Email2", Count2 = 2 });
            Add(new ActivityInfo2 { Activity2 = "Calls2", Count2 = 3 });
        }
    }
}