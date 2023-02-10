using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using Exiled.API.Enums;
using Exiled.API.Interfaces;



using Server = Exiled.Events.Handlers.Server;
using Player = Exiled.Events.Handlers.Player;

namespace wzm_plugin
{
    public class wzm_plugin : Plugin<Config>
    {
        public override PluginPriority Priority { get; } = PluginPriority.Medium;
        public override string Name => "wzm_plugin";
        public override string Author => "unhappystaek";
        public override Version Version => new Version(1, 1, 0);

        public static wzm_plugin Singleton { get; private set; }
        


        public override void OnEnabled()
        {
            Singleton = this;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Singleton = null;

            base.OnDisabled();
        }
    }
}
