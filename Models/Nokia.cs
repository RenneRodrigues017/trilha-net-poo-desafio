namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // Feito: Sobrescrever o método "InstalarAplicativo"

        public Nokia(string numero, string modelo, string iMEI, int memoria ) : base( numero, modelo,iMEI,memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            string nome = "Nokia";
            Console.WriteLine($"Instalando o {nomeApp} no {nome}");
        }
    }
}