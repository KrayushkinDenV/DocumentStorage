//---Context---//
using DocumentStorage.Repositories;
using DocumentStorage.Data.Models;
//---Models---//
using DocumentStorage.Controllers.Models;
//---Services---//
using DocumentStorage.Services;
//---Packages---//
using Microsoft.AspNetCore.Mvc;

namespace DocumentStorage.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController : ControllerBase
    {
        private IAuthorRepository authorContext;
        public AuthorController(IAuthorRepository authorContext) => this.authorContext = authorContext;

        [HttpPost("Create")]
        public async Task CreateAuthor([FromForm] AuthorModel formData) =>
            await authorContext.CreateAsync(formData.AutoMapService());
    }
}
