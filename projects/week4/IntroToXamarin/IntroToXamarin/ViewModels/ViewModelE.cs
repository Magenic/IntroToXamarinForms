using System;
namespace IntroToXamarin.ViewModels
{
    public class ViewModelE : BaseViewModel
    {
        public ViewModelE()
        {
        }

        private string contactName = "";
        public string ContactName
        {
            get
            {
                return contactName;
            }
            set
            {
                if (contactName != value)
                {
                    contactName = value;
                    OnPropertyChanged(nameof(ContactName));
                }
            }
        }

        private AddressViewModel contactAddress = new AddressViewModel();
        public AddressViewModel ContactAddress
        {
            get
            {
                return contactAddress;
            }
            set
            {
                if (contactAddress != value)
                {
                    contactAddress = value;
                    OnPropertyChanged(nameof(ContactAddress));
                }
            }
        }
    }
}
