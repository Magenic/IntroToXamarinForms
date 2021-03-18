using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace IntroToXamarin.ViewModels
{
    public class ViewModelB : BaseViewModel
    {
        public ViewModelB()
        {
        }

        private string foo = "";

        public string Foo
        {
            get
            {
                return foo;
            }
            set
            {
                if (foo != value)
                {
                    foo = value;
                    OnPropertyChanged(nameof(Foo));
                }
            }
        }

        private ICommand submit = null;
        public ICommand Submit
        {
            get
            {
                if (submit == null)
                {
                    submit = new Command<string>((string fooValue) =>
                    {
                        Console.WriteLine(fooValue);
                    });
                }
                return submit;
            }
        }
    }
}