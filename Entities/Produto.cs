using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Payment_api.Entities
{
    public class Produto
    {

                [Key]
                [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
                public int Id { get; set; }

             
                 [Required(ErrorMessage = "Não preencheu o campo descrição")]
                 [MaxLength(255)]
                public string  Descricao { get; set; }

                 [Required(ErrorMessage = "Não preencheu o campo valor do produto")]
                 [Precision(14, 2)]
                public double  Valor { get; set; }

        
    }
}