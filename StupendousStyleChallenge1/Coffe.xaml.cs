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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace StupendousStyleChallenge1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Coffe : Page
    {
        public Coffe()
        {
            this.InitializeComponent();
        }

        private string _roast;
        private string _sweetener;
        private string _cream;

        private void Roast_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            _roast = selected.Text;
            displayText();
        }

        private void SweetenerButton_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            _sweetener = selected.Text;
            displayText();
        }

        private void CreamButton_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            _cream = selected.Text;
            displayText();
        }
        private void displayText()
        {
            if(_roast == "None" || string.IsNullOrEmpty(_roast))
            {
                ResultsTextBlock.Text = _roast +" +" + _sweetener +"+" + _cream;

            }
            if(_sweetener != null && !string.IsNullOrEmpty(_cream))
            {
                ResultsTextBlock.Text += "+"+ _sweetener;
            }
        }
    }
}
