using appPoo.Paginas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace appPoo.Helpers
{
    public class MenuListData : List<MenuItem>
    {
        public MenuListData()
        {
            this.Add(new MenuItem()
            {
                Title = "Master Page",
                //IconSource = "drawable/home.png",
                TargetType = typeof(MasterPage)
            });

          
        }
    }
}
