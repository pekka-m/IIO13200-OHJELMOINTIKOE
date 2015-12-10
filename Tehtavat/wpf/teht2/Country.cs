using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    public class Country : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string Continent { get; set; }
        public int Population { get; set; }
        public string LocalName { get; set; }
        public string HeadOfState { get; set; }
        public double SurfaceArea { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

    }
}
