
using System;
using CommandSystem;
using Exiled.API.Features;
using Exiled.Permissions.Extensions;


namespace wzm_plugin.Commands
{

    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class Dowod : ICommand
    {
        bool x =  true;
        public string Command { get; } = "dowod";

        public string[] Aliases { get; } = {"dowod"};

        public string Description { get; } = "i want free grade";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (!sender.CheckPermission("exiled.wzm_plugin")) 
            {
                response = "No perms";
                return false;
            }
            else
            {
                Map.Broadcast(message: "working...", duration: 10);

                response = "working";
                return true;
            }
            
        }
    }
}
