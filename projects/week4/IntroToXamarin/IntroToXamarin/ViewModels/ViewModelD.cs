using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace IntroToXamarin.ViewModels
{
    public class ViewModelD : BaseViewModel
    {
        public ViewModelD()
        {
        }

        private decimal usdAmount = 0;
        public decimal UsdAmount
        {
            get
            {
                return usdAmount;
            }
            set
            {
                if (usdAmount != value)
                {
                    usdAmount = value;
                    OnPropertyChanged(nameof(UsdAmount));
                    OnPropertyChanged(nameof(Invalid));
                }
            }
        }

        private string conversionCurrency = "Philippine Peso";
        public string ConversionCurrency
        {
            get
            {
                return conversionCurrency;
            }
            set
            {
                if (conversionCurrency != value)
                {
                    conversionCurrency = value;
                    OnPropertyChanged(nameof(ConversionCurrency));
                    OnPropertyChanged(nameof(UsdAmount));
                    OnPropertyChanged(nameof(Invalid));
                }
            }
        }

        public bool Invalid
        {
            get
            {
                return usdAmount == 0;
            }
        }

        private ICommand save = null;
        public ICommand Save
        {
            get
            {
                if (save == null)
                {
                    save = new Command(() =>
                    {
                        Console.WriteLine("Save Called");
                    });
                }
                return save;
            }
        }
    }
}
