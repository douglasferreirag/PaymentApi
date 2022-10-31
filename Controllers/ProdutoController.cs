using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Payment_api.Context;
using Payment_api.Entities;

namespace Payment_api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProdutoController  : ControllerBase
    {

            private readonly CatalogoContext _context;

             public ProdutoController(CatalogoContext context)
                    {

                                 _context = context;

                     }

                   

                     [HttpPost]
                    public IActionResult Create(Produto produto){

                         
                                _context.Add(produto);
                                _context.SaveChanges();
                                return CreatedAtAction(nameof(ObterPorId), new { id = produto.Id }, produto);
     

                    }

                    [HttpGet("{id}")]
                    public IActionResult ObterPorId(int id){

                                    var produto  = _context.Produtos.Find(id);
                                    if(produto == null)
                                            return NotFound();
                                    return Ok(produto);
                    }
           

            

        
    }
}