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

		imagemdopersonagem.Source = "elefante.png";
		Elefantao = new Elefante();
		Lobao = new Lobo();
		Cesar = new Macaco();

		atual = Elefantao;

		imagemdopersonagem.Source = atual.GetNomeFoto();


		AtualizaBixos();

		var timer = Application.Current.Dispatcher.CreateTimer();
		timer.Interval = TimeSpan.FromSeconds(100);
		timer.Tick += (s,e) => 
		PassouTempo(); 
		timer.Start();
	}
	void PassouTempo()
	{
		
	}
	

	void AtualizaBixos()
	{
        Progressofome.Progress = atual.Getfome();
		Progressotristeza.Progress = atual.Gettristeza();
		Progressoconfusao.Progress = atual.Getmemoria();
	}


   private void TrocaBixos(object sender, EventArgs args)
	{
	   if(atual == Elefantao)
	   { 
		  atual = Cesar;
	   }
	   else if(atual == Cesar)
	   { 
		 atual = Lobao;
	   }
	   else 
	   {
		 atual = Elefantao;
	   }
	   imagemdopersonagem.Source = atual.GetNomeFoto();
	   AtualizaBixos();
	}

   private void ProgressoTristeza(object sender, EventArgs args)
   	{
      	atual.SetTristeza(atual.Gettristeza() + 0.1);
		AtualizaBixos();
   	}
   private void ProgressoFome(object sender, EventArgs args)
   	{
      	atual.SetTristeza(atual.Getfome() + 0.1);
		AtualizaBixos();
   	}
   private void ProgressoConfusao(object sender, EventArgs args)
   	{
      	atual.SetTristeza(atual.Getmemoria() + 0.1);
		AtualizaBixos();
   	}
}





