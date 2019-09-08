namespace WeatherPro.Core.Interfaces
{
    public interface IDialogService
    {
        void Alert(string message);

        void Alert(string message, string title, string okBtnText);

        void Dispose();
    }
}
