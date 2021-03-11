using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntroToXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navPage = new NavigationPage(new MyCarouselPage());
            navPage.BarTextColor = Color.DeepPink;

            MainPage = new TabbedPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
