namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; }
        private string IMEI;
        private int Memoria;      

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;              
        }

        public string PegarModeloAparelho()
        {
            return Modelo;           
        }       

        public void Ligar()
        {
            Console.WriteLine("Efetuando chamada...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo chamada...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}