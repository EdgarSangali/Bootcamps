namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Reserva(Suite suite) 
        {
            this.Suite = suite;
   
        }
                public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }

                                   
            else
            {
               try{

               }
                catch
                {
                    Console.WriteLine("Número de hóspedes é maior que a capacidade de quartos disponíveis");
                }       
            }
            
        }
       
        
                

        internal object ObterQuantidadeHospedes()
        {
            throw new NotImplementedException();
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public object ObterQuantidadeHospedes(int hospedes)
        {
            
           int QuantidadeHospedes = Hospedes.Count;
            return QuantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            
            decimal valor = DiasReservados * (Suite.ValorDiaria);

            
            if (DiasReservados >=10)
            {
                return valor =  valor - (valor/10);
            }

            return valor;
        }
    }
}