public class Bitkiler:Canlilar
{
    protected void FotosentezYapmak()
   {
        Console.WriteLine("Bitkiler fotosentez yapar.");
   }
}

public class TohumluBitkiler:Bitkiler
{

    public TohumluBitkiler(){
        base.FotosentezYapmak();
        base.Beslenme();
        base.Boşaltım();
        base.Solunum();
    }
    public void TohumlaCogalma()
    {
        Console.WriteLine("Tohumlu bitkiler tohumla çoğalır");
    }
}

public class TohumsuzBitkiler:Bitkiler
{

    public TohumsuzBitkiler(){
        base.FotosentezYapmak();
        base.Beslenme();
        base.Boşaltım();
        base.Solunum();
    }
    public void TohumsuzCogalma()
    {
        Console.WriteLine("Tohumsuz bitkiler sporla çoğalır");
    }
}