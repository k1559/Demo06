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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace teht02
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

        private void eurotmarkatbutton_Click(object sender, RoutedEventArgs e)
        {
            double markat;
            double value = double.Parse(eurotextBox.Text);
            markat = value * 5.95; 
            eurotmarkattextBlock.Text = markat.ToString("0.00");
        }

        private void markateurotbutton_Click(object sender, RoutedEventArgs e)
        {
            double eurot;
            double value = double.Parse(markkatextBox.Text);
            eurot = value * 0.17;
            markateurottextBlock.Text = eurot.ToString("0.00");
        }
    }
}
