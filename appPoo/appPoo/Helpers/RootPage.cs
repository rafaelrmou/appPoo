using appPoo.Paginas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace appPoo.Helpers
{
    public class RootPage : MasterDetailPage
    {
        public RootPage()
        {
            var menuPage = new MenuPage();

            menuPage.Menu.ItemSelected += (sender, e) => NavigateTo(e.SelectedItem as Helpers.MenuItem, sender as ListView);


            Master = menuPage;
            Detail = new NavigationPage(new MasterPage());

        }

        public void Reload()
        {
            var menuPage = new MenuPage();

            menuPage.Menu.ItemSelected += (sender, e) => NavigateTo(e.SelectedItem as Helpers.MenuItem, sender as ListView);


            Master = menuPage;
            Detail = new NavigationPage(new MasterPage());
        }

        void NavigateTo(Helpers.MenuItem menu, ListView sender)
        {
            Page displayPage = (Page)Activator.CreateInstance(menu.TargetType);

            Detail = new NavigationPage(displayPage);

            IsPresented = false;

            //var x = sender.Cell
            //    x.Back


        }
    }
}
