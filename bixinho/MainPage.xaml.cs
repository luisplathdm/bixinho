using Microsoft.Maui.Controls;

namespace bixinho;

public partial class MainPage : ContentPage

{
	elefante Elefantão;
	lobo Lobão;
	macaco Cesar;
	Personagem atual;


	public MainPage()
	{
		InitializeComponent();

		imgpersonagem.Source = "elefante.jpg";
		Elefantão = new elefante();
		Lobão = new lobo();
		Cesar = new macaco();

		atual = Elefantão;

		imagemdopersonagem.Source = atual.GetNomeDaFoto();
	}
	

}