using System;
using Android.App;
using Android.OS;
using Android.Widget;
using MvvmCross.Platforms.Android.Views;
using WeatherPro.Core.ViewModel;

namespace WeatherPro.Droid.Views
{
    [Activity(Label ="Weather App")]//, MainLauncher = true)]
    public class OpenWeatherMainView : MvxActivity<OpenWeatherMainViewModel>
    {
        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
        {
            base.OnCreate(savedInstanceState, persistentState);

            SetContentView(Resource.Layout.OpenWeatherMain);

            /*var checkWeatherBtn = FindViewById<Button>(Resource.Id.getWeatherButton);
            checkWeatherBtn.Click += OnClick_CheckWeatherBtn;*/
        }

        /*private void OnClick_CheckWeatherBtn(object sender, EventArgs e)
        {
            var progressDialogFragmentView = new ProgressDialogFragmentView();
            var trans = FragmentManager.BeginTransaction();
            progressDialogFragmentView.Cancelable = false;
            progressDialogFragmentView.Show(trans, "progress");
        }*/
    }
}