using MvvmCross.ViewModels;
using System.Threading.Tasks;

namespace WeatherPro.Core.ViewModel
{
    public class ProgressDialogFragmentViewModel : MvxViewModel
    {
        private string dialogStatus;
        public string DialogStatus
        {
            get => dialogStatus;
            set
            {
                dialogStatus = value;

                RaisePropertyChanged();
            }
        }

        public override Task Initialize()
        {
            dialogStatus = "Fetching Data..";

            return base.Initialize();
        }
    }
}
