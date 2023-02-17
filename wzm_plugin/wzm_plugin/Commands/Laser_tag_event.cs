
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
    public class Laser_tag_event : ICommand
    {
        bool x =  true;
        public string Command { get; } = "Laser_tag_event";

        public string[] Aliases { get; } = {"event_lt"};

        public string Description { get; } = "Command starts custom event called laser tag - more info on plugin's github";

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
                    if (pl.IsScp)
                    {
                        pl.Role.Set(RoleTypeId.NtfCaptain);
                    }

                foreach (Player pl in (Player.List))
                    if (pl.Role == RoleTypeId.ClassD)
                    {
                        pl.Role.Set(RoleTypeId.NtfCaptain);
                    }

                foreach (Player pl in (Player.List))
                    if (pl.Role == RoleTypeId.Scientist)
                    {
                        pl.Role.Set(RoleTypeId.ChaosRepressor);
                    }

                foreach (Player pl in (Player.List))
                    if (pl.Role == RoleTypeId.FacilityGuard)
                    {
                        
                        pl.Role.Set(RoleTypeId.ChaosRepressor);
                    }

                foreach (Player pl in (Player.List))
                    pl.ClearInventory();

                foreach (Player pl in (Player.List))
                    pl.AddItem(ItemType.ParticleDisruptor);


                Map.Broadcast(message: "laser tag round has started", duration: 10);

                Warhead.Detonate();

                response = "working";
                return true;
            }
            
        }
    }
}
