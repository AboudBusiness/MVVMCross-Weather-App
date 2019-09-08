using MvvmCross;
using MvvmCross.ViewModels;
using WeatherPro.Core.ViewModel;
using WeatherPro.Core.Services;

namespace WeatherPro.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterType<IOpenWeatherApi, OpenWeatherApi>();

            RegisterAppStart<OpenWeatherMainViewModel>();
        }
    }
}
