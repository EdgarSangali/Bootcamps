


namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
         public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            this.Numero = numero;
            this.Modelo = modelo;
            this.IMEI = imei;
            this.Memoria = memoria;
            
        }
        public string Numero { get; set; }
        private string Modelo; 
        private string IMEI; 
        private int  Memoria; 
        

       

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