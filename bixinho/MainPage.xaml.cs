using Microsoft.Maui.Controls;

namespace bixinho;

public partial class MainPage : ContentPage

{
	Elefante Elefantao = new Elefante();
	Lobo Lobao  = new Lobo();
	Macaco Cesar = new Macaco();
	bixos atual;


	public MainPage()
	{
		InitializeComponent();

		imagemdopersonagem.Source = "elefante.png";
		
		

		atual = Elefantao;

		imagemdopersonagem.Source = atual.GetNomeFoto();


		AtualizaBixos();

		var timer = Application.Current.Dispatcher.CreateTimer();
		timer.Interval = TimeSpan.FromSeconds(1);
		timer.Tick += (s,e) => 
		PassouTempo(); 
		timer.Start();
	}
	void PassouTempo()
	{
		var Comoatualesta = atual.GetMorto();
		atual.SetTristeza(atual.Gettristeza() - 0.01);
		AtualizaBixos();
		atual.SetFome(atual.Getfome() - 0.01);
		AtualizaBixos();
		atual.SetMemoria(atual.Getmemoria() - 0.01);
		AtualizaBixos();
		if(Comoatualesta != atual.Morto)
		imagemdopersonagem.Source = atual.GetNomeFoto();
		

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
      	atual.SetTristeza(atual.Gettristeza() + 0.01);
		AtualizaBixos();
   	}
   private void ProgressoFome(object sender, EventArgs args)
   	{
      	atual.SetFome(atual.Getfome() + 0.01);
		AtualizaBixos();
   	}
   private void ProgressoConfusao(object sender, EventArgs args)
   	{
      	atual.SetMemoria(atual.Getmemoria() + 0.01);
		AtualizaBixos();
   	}
}





