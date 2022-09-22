
using Domain.Master;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebAppi.Controllers
    
{

    [ApiController]
    [Route("Api/data")]
    public class DataController: ControllerBase
    {
        private readonly ApplicationDBContext context;

        public DataController(ApplicationDBContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<AppData>>> Get()
        {
            return await context.AppData.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Post(AppData appData)
        {
            context.Add(appData);
            await context.SaveChangesAsync();
            return Ok();
            
        }
    }
}
