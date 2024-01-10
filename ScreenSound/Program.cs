Banda queen = new Banda("Queen");

Album albumQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my Life");
musica1.Nome = ;
musica1.Duracao = 213;

Musica musica2 = new Musica(queen, "Bohemian Rhapsody");
musica2.Duracao = 354;

albumQueen.AdicionarMusica(musica1);
albumQueen.AdicionarMusica(musica2);

albumQueen.ExibirAlbum();

queen.AdicionarAlbum(albumQueen);
queen.ExibirDiscografia();
