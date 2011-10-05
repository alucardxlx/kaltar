using System;
using Server.Network;

using Kaltar.Classes;
using Kaltar.Talentos;
using Kaltar.Morte;
using Kaltar.Modulo;
using Server.ACC.CM;
using Server.Mobiles;

namespace Server.Misc
{
	public class LoginStats
	{
		public static void Initialize()
		{
			// Register our event handler
			EventSink.Login += new LoginEventHandler( EventSink_Login );
		}

		private static void EventSink_Login( LoginEventArgs args )
		{
			int userCount = NetState.Instances.Count;
			int itemCount = World.Items.Count;
			int mobileCount = World.Mobiles.Count;

			Mobile m = args.Mobile;

			m.SendMessage( "Welcome, {0}! There {1} currently {2} user{3} online, with {4} item{5} and {6} mobile{7} in the world.",
				args.Mobile.Name,
				userCount == 1 ? "is" : "are",
				userCount, userCount == 1 ? "" : "s",
				itemCount, itemCount == 1 ? "" : "s",
				mobileCount, mobileCount == 1 ? "" : "s" );

            //registra os modulos que todo jogador deve possuir
            RegistroModule.registrarModuleJogador((Jogador)m);
		}
	}
}