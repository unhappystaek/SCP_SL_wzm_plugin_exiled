using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandSystem;
using Exiled.Events.Commands.Reload;
using RemoteAdmin;

namespace wzm_plugin.Commands
{
    [CommandHandler(typeof(RemoteAdmin))]
    class Blackout_event : ICommand
    {
        public string Command { get; } = "Blackut_event";

        public string[] Aliases { get; } = {"event_bl"};

        public string Description { get; } = "Command starts custom event called blackout - more info on plugin's github";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender player)
            {
                
            }
             else
        }
    }
}
