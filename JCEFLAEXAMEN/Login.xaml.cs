using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JCEFLAEXAMEN
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnAbrir_Clicked(object sender, EventArgs e)
        {


            string usuario = txtNombre.Text;
            string password = txtPass.Text;

            if (usuario == "estudiante2023" && password == "uisrael2023")
            {
                Navigation.PushAsync(new Registro(usuario, password));

            }
            else
            {

                DisplayAlert("ALERT", "Usuario/Contraseña incorrectos", "cerrar");
                txtNombre.Text = "";
                txtPass.Text = "";
            }
        }


    }
}
