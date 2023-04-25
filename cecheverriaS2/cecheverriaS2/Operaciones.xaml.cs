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
    public partial class Operaciones : ContentPage
    {
        public Operaciones()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            //variable double
            double NotaSeguimiento1 = Convert.ToDouble(txtNotaSeguimiento1.Text);
            double NotaExamen1 = Convert.ToDouble(txtNotaExamen1.Text);
            double NotaSeguimiento2 = Convert.ToDouble(txtNotaSeguimiento2.Text);
            double NotaExamen2 = Convert.ToDouble(txtNotaExamen2.Text);
            if ((NotaSeguimiento1>=0 && NotaSeguimiento1<=10) && (NotaSeguimiento2 >= 0 && NotaSeguimiento2 <= 10))
            {
                double resultado1 = (NotaSeguimiento1 * 0.6) + (NotaExamen1 * 0.4);
                txtResultado1.Text = resultado1.ToString();
                double resultado2 = (NotaSeguimiento2 * 0.6) + (NotaExamen2 * 0.4);
                txtResultado2.Text = resultado2.ToString();
                double NotaFinal = (NotaSeguimiento1 + NotaSeguimiento2) / 2;
                txtNotaFinal.Text = NotaFinal.ToString();
                if (NotaFinal >= 7)
                {
                    string estado = "Aprobado";
                    txtEstado.Text = estado;
                }
                else
                {
                    string estado = "Examen Complementario";
                    txtEstado.Text = estado;
                }
            }
            else 
            {
                DisplayAlert("Error", "El valor ingresado es incorrecto, favor ingresar valores dentro del rango permitido [0 - 10]", "Cerrar");
                txtNotaSeguimiento1.Text = "";
                txtNotaExamen2.Text = "";
                txtNotaSeguimiento1.Text = "";
                txtNotaExamen1.Text = "";
            }
        }

        private void btnLimpiar_Clicked(object sender, EventArgs e)
        {
            txtNotaSeguimiento1.Text = "";
            txtNotaSeguimiento2.Text = "";
            txtResultado1.Text = "";
            txtResultado2.Text = "";
            txtNotaExamen1.Text = "";
            txtNotaExamen2.Text = "";
            txtEstado.Text = "";
            txtNotaFinal.Text = "";
        }

        private void btnCerrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());
            
        }
    }
}