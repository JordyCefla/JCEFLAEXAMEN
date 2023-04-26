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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombre1, string total1)
        {
            InitializeComponent();
            
            txtUser.Text = usuario;
            txtNombre2.Text = nombre1;
            txtTotal.Text = total1;

        }
    }
}