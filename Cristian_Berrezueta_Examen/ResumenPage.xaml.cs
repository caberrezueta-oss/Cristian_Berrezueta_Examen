namespace Cristian_Berrezueta_Examen;

public partial class ResumenPage : ContentPage
{
    public ResumenPage(string user, string nombre, string apellido, string edad, string fecha, string ciudad, string pais, string monto, string mensual, string total)
    {
        InitializeComponent();
        lblTopUsuario.Text = "Usuario conectado: " + user;

        lblNombre.Text = nombre;
        lblApellido.Text = apellido;
        lblEdad.Text = edad;
        lblFecha.Text = fecha;
        lblCiudad.Text = ciudad;
        lblPais.Text = pais;
        lblMonto.Text = monto;
        lblMensual.Text = mensual;
        lblTotal.Text = total;
    }
}