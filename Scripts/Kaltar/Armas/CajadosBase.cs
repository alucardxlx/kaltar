using System;
using Server;
using Server.Items;

namespace Kaltar.Armas
{
	/// <summary>
	/// Description of CajadoBase.
	/// </summary>
	public abstract class CajadoBase : Arma {
		
		#region kaltar
		public override CategoriaArma categoria { get{return CategoriaArma.amasso;} }
		#endregion
		
		public override int DefHitSound{ get{ return 0x233; } }
		public override int DefMissSound{ get{ return 0x239; } }

		public override SkillName DefSkill{ get{ return SkillName.Macing; } }
		public override WeaponType DefType{ get{ return WeaponType.Staff; } }
		public override WeaponAnimation DefAnimation{ get{ return WeaponAnimation.Bash2H; } }

		public CajadoBase( int itemID ) : base( itemID ) {
		}

		public CajadoBase( Serial serial ) : base( serial ) {
		}

		public override void Serialize( GenericWriter writer ) {
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader ) {
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}
