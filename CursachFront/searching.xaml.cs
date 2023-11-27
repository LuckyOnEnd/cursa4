using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CursachFront.Core;
using CursachFront.Core.Models;
using CursachFront.Core.Models.FilterUsers;
using CursachFront.Core.Services.Prisoners;

namespace CursachFront
{
    /// <summary>
    /// Логика взаимодействия для searching.xaml
    /// </summary>
    public partial class searching : Page
    {
        private PrisonerService _prisonerService;
        private SearchFilter SearchFilter = new();
        public IEnumerable<Prisoner> prisoners { get; private set; } = Enumerable.Empty<Prisoner>();
        public searching()
        {
            _prisonerService = new PrisonerService();
            InitializeComponent();

            CursachConfiguration cursachConfiguration = new(); //TODO чекни это
            cursachConfiguration = CursachConfiguration.LoadFromFile("cursach.json");
            LocalDb.Prisoners = cursachConfiguration.Prisoners;
            
            prisoners = _prisonerService.GetFilteredAsync(new());
            // List<Person> people = LocalDb.Prisoners.Select(prp => new Person()
            // {
            //     FirstName = prp.Name
            // }).ToList();

            // Устанавливаем этот список в качестве источника данных для ListView
            dataListView.ItemsSource = people;
        }
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string ImagePath { get; set; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchFilter.Surname = SearchingParametrSecondName.Text;
            FilterPrisoner();
        }
        
        public void FilterPrisoner()
        {
            prisoners = _prisonerService.GetFilteredAsync(SearchFilter);
        }
        
        // Создаем список людей для отображения в ListView
        List<Person> people = new List<Person>
{
    new Person { FirstName = "John", LastName = "Doe", ImagePath = "path/to/image1.jpg" },
    new Person { FirstName = "Alice", LastName = "Smith", ImagePath = "path/to/7.jpg" },
    // Добавляем другие объекты Person
};

        
        
    }

}
