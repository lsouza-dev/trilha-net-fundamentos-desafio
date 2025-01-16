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
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = Console.ReadLine();

            // Verifica se o veículo existe

            bool placaEncontrada = veiculos.Find(x => x.ToUpper() == placa.ToUpper()) != null ? true : false;
            if (!placaEncontrada)
            {
                System.Console.WriteLine("A placa inserida não foi encontrada em nosso sistema.");
                return;
            }

            // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
            // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
            // *IMPLEMENTE AQUI*
            int horas = 0;
            decimal valorTotal = 0;

            System.Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            int.TryParse(Console.ReadLine(), out horas);

            valorTotal = precoInicial + precoPorHora * horas;

            // TODO: Remover a placa digitada da lista de veículos
            // *IMPLEMENTE AQUI*

            veiculos.Remove(placa);
            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");


        }

        public void ListarVeiculos()
        {
            if(veiculos.Count == 0){
                System.Console.WriteLine("Não há veículos estacionados.");
                return;
            }

            string text = "Os veículos estacionados são:\n\n";
            veiculos.ForEach(x =>
            {
                text += $"Placa: {x}\n";
            });

            System.Console.WriteLine(text);
        }
    }
}
