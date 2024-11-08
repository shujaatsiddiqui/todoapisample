using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace sampleremotemfeapi.Controllers
{
    [Authorize] // Protects the entire controller or specific actions
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        [HttpGet()]
        public ActionResult<List<string>> GetTodoList()
        {
            List<string> todoList = new List<string>
            {
                "Finish project report",
                "Update client on progress",
                "Review pull requests",
                "Schedule team meeting",
                "Prepare presentation slides"
            };

            return todoList;
        }
    }
}
