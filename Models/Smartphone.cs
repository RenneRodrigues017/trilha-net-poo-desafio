namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        

        public string Numero { get; set; }
        // Feito: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo { get; set;}
        private string IMEI { get; set;}
        private int Memoria { get; set;}

        public Smartphone(string numero, string modelo, string iMEI, int memoria)
        {
            Numero = numero;
            // Feito: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            IMEI = iMEI;
            Memoria = memoria;
        }

        
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

       

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}