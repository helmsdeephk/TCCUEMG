using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TCCFINAL.MenuMaster
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuMaster : MasterDetailPage
	{
		public MenuMaster ()
		{
			InitializeComponent ();
		}

        private void GoToMainPage(object sender, EventArgs args)
        {
            Detail = new Paginas.MainPage();
        }
        private void GoToPagina1(object sender, EventArgs args)
        {
            Detail = new Paginas.Pagina1();
        }
        private void GoToPagina2(object sender, EventArgs args)
        {
            Detail = new Paginas.Pagina2();
        }
        private void GoToPagina3(object sender, EventArgs args)
        {
            Detail = new Paginas.Pagina3();
        }

    }
}