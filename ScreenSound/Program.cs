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


Episodio ep1 = new(1, "Alanzoka jogando com o Brino", 68);
ep1.AdicionarConvidados("Alanzoka");
ep1.AdicionarConvidados("Brino");

Episodio ep2 = new(2, "Entrevistando o THOR", 73);
ep1.AdicionarConvidados("Chris Hemsworth");

Podcast podcast = new("Podcast aleatorio", "Yudi");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();
