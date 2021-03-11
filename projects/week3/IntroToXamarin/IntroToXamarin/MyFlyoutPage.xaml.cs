using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace IntroToXamarin
{
    public partial class MyFlyoutPage : FlyoutPage
    {
        public MyFlyoutPage()
        {
            InitializeComponent();

            flyoutPage.listView.ItemSelected += OnItemSelected;
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as FlyoutPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                flyoutPage.listView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
