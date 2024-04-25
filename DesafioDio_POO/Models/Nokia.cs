using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDio_POO.Models
{
    internal class Nokia : Smartphone
    {
        public Nokia(string number, string model, string imei, string memoria) : base(number, model, imei, memoria) { }
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine(nome);
        }
    }
}
