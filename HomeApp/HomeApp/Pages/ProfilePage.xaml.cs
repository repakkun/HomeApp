using Xamarin.Forms;

namespace HomeApp.Pages
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Покажем уведомление с предупреждением, если пользователю выдаются сразу все доступы.
        /// </summary>
        private void NotifyUser(object sender, ToggledEventArgs e)
        {
            if (gasSwitch.On && climateSwitch.On && electroSwitch.On)
                DisplayAlert("Внимание!", "Пользователь получит полный доступ ко всем системам", "OK");
        }
    }
}