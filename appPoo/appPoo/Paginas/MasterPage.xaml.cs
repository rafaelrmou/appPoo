using appPoo.Implementacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace appPoo.Paginas
{
    public partial class MasterPage : TabbedPage
    {
        public MasterPage()
        {
            InitializeComponent();
            btnEQP.BackgroundColor = Color.Green;
            btnEQP.BorderRadius = 0;
            btnEQP.BorderWidth = 0;
            btnEQP.FontSize = 20;
            
            
        }

        void OnButtonClicked_eqp(object sender, EventArgs e)
        {
            var x = new FuncaoPrimeiroGrau(double.Parse(apX.Text), double.Parse(bp.Text), double.Parse(equalitep.Text));
            DisplayAlert("Resultado",x.resolver(), "OK");
        }

        void OnButtonClicked_eqs(object sender, EventArgs e)
        {

            var x = new FuncaoSegundoGrau(double.Parse(asX.Text),double.Parse(bsY.Text),double.Parse(cs.Text), double.Parse(equalites.Text));

            DisplayAlert("Resultado", x.resolver(), "OK");
        }
    }
}
