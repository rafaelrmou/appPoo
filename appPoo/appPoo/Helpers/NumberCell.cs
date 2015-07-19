using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace appPoo.Helpers
{
    public class NumberCell : EntryCell
    {
        public double GetNumber()
        {
            if (string.IsNullOrEmpty(this.Text))
                return 0;

            return double.Parse(this.Text);
        }
    }

}
