using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeMessage_Exiled8.Events
{
    internal class PlayerHandler : Plugin<Config>
    {
        public static void OnVerified(VerifiedEventArgs ev)
        {
            ev.Player.Broadcast(5, "Welkum to hell " + ev.Player.DisplayNickname);
        }
    }
}
