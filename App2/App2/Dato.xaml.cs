using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Dato : ContentPage
	{
        IList<Diagnostico> diagnosti = new ObservableCollection<Diagnostico>();
        int id = 0;
        public Dato ()
		{
            Title = "Diagnosticos";
            BindingContext = diagnosti;
			InitializeComponent ();
		}

        private void Agregar_Clicked(object sender, EventArgs e)
        {
            Diagnostico c = new Diagnostico();
            c.Diagnosticos = Diag.Text;
            diagnosti.Add(c);
            id++;

        }

        async private void ListaD_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) { return; }
            Diagnostico data = e.SelectedItem as Diagnostico;
            Edicion edicion = new Edicion();
            edicion.BindingContext = data;
            ((ListView)sender).SelectedItem = null;
            await Navigation.PushAsync(edicion);
           
        }
    }
}