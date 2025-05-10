namespace Models
{
    public class Livro
    {

        public string Titulo { get; set; }
        public Autor Autor { get; set; }
        public int Ano { get; set; }


        public Livro(string titulo, Autor autor, int ano)
        {
            Titulo = titulo;
            Autor = autor;
            Ano = ano;
        }


        public void ExibirLivro()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor.Nome}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Origem do Autor: {Autor.Origem}");
            Console.WriteLine();
        }
    }
}
