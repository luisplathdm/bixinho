namespace bixinho;

public class bixos

{

    public double   tristeza ;
    public double   fome;
    public double   memoria;
    public string   NomeFoto;
  
    public bixos()
     {
     tristeza = 0;
     fome = 0;
     memoria = 0;
     NomeFoto = "";
    }
 public string GetNomeFoto()
    {
        return NomeFoto;
    }
    public void SetTristeza (double f)
    {
        if (f >= 0 && f <= 1)
        tristeza = f;
        else if (f > 1)
        tristeza = 1;
        else if (f > 0)
        tristeza = 0;
    }
    public void SetFome (double s)
    {
        if (s >= 0 && s <= 1)
        fome = s;
        else if (s > 1)
        fome = 1;
        else if (s > 0)
        fome = 0;
    }

    public void SetMemoria (double e)
    {
        if (e >= 0 && e <= 1)
        memoria = e;
        else if (e > 1)
        memoria = 1;
        else if (e > 0)
        memoria = 0;
    }
    

}