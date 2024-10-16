namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculos para estacionar:");
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            
        }

        public void RemoverVeiculo()
        {

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();
            Console.WriteLine("Placa removida com sucesso.");
            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                int horas = 0;
                decimal valorTotal = 0; 
                horas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Digite no numero de horas {horas} que o veiculo permaneceu");
                Console.WriteLine($" {precoPorHora} x {horas} + {precoInicial} = {valorTotal = precoPorHora * horas + precoInicial}");
                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                veiculos.Remove(placa);
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if(veiculos.Any())
            {
                
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                int contador = 1;
                foreach(string item in veiculos)
                {
                    Console.WriteLine($"{contador} - {item}");
                    contador++;
                    
                }
                
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
