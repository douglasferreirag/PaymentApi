using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Payment_api.Enums;

namespace Payment_api.Entities
{
    public class Venda
    {
        

                [Key]
                [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  
                public int Id { get; set; }

                 [Required(ErrorMessage = "Não preencheu o campo data")]
                public DateTime Data { get; set; }

                [ForeignKey("Produto")]
               [Required(ErrorMessage = "Não preencheu o campo id do vendedor")]
                public int IdVendedor{ get; set; }
                public Vendedor  Vendedor{ get; set; }

                 [Required(ErrorMessage = "Não preencheu o campo lista de ítens")]
                public List<Item> Itens { get; set; }

                 [Required(ErrorMessage = "Não preencheu o campo codigo do pedido")]
                 [MaxLength(255)]
                public string  CodigoPedido{ get; set; }

                 [Required(ErrorMessage = "Não preencheu o campo status")]
                public StatusVenda  Status{ get; set; }


    }
}