﻿#pragma checksum "C:\Visual Studio Projects\IEMHR-WP\IEMHR-WP\Registration.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "291C830A8D51CD92CBC1054BBDC79D77"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace IEMHR_WP {
    
    
    public partial class Registration : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock UserNameTextBlock;
        
        internal System.Windows.Controls.TextBox UserNameTextBox;
        
        internal System.Windows.Controls.TextBlock EmailTextBlock;
        
        internal System.Windows.Controls.TextBox EmailTextBox;
        
        internal System.Windows.Controls.TextBlock PasswordTextBlock;
        
        internal System.Windows.Controls.TextBox PasswordTextBox;
        
        internal System.Windows.Controls.TextBlock FullNameTextBlock;
        
        internal System.Windows.Controls.TextBox FullNameTextBox;
        
        internal System.Windows.Controls.Button RegisterButton;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/IEMHR-WP;component/Registration.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.UserNameTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("UserNameTextBlock")));
            this.UserNameTextBox = ((System.Windows.Controls.TextBox)(this.FindName("UserNameTextBox")));
            this.EmailTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("EmailTextBlock")));
            this.EmailTextBox = ((System.Windows.Controls.TextBox)(this.FindName("EmailTextBox")));
            this.PasswordTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("PasswordTextBlock")));
            this.PasswordTextBox = ((System.Windows.Controls.TextBox)(this.FindName("PasswordTextBox")));
            this.FullNameTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("FullNameTextBlock")));
            this.FullNameTextBox = ((System.Windows.Controls.TextBox)(this.FindName("FullNameTextBox")));
            this.RegisterButton = ((System.Windows.Controls.Button)(this.FindName("RegisterButton")));
        }
    }
}

