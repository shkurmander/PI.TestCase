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

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace PI.TestCase.UserInterface
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class CalcPage : Page
    {

        public Valute ValuteRecord { get; set; }

        public CalcPage()
        {
            this.InitializeComponent();
        }               

        private void TextBlockCharCode1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(ValutesList));
        }

        private void TextBlockCharCode2_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(ValutesList));
        }

        private void TextBlockChange1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(ValutesList));
        }

        private void TextBlockChange2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(ValutesList));
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            ValuteRecord = e.Parameter as Valute;
            //TextBlockCharCode1.Text = ValuteRecord.CharCode;
            //TextBlockCharCode1.Text = ValuteRecord.CharCode;
        }
    }
}
