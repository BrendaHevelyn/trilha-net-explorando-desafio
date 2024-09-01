namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }


        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            if ( Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
            
                throw new Exception ("O número de hospedes é superior a capacidade da suíte.");
                
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            
            int quantidadeDeHospedes = Hospedes.Count;
            return quantidadeDeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            
            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria;

            
            if (DiasReservados >= 10)
            {
                decimal desconto = 10M;
                valor -= valor * desconto/100;
            }

            return valor;
        }
    }
}