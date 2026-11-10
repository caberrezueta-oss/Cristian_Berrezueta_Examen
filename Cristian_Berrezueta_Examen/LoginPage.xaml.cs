namespace Cristian_Berrezueta_Examen;

public partial class LoginPage : ContentPage
{
    string[,] usuarios = new string[2, 2] {
        { "estudiante", "moviles" },
        { "suda", "2025" }
    };

    public LoginPage()
    {
        InitializeComponent();
    }

    private async void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string user = txtUsuario.Text;
        string pass = txtClave.Text;
        bool acceso = false;

        for (int i = 0; i < 2; i++)
        {
            if (usuarios[i, 0] == user && usuarios[i, 1] == pass)
            {
                acceso = true;
                break;
            }
        }

        if (acceso)
        {
            await Navigation.PushAsync(new RegistroPage(user));
        }
        else
        {
            await DisplayAlert("Error", "Dato incorrecto", "OK");
        }
    }
}