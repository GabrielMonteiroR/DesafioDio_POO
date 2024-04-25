using System;

namespace DesafioDio_POO.Models
{
    internal class Iphone : Smartphone
    {
        public Iphone(string number, string model, string imei, string memoria) : base(number, model, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine(nome);
        }
    }
}

