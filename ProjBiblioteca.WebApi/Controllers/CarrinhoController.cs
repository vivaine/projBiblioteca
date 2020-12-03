using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProjBiblioteca.Application.InputModels;
using ProjBiblioteca.Application.Interfaces;
using ProjBiblioteca.Application.ViewModels;

namespace ProjBiblioteca.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarrinhoController : ControllerBase
    {
        private ICarrinhoService _carrinhoService;

        public CarrinhoController(ICarrinhoService carrinhoService)
        {
            this._carrinhoService = carrinhoService;
        }

        [HttpGet("{id}", Name="GetCarrinhosDetails")]
        public CarrinhoListViewModel Get(string id) 
        { 
            return _carrinhoService.GetPorSession(id);
        }

        public ActionResult Post([FromBody] CarrinhoInputModel carrinho)
        {
             _carrinhoService.Post(carrinho);

            return new CreatedAtRouteResult("GetCarrinhosDetails", 
                new { id = carrinho.SessionUserID });
        }

        [HttpDelete("{id}")]
        public ActionResult<CarrinhoViewModel> Delete(int id)
        {
            var result = _carrinhoService.Delete(id);

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }
    }
}