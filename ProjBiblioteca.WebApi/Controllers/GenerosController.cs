using Microsoft.AspNetCore.Mvc;
using ProjBiblioteca.Application.InputModels;
using ProjBiblioteca.Application.Interfaces;
using ProjBiblioteca.Application.ViewModels;

namespace ProjBiblioteca.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]    
    public class GenerosController : ControllerBase
    {
        private IGeneroService _generoService;

        public GenerosController(IGeneroService generoService)
        {
            this._generoService = generoService;
        }

        [HttpGet]
        public GeneroListViewModel Get()
        {
            return _generoService.Get();
        } 

        [HttpGet("{id}", Name="GetGenerosDetails")]
        public ActionResult<GeneroViewModel> Get(int id) 
        { 
            var result = _generoService.Get(id);

            if (result == null)
                return NotFound();

            return result;
        }               

        [HttpPost]
        public ActionResult Post([FromBody] GeneroInputModel genero)
        {
            var result = _generoService.Post(genero);

            return new CreatedAtRouteResult("GetGenerosDetails", 
                new { id = result.Id}, result);
        }     

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] GeneroInputModel genero)
        {
            if (id != genero.Id)
            {
                return BadRequest();
            }

            var result = _generoService.Put(id, genero);

            return new CreatedAtRouteResult("GetGenerosDetails", 
                new { id = result.Id }, result);
        }

        [HttpDelete("{id}")]
        public ActionResult<GeneroViewModel> Delete(int id)
        {
            var result = _generoService.Delete(id);

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }
        
    }
}