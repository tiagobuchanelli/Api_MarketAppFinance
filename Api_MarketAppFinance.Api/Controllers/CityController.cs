using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api_MarketAppFinance.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CityController : Controller
    {
        private readonly IApplicationServiceCity _applicationServiceCity;

        public CityController(IApplicationServiceCity applicationService)
        {
            _applicationServiceCity = applicationService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceCity.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceCity.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] CityDto cityDto)
        {
            try
            {
                if (cityDto is null)
                    return NotFound();

                _applicationServiceCity.Add(cityDto);
                return Ok("Usuário Cadastrado com sucesso!");

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] CityDto cityDto)
        {
            try
            {
                if (cityDto is null)
                    return NotFound();

                _applicationServiceCity.Update(cityDto);
                return Ok("Usuário Atualizado com sucesso!");

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] CityDto cityDto)
        {
            try
            {
                if (cityDto is null)
                    return NotFound();

                _applicationServiceCity.Remove(cityDto);
                return Ok("Usuário Removido com sucesso!");

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
