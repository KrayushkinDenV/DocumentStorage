//---Models---//
using DocumentStorage.Models;
//---Packages---//
using Microsoft.AspNetCore.Mvc;

namespace DocumentStorage.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorControllers : ControllerBase
    {
        [HttpPost("Create")]
        public void CreateAuthor(AuthorModel query)
        {
            //Добавить Автора
        }
    }
}
