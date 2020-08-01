using System.Collections.Generic;
using Commander.Models;

namespace Commander.Repository
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command command)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command command)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id = 0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pan"},
                new Command{Id = 0, HowTo="Cut bread", Line="Boil water", Platform="Kettle & Pan"},
                new Command{Id = 0, HowTo="Make a cup of tea", Line="Boil water", Platform="Kettle & Pan"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command
            {
                Id = 0,
                HowTo="Boil an egg", 
                Line="Boil water", 
                Platform="Kettle & Pan"
            };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command command)
        {
            throw new System.NotImplementedException();
        }
    }
}