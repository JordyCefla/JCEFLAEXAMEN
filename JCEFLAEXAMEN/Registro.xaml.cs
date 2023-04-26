using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Xamarin.Forms.Internals.Profile;

namespace JCEFLAEXAMEN
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string usuario, string password )
        {
            InitializeComponent();
            txtUser.Text = usuario;


        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {

            string nombre = txtNombre1.Text;
            string usuario1 = txtUser.Text;
            string total1 =txtTotal.Text;

            

            DisplayAlert("Mensaje", "Elemento guardado con éxito", "Cerrar");

            Navigation.PushAsync(new Resumen(usuario1, nombre, total1));





        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Clicked_1(object sender, EventArgs e)
        {

        }

        private void btnCalcular2_Clicked(object sender, EventArgs e)
        {

        }

        private void btnCalcul_Clicked(object sender, EventArgs e)
        {
                        
            try
            {
                double Monto = Convert.ToDouble(txtMonto.Text);


                if (!txtNombre1.Text.ToCharArray().All(char.IsLetter))
                {
                    DisplayAlert("Mensaje", "El Campo |Nombre| solo acepta letras", "Cerrar");
                    txtNombre1.Text = "";
                }

                if (Monto < 1 || Monto > 2999  )
                {

                    DisplayAlert("Mensaje", "El Rango es Incorrecto", "Cerrar");
                    txtMonto.Text = "";
                }
                else
                {
                    Monto = Convert.ToDouble(txtMonto.Text);

                    double M3 = 3000 * 0.05;
                      
                    double M2 = 3000 - Monto ;

                    double M4 = (M2 / 3) + M3 ;

                    double Total = (M4 * 3) + Monto;

                    txtMensual.Text = M4.ToString("0.00");
                    txtTotal.Text = Total.ToString("0.00");

                }
            }
            catch (Exception ex)
            {

                DisplayAlert("ERROR", ex.Message, "Cerrar");

            }

        }
    }
}