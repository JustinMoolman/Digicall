using System;
using DigicallTest.Data;
using DigicallTest.Views;
using DigicallTest.Views.Menu;
using Xamarin.Forms;
using static CoreFoundation.DispatchSource;
using DigicallTest.LocalDatabase;

namespace DigicallTest
{
    public partial class App : Application
    {
        static UserDatabaseController userDatabase;
        static TokenDatabaseController tokenDatabase;
        static VehicleDatabaseController vehicleDatabase;
        static RestService restService;
        private static Label lblScreen;
        private static bool hasInternet;
        private static Page currentpage;
        private static Timer timer;
        private static bool noInterShow;

        ///------LocalDB------
        static EmployeeDatabase database;

        internal static void StartCheckIfInternet(Label lblNoInternet, ContentPage contentPage)
        {
            //throw new NotImplementedException();
        }

        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
        }
        public static EmployeeDatabase Database
        {
            get
            {
                if(database == null)
                {
                    database = new EmployeeDatabase(DependencyService.Get<ILocalFileHelper>().GetLocalFilePath("Employee.db3"));
                }
                return database;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        //User
        public static UserDatabaseController UserDatabase
        {
            get
            {
                if(userDatabase == null)
                {
                    userDatabase = new UserDatabaseController();
                }
                return userDatabase;
            }
        }
        //Token
        public static TokenDatabaseController TokenDatabase
        {
            get
            {
                if (tokenDatabase == null)
                {
                    tokenDatabase = new TokenDatabaseController();
                }
                return tokenDatabase;
            }
        }
        //Vehicle
        public static VehicleDatabaseController VehicleDatabase
        {
            get
            {
                if (vehicleDatabase == null)
                {
                    vehicleDatabase = new VehicleDatabaseController();
                }
                return vehicleDatabase;
            }
        }

        public static RestService RestService
        {
            get
            {
                if(restService == null)
                {
                    restService = new RestService();
                }
                return restService;
            }
        }

    }
}
