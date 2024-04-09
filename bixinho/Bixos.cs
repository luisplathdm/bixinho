using System.Security.Cryptography.X509Certificates;

namespace bixinho;

public class bixos

{

    protected double   tristeza ;
    protected double   fome;
    protected double   memoria;
    protected string   NomeFoto;
    protected string   NomeFotoMorto;
    protected bool Morto;
    public bixos()
     {
     tristeza = 0;
     fome = 0;
     memoria = 0;
     NomeFoto = "";
    }

  public void SetMorto(bool M)
     { 
      Morto=M;
     }

      public bool GetMorto()
      {
      return Morto;
      }
 public string GetNomeFoto()
    {
       
        if (Morto)
        return  NomeFotoMorto;
        else 
        return NomeFoto;
        
    }
    public void SetTristeza (double f)
    {
        if (f > 1)
            tristeza = 1;
        else if (f > 0)
        {
            tristeza = 0;
            Morto = true;
        }
        else 
            tristeza = f;
    }

     public double Gettristeza()
     {
        return tristeza;
     }
    
    public void SetFome (double s)
    {
       if (s > 1)
            fome = 1;
        else if (s > 0)
        {
            fome = 0;
            Morto = true;
        }
        else 
            fome = s;
    }
      public double Getfome()
        {
            return fome;
        }
            

    public void SetMemoria (double e)
    {
       if (e > 1)
            memoria= 1;
        else if (e > 0)
        {
            memoria = 0;
            Morto = true;
        }
        else 
            memoria = e;
    }
    
    public double Getmemoria()
    {
        return memoria;
    }

}