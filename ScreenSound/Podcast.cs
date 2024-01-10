class Podcast
{
    private List<Episodio> listaDeEpisodios = new();
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }

    public int TotalEpisodios => listaDeEpisodios.Count;

    public void AdicionarEpsodio(Episodio episodio)
    {
        listaDeEpisodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} apresentado por {Host}");
        foreach (Episodio episodio in listaDeEpisodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"Este podcast possui {TotalEpisodios} episodios");
    }
}