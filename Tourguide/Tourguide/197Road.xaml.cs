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
    public partial class _197Road : PhoneApplicationPage
    {
        public _197Road()
        {
            InitializeComponent();
        }

        private void textBlock2_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/197入口.xaml", UriKind.Relative));
            e.Complete();
            e.Handled = true;
        }

        private void textBlock3_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/197-1.xaml", UriKind.Relative));
            e.Complete();
            e.Handled = true;
        }

        private void textBlock4_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/1972.xaml", UriKind.Relative));
            e.Complete();
            e.Handled = true;
        }

        private void textBlock5_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/1973.xaml", UriKind.Relative));
            e.Complete();
            e.Handled = true;
        }
    }
}