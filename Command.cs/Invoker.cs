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
        /// <Undo & Redo>
        public Command Undo()
        {
            if(iterator < commands.Count - 1)
            {
                iterator++;
                return commands[commands.Count - iterator - 1];
            }
            throw new Exception("Max Undo");
        }

        public Command Redo()
        {
            if (iterator > 0)
            {
                iterator--;
                return commands[commands.Count - iterator - 1];
            }
            throw new Exception("Max Redo");
        }
        /////////////////////////////////////////

        public void AddCommand(Command command)
        {
            commands.RemoveRange(commands.Count - iterator, iterator);
            iterator = 0;
            commands.Add(command);
        }
    }
}

