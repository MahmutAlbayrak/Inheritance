﻿internal class Program
{
    private static void Main(string[] args)
    {
        //                  Canlılar
        //                     |
        //       Bitkiler                  Hayvanlar
        //   |              |            |            |
        //Tohumlu       Tohumsuz    Surungenler     Kuslar
        
        TohumluBitkiler tohumluBitki = new TohumluBitkiler();
        tohumluBitki.TohumlaCogalma();

        Console.WriteLine("******************");

        Kuslar martı = new Kuslar();
        martı.Ucmak();

    }
}