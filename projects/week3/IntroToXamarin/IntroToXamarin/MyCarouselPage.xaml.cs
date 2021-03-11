using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace IntroToXamarin
{
    public partial class MyCarouselPage : ContentPage
    {
        public MyCarouselPage()
        {
            InitializeComponent();

            var items = new Collection<Model>();
            var model1 = new Model("First");
            var model2 = new Model("Second");
            var model3 = new Model("Third");

            items.Add(model1);
            items.Add(model2);
            items.Add(model3);

            this.theCarousel.ItemsSource = items;

            
        }
    }

    public class Model
    {
        public Model(string title)
        {
            this.Title = title;
        }

        public string Title { get; set; }
    }

}
