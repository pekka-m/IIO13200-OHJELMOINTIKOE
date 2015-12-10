using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Xml;
using System.Xml.Linq;

namespace teht2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BL bl;
        private ObservableCollection<Country> countries;
        
        public MainWindow()
        {
            InitializeComponent();
            countries = new ObservableCollection<Country>();
            bl = new BL();
            bl.populateCollection(countries);
            CountriesDG.ItemsSource = countries;
            textBlock_countriesCount.Text = bl.getCountriesCount(countries).ToString();
            textBlock_population.Text = bl.getTotalPopulation(countries).ToString();
            comboBox_continents.ItemsSource = bl.getContinents(countries);
        }

        private void comboBox_continents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            bl.filterByContinent(countries, comboBox_continents.SelectedItem.ToString());
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            bl.getLargestCountriesByPopulation(countries);
        }

        private void button_areas_Click(object sender, RoutedEventArgs e)
        {
            bl.getLargestCountriesByArea(countries);
        }

        private void button_search_Click(object sender, RoutedEventArgs e)
        {
            bl.searchCountries(countries, textBox_search.Text);
        }
    }
}
