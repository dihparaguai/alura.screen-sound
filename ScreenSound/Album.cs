class Album
{
    public Album(string nome)
    {
        Nome = nome;
    }
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(musica => musica.Duracao);

    public void AdicionarMusica (Musica musica)
    {
        musicas.Add (musica);
    }

    public void ExibirAlbum ()
    {
        Console.WriteLine($"Lista de Musicas do Album \"{Nome}\": \n");
        musicas.ForEach(musica =>  Console.WriteLine(musica.Nome));
        Console.WriteLine($"\nPara ouvir este album inteiro voce precisa de {DuracaoTotal} segundos");
    }
}