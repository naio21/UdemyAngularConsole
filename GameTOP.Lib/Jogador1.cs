using GameTOP.Interface;
namespace GameTOP.Lib
{
    public class Jogador1 : IJogador
    {
        public readonly string Nome;

        public Jogador1(string nome = "Ronaldo")
        {
            Nome = nome;
        }

        public string Chuta()
        {
            return $"{Nome} chutou";
        }

        public string Corre()
        {
            return $"{Nome} correu";
        }

        public string Passa()
        {
            return $"{Nome} passou a bola";
        }
    }
}