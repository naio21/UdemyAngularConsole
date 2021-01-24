using System;
using System.Collections.Generic;
using GameTOP.Interface;
using GameTOP.Lib;

namespace GameTOP.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(
                new List<IJogador>
                {
                    new Jogador1(), 
                    new Jogador2()
                }
            );
            jogo.IniciarJogo();
        }
    }
}
