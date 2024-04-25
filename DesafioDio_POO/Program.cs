using DesafioDio_POO.Models;
using System;

class Program
{
    static void Main(string[] args)
    {
        Iphone iphoneOne = new Iphone("1243342","Iphone 14","23324","128Gb");
        Nokia nokiaOne = new Nokia("324342","Nokia","11114","64gb");

        Console.WriteLine("NOKIA:");
        nokiaOne.ligar();
        nokiaOne.ReceberLigacao();
        nokiaOne.InstalarAplicativo("whatsapp");

        Console.WriteLine("IPHONE: ");
        iphoneOne.ligar();
        iphoneOne.ReceberLigacao();
        iphoneOne.InstalarAplicativo("facebook");

    }
}
