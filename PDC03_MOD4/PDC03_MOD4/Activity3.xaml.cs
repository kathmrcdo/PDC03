using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;


namespace PDC03_MOD4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activity3 : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employees; } }
        public Activity3()
        {
            InitializeComponent();

            EmployeeView.ItemsSource = employees;

            employees.Add(new Employee { DisplayName = "Kathrine Mercado", Position = "President", Image = "img1.jpg" });
            employees.Add(new Employee { DisplayName = "Mikaella Silva", Position = "Vice President", Image = "img2.jpg" });
            employees.Add(new Employee { DisplayName = "Xzyra Lapid", Position = "Secretary", Image = "img3.jpg" });
            employees.Add(new Employee { DisplayName = "Stephanie Lopez", Position = "Director", Image = "img4.jpg" });
            employees.Add(new Employee { DisplayName = "Trixie Sison", Position = "Supervisor", Image = "img5.jpg" });


        }
    }
}