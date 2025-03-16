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
            // TODO(feito): Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine().ToString().ToUpper();

            while (placa == null || placa.Length < 6){
                Console.WriteLine("Você precisa fornecer uma placa válida!");
                Console.WriteLine("Digite a placa do veículo para estacionar:");
                placa = Console.ReadLine().ToString();
            }

            veiculos.Add(placa);
            Console.WriteLine($"Veículo de placa {placa} cadastrado com sucesso!");

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            
            // *IMPLEMENTE AQUI*
            string placa = Console.ReadLine().ToString().ToUpper();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                
                // TODO(feito): Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                int horas;

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                string input = Console.ReadLine();

                try {
                    horas = int.Parse(input);
                    Console.WriteLine($"Você digitou {horas} horas.");
                }catch (FormatException){
                    Console.WriteLine("Erro: O valor informado não é um número válido.");
                }
                
                decimal valorTotal = precoInicial + precoPorHora; 

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
                bool removido = veiculos.Remove(placa);
                
                if (removido){
                    Console.WriteLine($"Valor {placa} removido com sucesso.");
                }
                else{
                    Console.WriteLine($"Valor {placa} não encontrado na lista.");
                }

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                foreach(var placa in veiculos){
                    Console.WriteLine(placa);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
