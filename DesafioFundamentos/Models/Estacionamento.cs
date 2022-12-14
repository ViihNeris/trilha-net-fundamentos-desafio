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
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTADO*
            Console.Write("\nDigite a placa do veículo para estacionar: ");
            string placaVeic = Console.ReadLine();
            veiculos.Add(placaVeic);
        }

        public void RemoverVeiculo()
        {
            Console.Write("\nDigite a placa do veículo para remover: ");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTADO*
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.Write("\nDigite a quantidade de horas que o veículo permaneceu estacionado: ");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTADO*
                int horas = 0;
                decimal valorTotal = 0;
                string risca = "------------------------------------";
                horas = Convert.ToInt32(Console.ReadLine());
                valorTotal = precoInicial + (precoPorHora * horas);

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTADO*
                veiculos.Remove(placa);
                Console.WriteLine($"\nO veículo '{placa}' foi removido.\n{risca}\nPREÇO TOTAL: {valorTotal.ToString("C")}.\n");
            }
            else
            {
                Console.WriteLine("\nDesculpe, esse veículo não está estacionado aqui. Verifique se a placa foi inserida corretamente.");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTADO*
                Console.WriteLine("\nOs veículos estacionados são:");
                foreach (string item in veiculos)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("\nNão há veículos estacionados.");
            }
        }

        public void Continue()
        {
            Console.WriteLine("\nPressione ENTER para continuar.");
            Console.ReadLine();
        }
    }
}
