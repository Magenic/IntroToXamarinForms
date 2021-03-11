using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace IntroToXamarin
{
    public partial class PageC : ContentPage
    {
        public PageC()
        {
            InitializeComponent();
        }

        async void Modal_Complete(System.Object sender, System.EventArgs e)
        {
            await this.Navigation.PopModalAsync(true);
        }
    }
}
