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
        public override Version Version => new Version(2, 2, 2);

        public static wzm_plugin Singleton { get; private set; }

        private Handlers.Player player;
        private Handlers.Server server;
        


        public override void OnEnabled()
        {
            Singleton = this;
            //RegisterEvents();

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Singleton = null;
            //UnregisterEvents();
            base.OnDisabled();
        }

        public void RegisterEvents()
        {
            player = new Handlers.Player();
            server = new Handlers.Server();

            Server.RoundStarted += server.OnRoundStarted;
        }

        public void UnregisterEvents()
        {
            player = null;
            server = null;

            Server.RoundStarted -= server.OnRoundStarted;
        }
    }
}
