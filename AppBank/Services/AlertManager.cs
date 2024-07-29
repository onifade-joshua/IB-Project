using AppBank.Interfaces;

namespace AppBank.Services
{
    public class AlertManager : IAlertManager
    {
        public event Action<string, string, string>? OnShow;

        public void Show(string message, string title, string color)
        {
            OnShow?.Invoke(message, title, color);
        }
    }
}
