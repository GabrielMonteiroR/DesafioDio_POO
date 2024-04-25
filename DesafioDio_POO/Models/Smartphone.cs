using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDio_POO.Models
{
    internal abstract class Smartphone
    {
        public string Number { get; set; }
        private string Model { get; set; }
        private string Imei {  get; set; }
        private string Memoria { get; set; }

        protected Smartphone(string number, string model, string imei, string memoria)
        {
            Number = number;
            this.Model = model;
            this.Imei = imei;
            this.Memoria = memoria;
        }

        public void ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nome);

    }
}
