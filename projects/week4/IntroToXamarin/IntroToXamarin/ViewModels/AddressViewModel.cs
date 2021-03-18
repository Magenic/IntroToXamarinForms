using System;

namespace IntroToXamarin.ViewModels
{
    public class AddressViewModel : BaseViewModel
    {
        public AddressViewModel()
        {
        }

        private string address1 = "";
        public string Address1
        {
            get
            {
                return address1;
            }
            set
            {
                if (address1 != value)
                {
                    address1 = value;
                    OnPropertyChanged(nameof(Address1));
                }
            }
        }

        private string address2 = "";
        public string Address2
        {
            get
            {
                return address2;
            }
            set
            {
                if (address2 != value)
                {
                    address2 = value;
                    OnPropertyChanged(nameof(Address2));
                }
            }
        }

        private string city = "";
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                if (city != value)
                {
                    city = value;
                    OnPropertyChanged(nameof(City));
                }
            }
        }

        private string state = "";
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                if (state != value)
                {
                    state = value;
                    OnPropertyChanged(nameof(State));
                }
            }
        }

        private string postalCode = "";
        public string PostalCode
        {
            get
            {
                return postalCode;
            }
            set
            {
                if (postalCode != value)
                {
                    postalCode = value;
                    OnPropertyChanged(nameof(PostalCode));
                }
            }
        }
    }
}
