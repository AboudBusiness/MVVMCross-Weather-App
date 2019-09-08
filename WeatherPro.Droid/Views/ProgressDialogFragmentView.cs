using Android;
using Android.App;
using Android.OS;
using Android.Views;
using MvvmCross.Droid.Support.V4;
using WeatherPro.Core.ViewModel;

namespace WeatherPro.Droid.Views
{
    public class ProgressDialogFragmentView : MvxDialogFragment<ProgressDialogFragmentViewModel>
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //Create your fragment here..
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.ProgressDialogFragment, container, false);

            return view;
        }
    }
}