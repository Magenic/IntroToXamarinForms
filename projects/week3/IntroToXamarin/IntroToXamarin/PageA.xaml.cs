using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace IntroToXamarin
{
    public partial class PageA : ContentPage
    {
        public PageA()
        {
            InitializeComponent();
        }

        async void PageB_Clicked(System.Object sender, System.EventArgs e)
        {
            await this.Navigation.PushAsync(new PageB());
        }
    }
}
