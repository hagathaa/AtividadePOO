using System.IO.Pipes;

namespace Atividade_POO;

public abstract class  Veiculo
{
    protected  Veiculo(string modelo, int ano)
    {
    Modelo = modelo;
    Ano = ano;
    }
   public string Modelo { get; }
   public int Ano { get; private set; }

   public void Ligar()
   {
       Console.WriteLine($"{Modelo} esta Ligando...");
   }

   public virtual void Acelerar()
   {
       Console.WriteLine($"{Modelo} esta Acelerando...");
   }
   
   
   
   
   
}