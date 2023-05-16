//---Models---//
using DocumentStorage.Models;
//---Packages---//
using Microsoft.AspNetCore.Mvc;

namespace DocumentStorage.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController : ControllerBase
    {
        [HttpPost("Create")]
        public async Task CreateAuthor([FromForm] IFormCollection formData)
        {
            await Task.Yield();
            //Добавить Автора
        }
    }
}
