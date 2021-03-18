using System;
using System.Globalization;
using IntroToXamarin.ViewModels;
using Xamarin.Forms;

namespace IntroToXamarin.ValueConverters
{
    public class CurrencyConverter : BindableObject, IValueConverter
    {

        public static BindableProperty CurrencyProperty = BindableProperty.Create("Currency", typeof(string), typeof(CurrencyConverter), defaultValue: "");

        public string Currency
        {
            get => (string)GetValue(CurrencyProperty);
            set => SetValue(CurrencyProperty, value);
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            var returnValue = 0.0m;
            if (value == null || value.ToString() == "") value = "0";
            var usdAmount = decimal.Parse(value.ToString());

            if (!string.IsNullOrEmpty(Currency))
            {
                switch (Currency)
                {
                    case "Euro":
                        returnValue = usdAmount * 0.84m;
                        break;
                    case "Canadian Dollar":
                        returnValue = usdAmount * 1.24m;
                        break;
                    case "Philippine Peso":
                        returnValue = usdAmount * 48.69m;
                        break;
                }
            }

            return decimal.Round(returnValue, 2);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var returnValue = 0.0m;
            if (value == null || value.ToString() == "") value = "0";
            var convAmount = decimal.Parse(value.ToString());

            if (!string.IsNullOrEmpty(Currency))
            {
                switch (Currency)
                {
                    case "Euro":
                        returnValue = convAmount / 0.84m;
                        break;
                    case "Canadian Dollar":
                        returnValue = convAmount / 1.24m;
                        break;
                    case "Philippine Peso":
                        returnValue = convAmount / 48.69m;
                        break;
                }
            }

            return decimal.Round(returnValue, 2);
        }
    }
}
