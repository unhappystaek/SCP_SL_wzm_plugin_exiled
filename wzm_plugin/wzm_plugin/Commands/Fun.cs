
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
                Player player = Player.Get(sender);

                player.Role.Set(RoleTypeId.Tutorial);
                player.IsNoclipPermitted = true;
                player.AddItem(ItemType.ParticleDisruptor);
                player.AddItem(ItemType.MicroHID);
                player.TryAddCandy(candyType: InventorySystem.Items.Usables.Scp330.CandyKindID.Pink);
                player.AddItem(ItemType.SCP018);
                player.AddItem(ItemType.SCP268);
                player.IsGodModeEnabled = true;   

                response = "working";
                return true;
            }
            
        }
    }
}
