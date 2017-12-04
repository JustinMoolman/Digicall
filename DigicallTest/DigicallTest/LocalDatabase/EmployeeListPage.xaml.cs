using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DigicallTest.LocalDatabase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmployeeListPage : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

        public EmployeeListPage()
        {
            InitializeComponent();
            CreateDummyData();
            //Dummy data binding (observable collection not local db)
            EmployeeListView.ItemsSource = employees;

            this.Title = "Employee List";

            var toolbarItem = new ToolbarItem
            {
                Text = "+"
            };

            toolbarItem.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new EmployeePage() { BindingContext = new Employee() });
            };

            ToolbarItems.Add(toolbarItem);
        }

        private void CreateDummyData()
        {
            employees.Add(new Employee { EmpId = 1, EmpName = "Justin Moolman", Designation = "Mobile Developer", Age = 24 });
            employees.Add(new Employee { EmpId = 2, EmpName = "Jako Els", Designation = "The Boss", Age = 35 });
            employees.Add(new Employee { EmpId = 3, EmpName = "Chuck Norris", Designation = "The Muscle", Age = 9999999 });
            employees.Add(new Employee { EmpId = 4, EmpName = "Spiderman", Designation = "Why not", Age = 50 });
            employees.Add(new Employee { EmpId = 6, EmpName = "Drew Carry", Designation = "Blah", Age = 18 });
            employees.Add(new Employee { EmpId = 7, EmpName = "Barak Obama", Designation = "Blah", Age = 28 }); 
            employees.Add(new Employee { EmpId = 8, EmpName = "Koos de Beer", Designation = "Blah", Age = 34 });
            employees.Add(new Employee { EmpId = 9, EmpName = "Katy Perry", Designation = "Singer", Age = 36 });
            employees.Add(new Employee { EmpId = 10, EmpName = "John Doe", Designation = "Not around", Age = 92 });
            employees.Add(new Employee { EmpId = 14, EmpName = "Jane Doe", Designation = "Not around", Age = 19 });
            employees.Add(new Employee { EmpId = 15, EmpName = "Jacob Zuma", Designation = "Blah x2", Age = 1 });
            employees.Add(new Employee { EmpId = 16, EmpName = "Oscar Pestorious", Designation = "Bye", Age = 30 });
            employees.Add(new Employee { EmpId = 17, EmpName = "Gerrie Nel", Designation = "Bye", Age = 56 });
            employees.Add(new Employee { EmpId = 20, EmpName = "Me Lady", Designation = "Blah", Age = 89 });
        }

        //protected async override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    EmployeeListView.ItemsSource = await App.Database.GetEmployeesAsync();
        //}

        async void Employee_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem != null)
            {
                await Navigation.PushAsync(new EmployeePage() { BindingContext = e.SelectedItem as Employee });
            }
        }

    }
}