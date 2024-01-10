class Musica
{
    public Musica(Banda artista)
    {
        Artista = artista;
    }
    public string Nome { get; set; } // ao contrario do java, devemos declarar variaveis com acesso direto
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public Genero Genero { get; set; }
    public string DescricaoResumida => // quando querermos atribuir apenas GET, usando arrow function / conhecido como lambda em c#
        $"A musica {Nome} pertence a banda {Artista}";
 
/*
    public string DescricaoResumida
    {
        get
        {
            return $"A musica {Nome} pertence a banda {Artista}";
        }
    } // apagar o set inibe a opção de escrita na variavel
*/
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if ( Disponivel == true )
        {
            Console.WriteLine("Disponivel no Plano");
        } else
        {
            Console.WriteLine("Adquira o plano PLus+");
        }
    }
    
    public void ExibirNomeEArtista()
    {
        Console.WriteLine($"Nome da Musica: {Nome}\nNome do Artista: {Artista}");
    }

}

