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
using Exiled.API.Features.Pickups;

namespace wzm_plugin.Commands
{
    [CommandHandler(typeof(CommandHandler))]
    public class Blackout_event : ICommand
    {
        bool x =  true;
        public string Command { get; } = "Blackut_event";

        public string[] Aliases { get; } = {"event_bl"};

        public string Description { get; } = "Command starts custom event called blackout - more info on plugin's github";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if ( x != x ) 
            {
                response = "No perms";
                return false;
            }
            else
            {
                Map.TurnOffAllLights(duration:(9999999999), zoneTypes:ZoneType.Unspecified);
                Cassie.Message(message:("Facility generators malfunction detected . Please use your light source .\r\n SCP 173 status - contained .\r\n SCP 106 status - contained .\r\n SCP 096 status - contained .\r\n SCP 939 status - unknown .\r\n SCP 049 status - contained .\r\n SCP 079 status - contained ."), isHeld: true, isNoisy: true, isSubtitles: true);
                
                response = "ligma";
                return true;
            }
            
        }
    }
}
