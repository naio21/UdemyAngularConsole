using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : IJogador
    {
        public string Chuta()
        {
            return "Cristiano chutou com força";
        }

        public string Corre()
        {
            return "Cristiano correu e ultrapassou o zagueiro";
        }

        public string Passa()
        {
            return "Cristiano passou a bola para o atacante";
        }
    }
}