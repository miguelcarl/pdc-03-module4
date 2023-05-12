using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MODULE04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity05 : ContentPage
    {
        List<Contacts> contacts;
        public activity05()
        {
            InitializeComponent();

            SetupData();
            listView.ItemsSource = contacts;
        
        }
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(listView.SelectedItem != null) 
            {
                var detailPage = new DetailPage();
                detailPage.BindingContext = listView.SelectedItem as Contacts;
                listView.SelectedItem = null;
                await Navigation.PushAsync(detailPage);
            }
        }

        void SetupData()
        {
            contacts = new List<Contacts>();

            contacts.Add(new Contacts
            {
                Name = "Siboo Yas",
                Age = 25,
                Occupation = "Tester",
                Country = "Philippines"
            });
            contacts.Add(new Contacts
            {
                Name = "Khang Kong",
                Age = 31,
                Occupation = "Developer",
                Country = "Taiwan"
            });
            contacts.Add(new Contacts
            {
                Name = "Lue Ya",
                Age = 28,
                Occupation = "Engineer",
                Country = "Singapore"
            });
            contacts.Add(new Contacts
            {
                Name = "Patah Tas",
                Age = 22,
                Occupation = "Architect",
                Country = "Hong Kong"
            });
            contacts.Add(new Contacts
            {
                Name = "Bah Wang",
                Age = 35,
                Occupation = "Doctor",
                Country = "Japan"
            });

        }

    }
}
