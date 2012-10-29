using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Tourguide
{
    public partial class Museum : PhoneApplicationPage
    {
        public Museum()
        {
            InitializeComponent();
        }

        private void textBlock2_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/博物館.xaml", UriKind.Relative));
        }

        private void textBlock3_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/水舞.xaml", UriKind.Relative));
        }
    }
}