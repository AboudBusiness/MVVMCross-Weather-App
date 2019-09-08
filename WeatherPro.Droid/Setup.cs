using MvvmCross;
using MvvmCross.Platforms.Android.Core;
using WeatherPro.Core;
using WeatherPro.Core.Interfaces;
using WeatherPro.Droid.Services;

namespace WeatherPro.Droid
{
    public class Setup : MvxAndroidSetup<App>
    {
        protected override void InitializeFirstChance()
        {
            Mvx.IoCProvider.RegisterType<IDialogService, DialogService>();

            base.InitializeFirstChance();
        }
    }
}