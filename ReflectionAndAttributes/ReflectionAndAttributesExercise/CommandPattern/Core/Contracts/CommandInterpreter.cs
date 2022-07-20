using CommandPattern.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CommandPattern.Core.Contracts
{
    public class CommandInterpreter : ICommandInterpreter
    {

        public string Read(string args)
        {
            var inputInfo = args.Split();
            var command = inputInfo[0] + "Command";
            var parameters = inputInfo.Skip(1).ToArray();

            Type type = Assembly.GetCallingAssembly().GetTypes().Where(t => t.Name == command).FirstOrDefault();

            if (type == null)
            {
                throw new InvalidOperationException("Invalid command");
            }

            ICommand cmd = (ICommand)Activator.CreateInstance(type);
            var result = cmd.Execute(parameters);

            return result;          
        }
    }
}
