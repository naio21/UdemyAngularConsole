using System;
using System.Collections.Generic;
using GameTOP.Interface;

namespace GameTOP.App
{
    public class JogoFODA
    {
        private readonly IList<IJogador> _jogadores;

        public JogoFODA(IList<IJogador> jogadores)
        {
            _jogadores = jogadores;
        }
        public void IniciarJogo()
        {
            foreach(IJogador jogador in _jogadores)
            {
                Console.WriteLine(jogador.Chuta());
                Console.WriteLine(jogador.Corre());
                Console.WriteLine(jogador.Passa());
            }
            Console.ReadLine();
        }
    }
}