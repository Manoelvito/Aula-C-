namespace Models
{
    public class Autor
    {

        public string Nome { get; set; }
        public string Origem { get; set; }


        public Autor(string nome, string origem)
        {
            Nome = nome;
            Origem = origem;
        }
    }
}
