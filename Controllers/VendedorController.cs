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
    public class VendedorController: ControllerBase
    {

            private readonly CatalogoContext _context;

             public VendedorController(CatalogoContext context)
                    {

                                 _context = context;

                     }

                   

                     [HttpPost]
                    public IActionResult Create(Vendedor vendedor){

                         
                                _context.Add(vendedor);
                                _context.SaveChanges();
                                return CreatedAtAction(nameof(ObterPorId), new { id = vendedor.Id }, vendedor);
     

                    }

                    [HttpGet("{id}")]
                    public IActionResult ObterPorId(int id){

                                    var Vendedor  = _context.Vendedores.Find(id);
                                    if(Vendedor == null)
                                            return NotFound();
                                    return Ok(Vendedor);
                    }
           

            

        
    }
}