Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my life") {
    Duracao = 213,
    Disponivel = true,
};
musica1.Duracao = 279;

Musica musica2 = new Musica(queen, "Bohemian Rhapsody") {
    Duracao = 354,
    Disponivel = false,
};
musica2.Duracao = 279;

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

albumDoQueen.ExibirAlbumMusicasDoAlbum();
queen.ExibirDiscografia();