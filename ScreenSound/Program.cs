Episodio ep1 = new(2, "Tecnicas de Facilitaçao", 45);
ep1.AdicionarConvidados("Diego");
ep1.AdicionarConvidados("Rodrigo");
ep1.AdicionarConvidados("Só");

Episodio ep2 = new(1, "Tecnicas de Dificultação", 67);
ep2.AdicionarConvidados("Rodrigo");
ep2.AdicionarConvidados("Diego");
ep2.AdicionarConvidados("Apenas");


Podcast podcast = new("Podcast Especial", "Dieguito");
podcast.AdicionarEpsodio(ep1);
podcast.AdicionarEpsodio(ep2);
podcast.ExibirDetalhes();

/* CÓDIGO ANTIGO

Banda queen = new Banda("Queen");

Album albumQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my Life")
{
    Duracao = 213,
    Disponivel = true,

};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354, // inicializadores
    Disponivel = false,
};


albumQueen.AdicionarMusica(musica1);
albumQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumQueen.ExibirAlbum();
queen.ExibirDiscografia();

*/