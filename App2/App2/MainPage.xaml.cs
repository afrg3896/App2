using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
	public partial class MainPage : ContentPage
	{
        IList<Paciente> paciente = new ObservableCollection<Paciente>();
        int id = 0;

        public MainPage()
		{
            Title = "Pacientes";
            BindingContext = paciente;
			InitializeComponent();
          
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Paciente p = new Paciente();
            p.NombreC = Nombre.Text;
            p.Diagnostic = "";
            paciente.Add(p);
            id++;
        }

        async private void ListaP_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) { return; }
            Paciente dat = e.SelectedItem as Paciente;
            Dato dato = new Dato();
            dato.BindingContext = dat;
            ((ListView)sender).SelectedItem = null;
            await Navigation.PushAsync(dato);
        }
    }
}
