using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Domain.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; } = string.Empty;
        public int Saldo { get; set; }
        public IEnumerable<Entrada>? Entrada { get; set; }
        public IEnumerable<Saida>? Saida { get; set; }
        public DateTime DataCriacao { get; set; }


    }
}
