using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Payment_api.Context;
using Payment_api.Entities;
using Payment_api.Enums;

namespace Payment_api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        
                    private readonly CatalogoContext _context;
                    public VendaController(CatalogoContext context)
                    {

                                 _context = context;

                     }

                  

                   

                     [HttpPost]
                    public IActionResult Create(Venda venda){

                            if((venda.Itens.Count > 0) && (venda.IdVendedor != 0)&&
                                  (_context.Vendedores.Find(venda.IdVendedor).Id == venda.IdVendedor)
                                 )

                            {
                                _context.Add(venda);
                                _context.SaveChanges();
                                return CreatedAtAction(nameof(ObterPorId), new { id = venda.Id }, venda);
                            }

                            else

                                return BadRequest(venda);

                    }

                    [HttpGet("{id}")]
                    public IActionResult ObterPorId(int id){

                                    var venda  = _context.Vendas.Find(id);
                                    if(venda == null)
                                            return NotFound();
                                    return Ok(venda);
                    }

                    [HttpPut("{id}")]
                    public IActionResult Atualizar (int id, StatusVenda Status){

                                var VendaBanco =  _context.Vendas.Find(id);
                                 if(VendaBanco == null)
                                            return NotFound();

                                if  (  ((int) VendaBanco.Status !=  3) && ( ((int) VendaBanco.Status + 1) ==  ((int) Status ) )  ) {

                                     

                                                VendaBanco.Status = Status;

                                                 _context.Vendas.Update(VendaBanco);
                                                 _context.SaveChanges();

                                                return Ok(VendaBanco);
      

                                }
                                 

                            

                                 return BadRequest(VendaBanco);


                     }

    }
}