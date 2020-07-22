using System.Collections.Generic;
using Commander.Models;
using Commander.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    //api/commands
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsControllers : ControllerBase
    {
        private readonly ICommanderRepo _repository;
        public CommandsControllers(ICommanderRepo repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAppCommands();

            return Ok(commandItems);    
        }

        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);

            return Ok(commandItem);
        }
    }
}