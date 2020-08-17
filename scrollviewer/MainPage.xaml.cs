using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace scrollviewer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        float count = 1;
        public MainPage()
        {
            this.InitializeComponent();
            btn.Content = "click me";
            btn.Click += Btn_Click;

            clr.Content = "click to clear";
            clr.Click += Clr_Click;

            viewer.ZoomMode = ZoomMode.Enabled;
           
        }

        private void Clr_Click(object sender, RoutedEventArgs e)
        {
            count = 1;
            viewer.ChangeView(350, 350, count);
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            viewer.ChangeView(350, 350, count);
            count += 1;
        }
    }
}
