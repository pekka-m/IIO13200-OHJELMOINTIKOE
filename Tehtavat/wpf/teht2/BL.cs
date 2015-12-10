using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;

namespace teht2
{
    public class BL
    {
        public void populateCollection(ObservableCollection<Country> collection)
        {
            collection.Clear();
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(Properties.Settings.Default.countries);
                XmlElement root = doc.DocumentElement;
                XmlNodeList nodes = root.SelectNodes("ROW");
                foreach (XmlNode node in nodes)
                {
                    Country c = new Country();
                    c.Name = node["Name"].InnerText;
                    c.Continent = node["Continent"].InnerText;
                    c.Population = int.Parse(node["Population"].InnerText);
                    c.LocalName = node["LocalName"].InnerText;
                    c.HeadOfState = node["HeadOfState"].InnerText;
                    c.SurfaceArea = double.Parse(node["SurfaceArea"].InnerText, CultureInfo.InvariantCulture);
                    collection.Add(c);
                }
            }
            catch (FileNotFoundException e)
            {
                MessageBoxResult result = MessageBox.Show("XML-tiedostoa " + Properties.Settings.Default.countries + " ei löytynyt!\n", "Confirmation", MessageBoxButton.OK, MessageBoxImage.Error);
                Application.Current.Shutdown();

            }
        }

        public int getCountriesCount(ObservableCollection<Country> collection)
        {
            return collection.Count();
        }

        public int getTotalPopulation(ObservableCollection<Country> collection)
        {
            int population = 0;
            foreach (Country c in collection)
            {
                population += c.Population;
            }
            return population;
        }

        public List<string> getContinents(ObservableCollection<Country> collection)
        {
            List<string> continents = new List<string>();
            continents.Add("Kaikki");
            foreach (var item in collection)
            {
                continents.Add(item.Continent);
            }
            continents = continents.Distinct().ToList();
            return continents;
        }

        public void filterByContinent(ObservableCollection<Country> collection, string continent)
        {
            this.populateCollection(collection);

            if (!continent.Equals("Kaikki"))
            {
                for (int i = collection.Count-1; i >= 0; i--)
                {
                    if (!collection[i].Continent.Equals(continent))
                    {
                        collection.RemoveAt(i);
                    }

                }
            }
        }

        public void getLargestCountriesByPopulation(ObservableCollection<Country> collection)
        {
            this.populateCollection(collection);
            List<int> pops = new List<int>();

            foreach (var item in collection)
            {
                pops.Add(item.Population);
            }

            pops = pops.OrderByDescending(i => i).ToList();

            for (int i = collection.Count - 1; i >= 0; i--)
            {
                if (collection[i].Population <= pops[10])
                {
                    collection.RemoveAt(i);
                }
            }
            
        }

        public void getLargestCountriesByArea(ObservableCollection<Country> collection)
        {
            this.populateCollection(collection);
            List<double> areas = new List<double>();

            foreach (var item in collection)
            {
                areas.Add(item.SurfaceArea);
            }

            areas = areas.OrderByDescending(i => i).ToList();

            for (int i = collection.Count - 1; i >= 0; i--)
            {
                if (collection[i].SurfaceArea <= areas[10])
                {
                    collection.RemoveAt(i);
                }
            }

        }

        public void searchCountries(ObservableCollection<Country> collection, string search)
        {
            this.populateCollection(collection);

            for (int i = collection.Count - 1; i >= 0; i--)
            {
                if (!collection[i].Name.ToLower().Contains(search.ToLower()))
                {
                    collection.RemoveAt(i);
                }
            }

        }
    }
}
