using System;

namespace GameTOP
{
    class Jogo
    {    
        public Jogador _jogador { get; }

        public Jogo(Jogador jogador)
        {
            _jogador = jogador;
        }

        public void IniciarJogo()
        {
            _jogador.Chutar();
            _jogador.Correr();
            _jogador.Passar();
        }
    }
}
