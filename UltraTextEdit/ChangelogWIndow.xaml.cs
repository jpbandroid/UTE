﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI.Composition.SystemBackdrops;
using Microsoft.UI.Windowing;
using Microsoft.UI;
using Windows.UI;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace UltraTextEdit
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ChangelogWindow : Window
    {
        public ChangelogWindow()
        {
            this.InitializeComponent();
            this.SetWindowSize(550, 500);
            SystemBackdrop = new MicaBackdrop()
            {
                Kind = MicaKind.BaseAlt
            };
            var appWindow = AppWindow;
            var titleBar = appWindow.TitleBar;
            titleBar.ExtendsContentIntoTitleBar = true;
            bool isTallTitleBar = true;
            if (AppWindowTitleBar.IsCustomizationSupported() && appWindow.TitleBar.ExtendsContentIntoTitleBar)
            {
                AppWindow.TitleBar.ButtonBackgroundColor = Colors.Transparent;
                AppWindow.TitleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
                AppWindow.TitleBar.ButtonHoverBackgroundColor = Color.FromArgb(25, 255, 255, 255);
                AppWindow.TitleBar.ButtonPressedBackgroundColor = Color.FromArgb(25, 200, 200, 200);
                if (isTallTitleBar)
                {
                    appWindow.TitleBar.PreferredHeightOption = TitleBarHeightOption.Tall;
                }
                else
                {
                    appWindow.TitleBar.PreferredHeightOption = TitleBarHeightOption.Standard;
                }
            }
        }

        private void okclick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
