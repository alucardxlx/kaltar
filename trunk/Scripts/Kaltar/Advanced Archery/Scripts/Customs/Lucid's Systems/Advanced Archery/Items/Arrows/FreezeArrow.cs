 /*
    _________________________________
 -=(_)_______________________________)=-
   /   .   .   . ____  . ___      _/
  /~ /    /   / /     / /   )2006 /
 (~ (____(___/ (____ / /___/     (
  \ ----------------------------- \
   \     lucidnagual@gmail.com     \
    \_     ===================      \
     \   -Admin of "The Conjuring"-  \
      \_     ===================     ~\
       )       Advanced Archery        )
      /~    Version [3].0 & Above    _/
    _/_______________________________/
 -=(_)_______________________________)=-

 */
using System;

namespace Server.Items
{
	public class FreezeArrow : Arrow, ICommodity
	{
		string ICommodity.Description
		{
			get
			{
				return String.Format( Amount == 1 ? "{0} freezearrow" : "{0} freezearrows", Amount );
			}
		}

		[Constructable]
		public FreezeArrow() : this( 1 )
		{
		}

		[Constructable]
		public FreezeArrow( int amount ) : base( 0xF3F )
		{
			Stackable = true;
			Name = "Freeze Arrow";
			Hue = 88;
			Weight = 0.1;
			Amount = amount;
		}

		public FreezeArrow( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}
