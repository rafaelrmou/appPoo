using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace appPoo.Helpers
{
    public class MenuPage : ContentPage
    {
        public ListView Menu { get; set; }
        public MenuPage()
        {
            Icon = "drawable/icon.png";
            Title = "Menu";

            Menu = new MenuListView();

            //var menuLabel = new ContentView
            //{
            //    Padding = new Thickness(10, 160, 0, 5),
            //    Content = new Label
            //    {
            //        TextColor = Color.FromHex("AAAAAA"),
            //        Text = "MENU",
            //    }
            //};

            var layout = new StackLayout
            {
                Spacing = 0,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            //layout.Children.Add(menuLabel);
            layout.Children.Add(Menu);

            Content = layout;
        }
    }
}
