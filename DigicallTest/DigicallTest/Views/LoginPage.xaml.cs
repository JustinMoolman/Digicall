using DigicallTest.Models;
using DigicallTest.Views.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DigicallTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            lblUsername.TextColor = Constants.MainTextColor;
            lblPassword.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
            imgLoginIcon.HeightRequest = Constants.LoginIconHeight;
            App.StartCheckIfInternet(lblNoInternet, this);

            entUsername.Completed += (s, e) => entPassword.Focus();
            entPassword.Completed += (s, e) => SignInProcedure(s, e);
        }

        async void SignInProcedure(object sender, EventArgs e)
        {
            User user = new User(entUsername.Text, entPassword.Text);
            if (user.CheckInformation())
            {
                DisplayAlert("Login", "Login Successful.", "OK");
                ///API call is not going to an actual server (app will crash)
                //var result = await App.RestService.Login(user);
                
                //--------DUMMY TOKEN--------
                var result = new Token();
                ///API call is not going to an actual server (app will crash)
                //if (result.access_token != null)
                if (result != null)
                {
                    ///DUMMY LOGIN DATA
                    //App.UserDatabase.SaveUser(user);
                    //App.TokenDatabase.SaveToken(result);
                    if(Device.OS == TargetPlatform.Android)
                    {
                        Application.Current.MainPage = new NavigationPage(new Dashboard());
                    }
                    else if(Device.OS == TargetPlatform.iOS)
                    {
                        await Navigation.PushModalAsync(new NavigationPage(new Dashboard()));
                    }
                }
            }
            else
            {
                DisplayAlert("Login", "Invalid Login, empty Username or Password.", "OK");
            }
        }
    }
}