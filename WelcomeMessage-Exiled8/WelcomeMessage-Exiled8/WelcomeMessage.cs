using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PlayerList;

namespace WelcomeMessage_Exiled8
{
    public class WelcomeMessage : Plugin<Config>
    {
        public override void OnEnabled()
        {
            Player.Verified += Player.OnVerified;
            base.OnEnabled();
        }
    }
}
