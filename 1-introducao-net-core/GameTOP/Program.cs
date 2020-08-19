using System;

/*
Extensoes recomendadas para programacao .NET no Visual Studio Code:
- C#
- C# Extensions
- Bracket Pair Colorizer
- Material Icon Theme
- Path Intellisense
- Nuget Package Manager
*/

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new Jogo(new Jogador("Ronaldo"));

            jogo.IniciarJogo();
        }
    }

    public class Jogador 
    {
      public Jogador(string nome)
      {
          _Nome = nome;
      }
      public readonly string _Nome;

      public void Chutar()
      {
          Console.WriteLine($"{_Nome} está chutando");
      }

      public void Correr()
      {
          Console.WriteLine($"{_Nome} está correndo");
      }

      public void Passar()
      {
          Console.WriteLine($"{_Nome} está passando");
      }
    }
}


