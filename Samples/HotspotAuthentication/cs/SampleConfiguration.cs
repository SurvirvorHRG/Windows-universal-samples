//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************

using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace SDKTemplate
{
    public partial class MainPage : Page
    {
        public const string FEATURE_NAME = "Hotspot Authentication";

        List<Scenario> scenarios = new List<Scenario>
        {
            new Scenario() { Title="Initialization", ClassType=typeof(Scenario1_Initialization)},
            new Scenario() { Title="Authentication by background task", ClassType=typeof(Scenario2_BackgroundTask)},
            new Scenario() { Title="Authentication by foreground app", ClassType=typeof(Scenario3_ForegroundApp)},
        };
    }

    public class Scenario
    {
        public string Title { get; set; }
        public Type ClassType { get; set; }
    }
}
