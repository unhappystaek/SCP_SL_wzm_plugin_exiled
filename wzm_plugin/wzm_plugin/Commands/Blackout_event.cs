
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

namespace wzm_plugin.Commands
{

    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class Blackout_event : ICommand
    {
        bool x =  true;
        public string Command { get; } = "Blackut_event";

        public string[] Aliases { get; } = {"event_bl"};

        public string Description { get; } = "Command starts custom event called blackout - more info on plugin's github";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (!sender.CheckPermission("exiled.wzm_plugin")) 
            {
                response = "No perms";
                return false;
            }
            else
            {
                Map.TurnOffAllLights(duration:(9999999999), zoneTypes:ZoneType.Unspecified);
                Cassie.Message(message: ("Facility generators malfunction detected. Please use your light source. SCP 173 status - contained. SCP 106 status - contained. SCP 096 status - contained. SCP 939 status - unknown. SCP 049 status - contained. SCP 079 status - contained."), isHeld: true, isNoisy: true, isSubtitles: true);
                foreach (Player pl in (Player.List))
                    pl.AddItem(ItemType.Flashlight);

                foreach (Player pl in (Player.List))
                if (pl.IsScp)
                {
                    pl.Role.Set(RoleTypeId.Scp939);
                }


                response = "working";
                return true;
            }
            
        }
    }
}
