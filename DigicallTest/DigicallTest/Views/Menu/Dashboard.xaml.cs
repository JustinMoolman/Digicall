using DigicallTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DigicallTest.Views.DetailViews;
using DigicallTest.LocalDatabase;

namespace DigicallTest.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dashboard : ContentPage
    {
        public Dashboard()
        {
            InitializeComponent();
            Init();
        }

         void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            App.StartCheckIfInternet(lblNoInternet, this);
        }

        async void SelectedEmployees(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new InfoScreen1());
            await Navigation.PushAsync(new EmployeeListPage());
        }
    }
}