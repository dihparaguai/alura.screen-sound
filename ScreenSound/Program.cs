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