using IDbContextImplementation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IDbContextImplementation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntitiesController : ControllerBase
    {
        private readonly IDbContextFactory<EntityDbContext> _dbContext;

        public EntitiesController(IDbContextFactory<EntityDbContext> dbContext)
        {
            _dbContext = dbContext; 
        }

        [HttpGet]
        public async Task<IEnumerable<Entity>> GetAllData()
        {
            var context = _dbContext.CreateDbContext();

            return await context.Entities.ToListAsync();
        }

        [HttpPost]
        public async Task AddData(EntityDTO entitydto)
        {
            var context = _dbContext.CreateDbContext();

            var entity = new Entity
            {
                Name = entitydto.Name,
                City = entitydto.City,
            };

            context.Add(entity);
            await context.SaveChangesAsync();
        }
    }
}
