using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cecheverriaS2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
            if (usuario == "estudiante2023" && contrasena == "uisrael2023")
            {
                Navigation.PushAsync(new Operaciones());
                txtUsuario.Text = "";
                txtContrasena.Text = "";
            }
            else
            {
                DisplayAlert("Alerta", "Usuario/Contrasena incorrectos", "Cerrar");
                txtUsuario.Text = "";
                txtContrasena.Text = "";
            }
        }

        private void btnLimpioar_Clicked(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }
    }
}