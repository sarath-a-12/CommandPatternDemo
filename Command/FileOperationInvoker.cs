using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class FileOperationInvoker
    {
        private readonly Dictionary<string, ICommand> _commandMapper = [];

        public void SetCommand(string operation, ICommand command)
        {
            _commandMapper[operation] = command;
        }

        public string ExecuteCommand(string operation)
        {
            ICommand command = _commandMapper[operation];
            if (command != null)
            {
                return command.Execute();
            }
            else
            {
                return ("Command Not Found!");
            }
        }
    }
}
