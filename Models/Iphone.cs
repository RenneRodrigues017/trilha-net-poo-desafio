using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DesafioPOO.Models 
{
    // TODO: Herdar da classe "Smartphone"

    
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
        {
        }
        // Feito: Sobrescrever o método "InstalarAplicativo"
        public override void  InstalarAplicativo(string nomeApp)
        {
            string Nome = "Iphone";
            Console.WriteLine($"Instalando {nomeApp} no {Nome}.");
        }
    }
}