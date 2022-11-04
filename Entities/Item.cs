using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Payment_api.Entities
{
    public class Item
    {

                 [Key]
                 [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
                  public int Id { get; set; }

                [ForeignKey("Produto")]
               [Required(ErrorMessage = "Não preencheu o campo id do produto")]
                public int IdProduto{ get; set; }
                public Produto Produto { get; set; }
                
                [Required(ErrorMessage = "Não preencheu o campo quantidade")]
                [Precision(14, 2)]
                public double Quantidade { get; set; }

                [Required(ErrorMessage = "Não preencheu o campo valor")]
                [Precision(14, 2)]
                public double  Valor { get; set; }

               [Required(ErrorMessage = "Não preencheu o campo id da venda")]
                public int IdVenda{ get; set; }
                public Venda  venda{ get; set; }
        
    }
}