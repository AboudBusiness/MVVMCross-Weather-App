using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using WeatherPro.Core.Models;
using WeatherPro.Core.Services;
using Newtonsoft.Json.Linq;
using Plugin.Connectivity;
using System.Windows.Input;
using WeatherPro.Core.Interfaces;
using System.Threading.Tasks;

namespace WeatherPro.Core.ViewModel
{
    public class OpenWeatherMainViewModel : MvxViewModel
    {
        
        private readonly IOpenWeatherApi openWeatherApi;
        private readonly IMvxNavigationService navigationService;
        private readonly IDialogService dialogService;

        public OpenWeatherMainViewModel(
            IOpenWeatherApi openWeatherApi,
            IMvxNavigationService navigationService,
            IDialogService dialogService)
        {
            this.openWeatherApi = openWeatherApi;
            this.navigationService = navigationService;
            this.dialogService = dialogService;
        }

        private string place;
        public string Place
        {
            get => place;
            set
            {
                place = value;

                RaisePropertyChanged();
            }
        }

        private string temp;
        public string Temp
        {
            get => temp;
            set
            {
                temp = value;

                RaisePropertyChanged();
            }
        }

        private string cityName;
        public string CityName
        {
            get => cityName;
            set
            {
                cityName = value;

                RaisePropertyChanged();
            }
        }

        private string weatherDescription;
        public string WeatherDescription
        {
            get => weatherDescription;
            set
            {
                weatherDescription = value;

                RaisePropertyChanged();
            }
        }

        //Icon property...


        private MvxCommand fetchingDataCommand;
        public ICommand FetchingDataCommand
        {
            get
            {
                fetchingDataCommand = fetchingDataCommand ?? new MvxCommand(DoFetchingDataCommand);

                return fetchingDataCommand;
            }
        }

        public async void DoFetchingDataCommand()
        {
            if (string.IsNullOrEmpty(place))
            {
                dialogService.Alert("Please enter city name :)", "Error", "OK");
                return;
            }

            if (!CrossConnectivity.Current.IsConnected)
            {
                dialogService.Alert("No internet connection :(", "Error", "OK");
                return;
            }

            //Opening the dialog
            dialogService.Alert("Fetching Data..");
            /*await navigationService.Navigate<ProgressDialogFragmentViewModel>();*/

            var result = await openWeatherApi.GetWeatherInfoAsync(place, "aa22719e6df8c595254afbbd8f72778d");
            var resultObj = (JObject)result.Result;

            var weatherInfo = new WeatherInfo
            {
                Temp = resultObj["main"]["temp"].ToString(),
                WeatherDescription = resultObj["weather"][0]["description"].ToString(),
                CityName = resultObj["name"].ToString()
                //Icon property..
            };

            Temp = weatherInfo.Temp;
            WeatherDescription = weatherInfo.WeatherDescription;
            CityName = weatherInfo.CityName;

            //Closs the dialog..
            dialogService.Dispose();
        }
    }
}
