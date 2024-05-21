namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *I*
            if (Suite.Capacidade > 0 && Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *Implementado*
                if (hospedes == null)
                    throw new Exception("A quantidade de hóspedes é inválida");
                else 
                throw new Exception("A quantidade de hóspedes é maior do que a capacidade da suíte");

            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *Implementado*
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            
            // *Implementado*
            decimal valor = (DiasReservados * Suite.ValorDiaria);

            // *Implementado*
            if (DiasReservados >= 10)
            {
                valor = valor * 0.9M;
            }
            
            return valor;
        }
    }
}