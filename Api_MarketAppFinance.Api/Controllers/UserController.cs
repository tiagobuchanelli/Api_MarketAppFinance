using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api_MarketAppFinance.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IApplicationServiceUser _applicationServiceUser;

        public UserController(IApplicationServiceUser applicationService)
        {
            _applicationServiceUser = applicationService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceUser.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceUser.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] UserDto userDto)
        {
            try
            {
                if (userDto is null)
                    return NotFound();

                _applicationServiceUser.Add(userDto);
                return Ok("Usuário Cadastrado com sucesso!");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] UserDto userDto)
        {
            try
            {
                if (userDto is null)
                    return NotFound();

                _applicationServiceUser.Update(userDto);
                return Ok("Usuário Atualizado com sucesso!");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] UserDto userDto)
        {
            try
            {
                if (userDto is null)
                    return NotFound();

                _applicationServiceUser.Remove(userDto);
                return Ok("Usuário Removido com sucesso!");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}