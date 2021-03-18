using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace IntroToXamarin
{
    public partial class PageA : ContentPage
    {

        public PageA()
        {
            InitializeComponent();

            this.BindingContext = this;
        }

        private string foo = "Bar";

        public string Foo {
            get
            {
                return foo;
            }
            set
            {
                foo = value;
                this.OnPropertyChanged(nameof(Foo));
            }
        }
    }
}
