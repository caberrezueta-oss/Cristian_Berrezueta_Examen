using Microsoft.Extensions.DependencyInjection;

namespace Cristian_Berrezueta_Examen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            // Quitamos el AppShell y ponemos el NavigationPage directo con tu Login
            return new Window(new NavigationPage(new LoginPage()));
        }
    }
}