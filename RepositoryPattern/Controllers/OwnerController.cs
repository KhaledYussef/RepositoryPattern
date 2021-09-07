using Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly ILoggerManager logger;
        private readonly IRepositoryWrapper repository;

        public OwnerController(ILoggerManager _logger, IRepositoryWrapper _repository)
        {
            repository = _repository;
            logger = _logger;
        }

        [HttpGet]
        public IActionResult GetAllOwners()
        {
            try
            {
                
                return Ok(repository.Owner.GetAllOwners());
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                return StatusCode(500);
            }
        }


        [HttpGet]
        [Route("{id}")]
        public IActionResult GetOwnerById(int id)
        {
            try
            {
                var owner = repository.Owner.GetOwnerById(id);
                if (owner == null)
                {
                    logger.LogWarn("Client has requested an owner that not exist");
                    return NotFound();
                }
                return Ok(owner);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                return StatusCode(500);
            }
        }
    }
}
