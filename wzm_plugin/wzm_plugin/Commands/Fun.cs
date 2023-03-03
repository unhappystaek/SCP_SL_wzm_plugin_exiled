
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
    public class Fun : ICommand
    {
        bool x =  true;
        public string Command { get; } = "Fun";

        public string[] Aliases { get; } = {"Fun for admins"};

        public string Description { get; } = "Gives you a funny stuff";

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
                    if (pl == sender)
                    {
                        pl.Role.Set(RoleTypeId.Tutorial);
                        pl.IsNoclipPermitted = true;
                        pl.AddItem(ItemType.ParticleDisruptor);
                        pl.AddItem(ItemType.MicroHID);
                        pl.TryAddCandy(candyType: InventorySystem.Items.Usables.Scp330.CandyKindID.Pink);
                        pl.AddItem(ItemType.SCP018);
                        pl.AddItem(ItemType.SCP268);
                        pl.IsGodModeEnabled = true;
                    }

                    
                response = "working";
                return true;
            }
            
        }
    }
}
