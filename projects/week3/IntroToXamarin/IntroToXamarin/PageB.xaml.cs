using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace IntroToXamarin
{
    public partial class PageB : ContentPage
    {
        public PageB()
        {
            InitializeComponent();

            this.Title = "Page B";
        }

        async void Modal_Nav(System.Object sender, System.EventArgs e)
        {
            await this.Navigation.PushModalAsync(new PageC(), true);
        }
    }
}
