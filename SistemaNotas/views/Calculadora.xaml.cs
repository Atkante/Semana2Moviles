namespace SistemaNotas.views;

public partial class Calculadora : ContentPage
{
	public Calculadora()
	{
		InitializeComponent();
	}

    private void Calcular_Clicked(object sender, EventArgs e)
    {
		double nota1 = double.Parse(notaSeguimiento1.Text);
		double examen1 = double.Parse(notaExamen1.Text) ;
        double parcial1 = (nota1 * 0.3) + (examen1 * 0.2);
        double nota2 = double.Parse(notaSeguimiento2.Text);
        double examen2 = double.Parse(notaExamen2.Text);
		double parcial2 = (nota2 * 0.3 ) + (examen2 * 0.2);
        double Total = parcial1 + parcial2 ;
        string fecha = datePicker.Date.ToString();
		DisplayAlert("Notas Finales","Nota 1: "+nota1 +'\n'+ "Examen 1: " + examen1 + "Parcial : " + parcial1 + '\n'+
					 "Nota 2: " + nota2 + '\n' + "Examen 2: " + examen2 + "Parcial : " + parcial2 + '\n'+"Total: "+Total+'\n'+"Fecha: "+fecha, "OK");

		

    }
}