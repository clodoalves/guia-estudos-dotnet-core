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
            var jogo = new Jogo("Jose");

            jogo.IniciarJogo();
        }
    }
}

class Jogo
{
  public string _nomeJogador { get; }

  public Jogo(string nomeJogador)
  {
    _nomeJogador = nomeJogador;
  }

  public void IniciarJogo()
  {
    Console.WriteLine($"{_nomeJogador} deu um passe");
  }
}
