using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Testsubscribecallback.Services;

namespace Testsubscribecallback.ViewModels
{
    public class InfoHostViewModel:BaseViewModel
    {
        string streetEntry;
        string currentStreet;

        public InfoHostViewModel()
        {
            MessagingCenter.Subscribe<InfoViewModel, ActiveFilter>(this, "sendFilters", (sender, aFilter) =>
            {
                Console.WriteLine($"Adding Filters\n{aFilter.GetHashCode()}");
                aFilter.AddFilter(currentStreet);
            });
        }

        public string CurrentStreet
        {
            get { return currentStreet; }
            set
            {
                if (currentStreet != value)
                {
                    currentStreet = value;
                    OnPropertyChanged();
                }
            }
        }

        public string EntryText
        {
            get { return streetEntry; }
            set
            {
                if (streetEntry != value)
                {
                    streetEntry = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand SubmitStreetCommand => new Command(SubmitStreet);

        private async void SubmitStreet()
        {
            CurrentStreet = streetEntry;
            await Task.FromResult(true);
        }
    }
}
