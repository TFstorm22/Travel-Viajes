using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Auth;
using Firebase.Auth.Providers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hotel3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        FirebaseAuthClient FireClient { get; set; }
        public Login()
        {
            InitializeComponent();
            FireClient = new FirebaseAuthClient(new FirebaseAuthConfig
            {
                ApiKey = "AIzaSyCjCmomW1MkC3bsJSJCIwcPhpTUscEFZGw",
                AuthDomain = "loginxamarin-104e3.firebaseapp.com",
                Providers = new FirebaseAuthProvider[]
                    {
                        // Add and configure individual providers
                        new EmailProvider()
                    }
            });
        }

        async private void LoginClicked(object sender, EventArgs e)
        {
            try
            {
                var auth = await FireClient.SignInWithEmailAndPasswordAsync(txtUsername.Text, txtPassword.Text);
                await Navigation.PushAsync(new CiudadesPagina());
            }
            catch
            {
                await App.Current.MainPage.DisplayAlert("Alert", "No se pudo ingresar!!!", "Ok");
            }
        }
        async private void RegisterClicked(object sender, EventArgs e)
        {
            try
            {
                var auth = await FireClient.CreateUserWithEmailAndPasswordAsync(txtUsername.Text, txtPassword.Text);
                await App.Current.MainPage.DisplayAlert("Alert", "Registrado con exito!!!", "Ok");
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
            catch
            {
                await App.Current.MainPage.DisplayAlert("Alert", "No se pudo registar!!!", "Ok");
            }
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }
    }
}