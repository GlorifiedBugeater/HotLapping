namespace HotLapping.Models
{
    public class Circuito
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Pais { get; set; }
        public string Cidade { get; set; }
        public string Tamanho { get; set; }
        public string NumeroCurvas { get; set; }
        public string Recorde { get; set; }
        public string RecordePiloto { get; set; }
        public string RecordeCarro { get; set; }
        public string Tipo { get; set; }
        public string Imagem { get; set; }

        public Circuito()
    }
}
