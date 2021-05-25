using System;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Temp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void OnNavigate(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {

            if (args.SelectedItem as NavigationViewItem is var navigateTo)
            {
                var ns = $"Weather.History.Pages";
                var targetPage = navigateTo.Tag as string;
                var targetType = Type.GetType($"{ns}.{targetPage}");

                if (targetType !=null)
                {
                    contentFrame.Navigate(targetType);
                }
            }
        }
    }
}
