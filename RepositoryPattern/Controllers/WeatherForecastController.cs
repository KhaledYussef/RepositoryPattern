using Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
      


        private IRepositoryWrapper repositoryWrapper;
        public WeatherForecastController(ILogger<WeatherForecastController> logger , IRepositoryWrapper _repositoryWrapper)
        {
      
            repositoryWrapper = _repositoryWrapper;
        }

        [HttpGet]
        public string Get()
        {
            var domastivAcc = repositoryWrapper.Account.FindByCondition(x => x.AccountType == "Domastic");
            var owners = repositoryWrapper.Owner.GetAllOwners();
            return "";
        }
    }
}
