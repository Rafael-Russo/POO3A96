using System;

namespace POO3A96.DTO
{
    class MusicaDTO
    {
        private int idMusica, idCD, idGravadora;
        private string nome, nomeAutor;

        public int IdMusica { get => idMusica; set => idMusica = value; }

        public string Nome { get => nome; set => nome = value; }
        public string NomeAutor { get => nomeAutor; set => nomeAutor = value; }
        public int IdCD { get => idCD; set => idCD = value; }
        public int IdGravadora { get => idGravadora; set => idGravadora = value; }
    }

}
