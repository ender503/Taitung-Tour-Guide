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
    public partial class MainPage : PhoneApplicationPage
    {
        // 建構函式
        public MainPage()
        {
            InitializeComponent();
        }

        private void textBlock1_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/ForestPark.xaml", UriKind.Relative));
            e.Complete();
            e.Handled = true;
        }

        private void textBlock2_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/CoastPark.xaml", UriKind.Relative));
            e.Complete();
            e.Handled = true;
        }

        private void textBlock3_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/GuanShan.xaml", UriKind.Relative));
            e.Complete();
            e.Handled = true;
        }

        private void textBlock4_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/197Road.xaml", UriKind.Relative));
            e.Complete();
            e.Handled = true;
        }

        private void textBlock5_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Museum.xaml", UriKind.Relative));

        }

        private void textBlock6_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/伽路蘭.xaml", UriKind.Relative));
        }

        private void textBlock7_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/三仙台.xaml", UriKind.Relative));
        }

        private void textBlock8_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/小野柳.xaml", UriKind.Relative));
        }

        
    
    }
}