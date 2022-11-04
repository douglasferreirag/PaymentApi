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
                 [DataType(DataType.Date)]
                [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
                public DateTime Data { get; set; }

                [ForeignKey("Produto")]
               [Required(ErrorMessage = "Não preencheu o campo id do vendedor")]
                public int IdVendedor{ get; set; }
                public Vendedor  Vendedor{ get; set; }

                 [Required(ErrorMessage = "Não preencheu o campo status")]
                public StatusVenda  Status{ get; set; }


    }
}