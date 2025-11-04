using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Domain.Models
{
    public class BaseOperacao
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Valor { get; set; }
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        public DateTime DataOperacao { get; set; } = DateTime.UtcNow;
    }
}
