using System;
using System.ComponentModel;

namespace IntroXamarin
{
    public class MyViewModel: INotifyPropertyChanged
    {
        public MyViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private string _myProperty = "starting value";

        public string MyProperty
        {
            get { return _myProperty;  }
            set
            {
                _myProperty = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MyProperty)));
            }
        }
    }
}
