using Microsoft.Maui.Controls;

namespace bixinho;

public partial class MainPage : ContentPage

{
	Elefante Elefantao;
	Lobo Lobao;
	Macaco Cesar;
	bixos atual;


	public MainPage()
	{
		InitializeComponent();

		imagemdopersonagem.Source = "elefante.jpg";
		Elefantao = new Elefante();
		Lobao = new Lobo();
		Cesar = new Macaco();

		atual = Elefantao;

		imagemdopersonagem.Source = atual.GetNomeFoto();
	}
	
	
}