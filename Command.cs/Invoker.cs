using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.cs
{
    class Invoker
    {
        List<Command> commands = new List<Command>();
        int iterator;
        public Invoker()
        {
            iterator = 0;
        }

        public Command Undo()
        {
            if(iterator != commands.Count - 1)
            {
                return commands[commands.Count - iterator - 1];
            }
            throw new Exception("Max Undo");
        }
        public void AddCommand(Command command)
        {
            commands.RemoveRange(commands.Count - iterator - 1, iterator);
            commands.Add(command);
        }
    }
}

