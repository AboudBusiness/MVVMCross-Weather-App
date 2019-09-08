using Android.App;
using Android.Widget;
using MvvmCross;
using MvvmCross.Platforms.Android;
using WeatherPro.Core.Interfaces;

namespace WeatherPro.Droid.Services
{
    public class DialogService : IDialogService
    {
        private AlertDialog.Builder dialog;

        public void Alert(string message)
        {
            var top = Mvx.IoCProvider.Resolve<IMvxAndroidCurrentTopActivity>();
            var act = top.Activity;

            var adb = new AlertDialog.Builder(act);
            adb.SetMessage(message);

            adb.Create().Show();

            dialog = adb;
        }

        public void Alert(string message, string title, string okBtnText)
        {
            var top = Mvx.IoCProvider.Resolve<IMvxAndroidCurrentTopActivity>();
            var act = top.Activity;

            var adb = new AlertDialog.Builder(act);
            adb.SetTitle(title);
            adb.SetMessage(message);
            adb.SetPositiveButton(okBtnText, (sender, args) =>
            {
                Toast.MakeText(act, "Refreshing..", ToastLength.Short);
            });

            adb.Create().Show();

            dialog = adb;
        }

        public void Dispose()
        {
            dialog.Dispose();
        }
    }
}