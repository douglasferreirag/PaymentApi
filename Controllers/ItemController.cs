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
    public class ItemController  : ControllerBase
    {
        
              private readonly CatalogoContext _context;

             public ItemController(CatalogoContext context)
                    {

                                 _context = context;

                     }


                     
                   

                     [HttpPost]
                    public IActionResult Create(Item item){

                         
                                _context.Add(item);
                                _context.SaveChanges();
                                return CreatedAtAction(nameof(ObterPorId), new { id = item.Id }, item);
     

                    }

                    [HttpGet("{id}")]
                    public IActionResult ObterPorId(int id){

                                    var item  = _context.Itens.Find(id);
                                    if(item == null)
                                            return NotFound();
                                    return Ok(item);
                    }
           

            

        
    }
}

