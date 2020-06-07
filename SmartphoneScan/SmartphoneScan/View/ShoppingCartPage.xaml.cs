using SmartphoneScan.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartphoneScan.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ShoppingCartPage : ContentPage
	{
        private readonly ShoppingCartPageViewModel viewModel;

        public ShoppingCartPage ()
		{
			InitializeComponent ();
        }
	}
}