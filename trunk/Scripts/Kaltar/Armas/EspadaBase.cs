using System;
using Server;
using Server.Items;
using Server.Targets;

namespace Kaltar.Armas
{
	/// <summary>
	/// Description of EspadaBase.
	/// </summary>
	public abstract class EspadaBase : Arma {

		#region kaltar
		public override CategoriaArma categoria { get{return CategoriaArma.espada;} }
		#endregion		
		
		public override SkillName DefSkill{ get{ return SkillName.Swords; } }
		public override WeaponType DefType{ get{ return WeaponType.Slashing; } }
		public override WeaponAnimation DefAnimation{ get{ return WeaponAnimation.Slash1H; } }		

		public EspadaBase( int itemID ) : base( itemID ) {
		}
		
		public EspadaBase( Serial serial ) : base( serial ) {
			
		}

		public override void Serialize( GenericWriter writer ) {
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader ) {
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}

		public override void OnDoubleClick( Mobile from )
		{
			from.SendLocalizedMessage( 1010018 ); // What do you want to use this item on?
			from.Target = new BladedItemTarget( this );
		}
	}
}
