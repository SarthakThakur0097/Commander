using System.Collections.Generic;
using System.Linq;
using Commander.Data;
using Commander.Models;

namespace Commander.Repository
{
    public class CommanderRepository : ICommanderRepo
    {
        private readonly Context _context;
        public CommanderRepository(Context context)
        {
            _context = context;
        }
        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(c => c.Id == id);
        }
    }
}