namespace AppBank.Interfaces
{
    public interface IAlertManager
    {
        event Action<string, string, string> OnShow;
        void Show(string message, string title, string color);
    }
}
