using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace IntroToXamarin.Views
{
    public partial class AddressView : ContentView
    {

        public static BindableProperty Address1Property = BindableProperty.Create(nameof(Address1), typeof(string), typeof(AddressView), defaultValue: "", defaultBindingMode: BindingMode.TwoWay);

        public string Address1
        {
            get => (string)GetValue(Address1Property);
            set => SetValue(Address1Property, value);
        }

        public static BindableProperty Address2Property = BindableProperty.Create(nameof(Address2), typeof(string), typeof(AddressView), defaultValue: "", defaultBindingMode: BindingMode.TwoWay);

        public string Address2
        {
            get => (string)GetValue(Address2Property);
            set => SetValue(Address2Property, value);
        }

        public static BindableProperty CityProperty = BindableProperty.Create(nameof(City), typeof(string), typeof(AddressView), defaultValue: "", defaultBindingMode: BindingMode.TwoWay);

        public string City
        {
            get => (string)GetValue(CityProperty);
            set => SetValue(CityProperty, value);
        }

        public static BindableProperty StateProperty = BindableProperty.Create(nameof(State), typeof(string), typeof(AddressView), defaultValue: "", defaultBindingMode: BindingMode.TwoWay);

        public string State
        {
            get => (string)GetValue(StateProperty);
            set => SetValue(StateProperty, value);
        }

        public static BindableProperty PostalCodeProperty = BindableProperty.Create(nameof(PostalCode), typeof(string), typeof(AddressView), defaultValue: "", defaultBindingMode: BindingMode.TwoWay);

        public string PostalCode
        {
            get => (string)GetValue(PostalCodeProperty);
            set => SetValue(PostalCodeProperty, value);
        }

        public static BindableProperty AddressTitleProperty = BindableProperty.Create(nameof(AddressTitle), typeof(string), typeof(AddressView), defaultValue: "Address:", defaultBindingMode: BindingMode.OneWay);

        public string AddressTitle
        {
            get => (string)GetValue(AddressTitleProperty);
            set => SetValue(AddressTitleProperty, value);
        }

        public AddressView()
        {
            InitializeComponent();

            this.Content.BindingContext = this;
        }
    }
}
