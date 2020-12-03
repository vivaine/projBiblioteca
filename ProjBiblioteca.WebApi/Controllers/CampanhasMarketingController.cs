using Microsoft.AspNetCore.Mvc;
using ProjBiblioteca.Application.InputModels;
using ProjBiblioteca.Application.Interfaces;
using ProjBiblioteca.Application.ViewModels;

namespace ProjBiblioteca.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]        
    public class CampanhasMarketingController : ControllerBase
    {
        private ICampanhaMarketingService _campanhaService;

        public CampanhasMarketingController(ICampanhaMarketingService campanhaMarketingService)
        {
            this._campanhaService = campanhaMarketingService;
        }

        [HttpGet]
        public CampanhaMarketingListViewModel Get()
        {
            return _campanhaService.Get();
        } 

        [HttpGet("{id}", Name="GetCampanhasMarketingDetails")]
        public ActionResult<CampanhaMarketingViewModel> Get(int id) 
        { 
            var result = _campanhaService.Get(id);

            if (result == null)
                return NotFound();

            return result;
        }               

        [HttpPost]
        public ActionResult Post([FromBody] CampanhaMarketingInputModel genero)
        {
            var result = _campanhaService.Post(genero);

            return new CreatedAtRouteResult("GetCampanhasMarketingDetails", 
                new { id = result.Id}, result);
        }     

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] CampanhaMarketingInputModel genero)
        {
            if (id != genero.Id)
            {
                return BadRequest();
            }

            var result = _campanhaService.Put(id, genero);

            return new CreatedAtRouteResult("GetCampanhasMarketingDetails", 
                new { id = result.Id }, result);
        }

        [HttpDelete("{id}")]
        public ActionResult<CampanhaMarketingViewModel> Delete(int id)
        {
            var result = _campanhaService.Delete(id);

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }

    }
}