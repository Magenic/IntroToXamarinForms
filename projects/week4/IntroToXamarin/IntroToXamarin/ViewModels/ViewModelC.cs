using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace IntroToXamarin.ViewModels
{
    public class ViewModelC : BaseViewModel
    {
        public ViewModelC()
        {
            Items = new ObservableCollection<ModelC>();
            this.Add.Execute(null);
            this.Add.Execute(null);
        }

        public ObservableCollection<ModelC> Items { get; private set; }

        private ICommand delete = null;
        public ICommand Delete
        {
            get
            {
                if (delete == null)
                {
                    delete = new Command<ModelC>((ModelC item) =>
                    {
                        if (item != null)
                        {
                            Items.Remove(item);
                        }
                    });
                }
                return delete;
            }
        }

        private ICommand add = null;
        public ICommand Add
        {
            get
            {
                if (add == null)
                {
                    add = new Command(() =>
                    {
                        int maxItem = Items.Count > 0 ? Items.Max(i => i.Id) : 0;
                        int newItemId = maxItem + 1;
                        Items.Add(new ModelC { Id = newItemId, Title = $"Item{newItemId}" });
                    });
                }
                return add;
            }
        }
    }

    public class ModelC
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
