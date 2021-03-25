using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace IntroToXamarin
{
    public partial class PageC : ContentPage
    {

        private const string blackStyle = "blackText";
        private const string redStyle = "redText";
        private string currentStyleName = "";

        public PageC()
        {
            InitializeComponent();
            Resources["labelStyle"] = Resources[blackStyle];
            currentStyleName = blackStyle;
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            SetCurrentStyle(currentStyleName == blackStyle ? redStyle : blackStyle);
        }

        void SetCurrentStyle(string styleName)
        {
            currentStyleName = styleName;
            Resources["labelStyle"] = Resources[styleName];
        }
    }
}
