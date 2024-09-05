public class Musica
{
    private string nome { get; set; }
    private string artista { get; set; }
    private int duracao { get; set; } // Segundos
    private bool disponivel { get; set; }

    public Musica(string nome, string artista, int duracao)
    {
        this.nome = nome;
        this.artista = artista;
        this.duracao = duracao;
    }
}
