using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Payment_api.Entities
{
    public class Vendedor
    {

                [Key]
                [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
                public int Id { get; set; }

                [Required(ErrorMessage = "Não preencheu o campo Nome ")]
                [MaxLength(255)]
                public string Nome { get; set; }

                [Required(ErrorMessage = "Não preencheu o campo CPF")]
                [MaxLength(255)]
                public string  CPF { get; set; }

                [Required(ErrorMessage = "Não preencheu o campo Email")]
                [MaxLength(255)]
                public string  Email { get; set; }

                [Required(ErrorMessage = "Não preencheu o campo Telefone")]
                [MaxLength(255)]
                public string  Telefone { get; set; }

               

        
    }
}