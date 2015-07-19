using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace appPoo.Helpers
{
    public class MenuItem : Cell
    {
        public string Title { get; set; }

        public string IconSource { get; set; }

        public Type TargetType { get; set; }


    }
}
