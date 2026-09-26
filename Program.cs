namespace Atividade_POO;

internal class Program
{
    private static void Main(string[] args)
    {
        Veiculo[] veiculos =
        [
            new Carro("g3", 2026),
            new Moto("gol", 199),
            new Caminhao("fusca", 4286)
        ];
        foreach (var veiculo in veiculos)
        {
            veiculo.Ligar();
            veiculo.Acelerar();
           
        }

        
        
    }
}