namespace FrecuenciaCardiaca
{
	public partial class MainPage : ContentPage
	{

		public MainPage()
		{
			InitializeComponent();
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(Latidos.Text))
			{
				var latidos = double.Parse(Latidos.Text);
				var frecuencia = latidos * 4;
				Frecuencia.Text = frecuencia.ToString();

				string resultado = "";

				if (frecuencia < 60)
				{
					resultado = "Frecuencia cardiaca baja";
				}
				else if (frecuencia >= 60 && frecuencia <= 100)
				{
					resultado = "Frecuencia cardiaca normal";
				}
				else if (frecuencia > 100)
				{
					resultado = "Frecuencia cardiaca alta";
				}

				DisplayAlert("Resultado: ", resultado, "Quitar");
			}
			else
			{
				DisplayAlert("Datos erroneos", "Por favor, llena toda la información", "Quitar");
			}
		}
	}
}
