using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace froldanS2T1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnInciar_Clicked(object sender, EventArgs e)
        {
            string user = txtuser.Text;
            string pass = txtpass.Text;
            if (user == "estudiante2023" && pass == "uisrael2023")
            {
                Navigation.PushAsync(new Notas());
            }
            else
            {
                DisplayAlert("ALERTA", "Usuario/Contraseña Incorrectos", "Cerrar");
                txtuser.Text = "";
                txtpass.Text = "";
            }
        }

        private void btnRegistrar_Clicked(object sender, EventArgs e)
        {

        }
    }
}