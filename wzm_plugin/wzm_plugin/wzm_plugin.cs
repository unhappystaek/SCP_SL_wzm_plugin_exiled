using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using Exiled.API.Enums

using Server = Exiled.Events.Handlers.Server;
using Player = Exiled.Events.Handlers.Player;

namespace wzm_plugin
{
    public class wzm_plugin : Plugin<Config>
    {
        public override PluginPriority Priority { get; } = PluginPriority.Medium;

    }

    public override void OnEnable()
    {

    }

    public override void OnDisable()
    {

    }
}
