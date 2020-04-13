using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Testsubscribecallback.Services;
using Xamarin.Forms;

namespace Testsubscribecallback.ViewModels
{
    public class InfoViewModel: BaseViewModel
    {
        string street;

        public InfoViewModel()
        {
        }

        public ICommand UpdateViewCommand => new Command(RequestUpdate);

        private async void RequestUpdate()
        {

            ActiveFilter activeFilters = new ActiveFilter();
            MessagingCenter.Send(this, "sendFilters", activeFilters);//Send this instance of activefilters to be updated fromInfoHost
            Console.WriteLine($"Checking for filters\n{activeFilters.GetHashCode()}");
            var currentFilters = await activeFilters.Filters();
            Console.WriteLine(currentFilters.Count);
            foreach (string filter in currentFilters)
            {
                if (filter != null)
                {
                    StreetFromHost = filter;
                }
            }
        }

        public string StreetFromHost
        {
            get { return street; }
            set
            {
                if (value != street)
                {
                    street = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
