using System.ComponentModel.DataAnnotations;

namespace HotLapping.Models
{
    public class Circuito
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Pais { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string Tamanho { get; set; }
        [Required]
        public string NumeroCurvas { get; set; }
        [Required]
        public string Recorde { get; set; }
        [Required]
        public string RecordePiloto { get; set; }
        [Required]
        public string RecordeCarro { get; set; }
        [Required]
        public string Tipo { get; set; }
        [Required]
        public string Imagem { get; set; }

      
    }
}
