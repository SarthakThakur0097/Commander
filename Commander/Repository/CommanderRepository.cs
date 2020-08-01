using System;
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

        public void CreateCommand(Command command)
        {
            if(command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            _context.Commands.Add(command);
            SaveChanges();
        }

        public void DeleteCommand(Command command)
        {
            if(command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }
            _context.Commands.Remove(command);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(c => c.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges()) >= 0;
        }

        public void UpdateCommand(Command command)
        {
            //Nothing
        }
    }
}