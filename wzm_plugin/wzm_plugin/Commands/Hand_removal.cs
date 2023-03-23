
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandSystem;
using Exiled.API.Features;
using Exiled.Events.Commands.Reload;
using Exiled.API.Enums;
using Exiled.Permissions.Extensions;
using Exiled.API.Features.Items;
using System.Text.RegularExpressions;
using PlayerRoles;
using RemoteAdmin;
using Exiled.API.Features.Roles;


namespace wzm_plugin.Commands
{

    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class Hand_removal : ICommand
    {
        public string Command { get; } = "Hand_removal";

        public string[] Aliases { get; } = { "rm_hand" };

        public string Description { get; } = "Removes everyone's hands - more info on plugin's github";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (!sender.CheckPermission("exiled.wzm_plugin")) 
            {
                response = "No perms";
                return false;
            }
            else
            {
                
                foreach (Player pl in (Player.List))
                    if (pl.IsScp != true)
                    {
                        pl.EnableEffect(duration: 1, type: EffectType.SeveredHands);
                    }

                response = "working";
                return true;
            }
        }
    }
}
