using System;
using Server.Targeting;
using Server.Network;
using Server.Spells;

namespace Server.ACC.CSS.Systems.Aprendiz {
	
	public class EnvenenarSpell : AprendizSpell {
		
		private static SpellInfo m_Info = new SpellInfo(
				"Envenenar", 
				"Envenenar",
				212,
				9041,
				Reagent.SulfurousAsh
		);

		public override SpellCircle Circle { get { return SpellCircle.Second; } }
		public override double RequiredSkill{ get{ return 30.0; } }
		public override double CastDelay{ get{ return 2.0; } }
		public override int RequiredMana   { get{ return 20; } }
		
		public EnvenenarSpell( Mobile caster, Item scroll ) : base( caster, scroll, m_Info ) {
		}
		
		public override void OnCast() {
			Caster.Target = new InternalTarget( this );
		}

		public void Target( Mobile m ) {
			if ( !Caster.CanSee( m ) ) {
				Caster.SendLocalizedMessage( 500237 ); // Target can not be seen.
			}
			else if ( CheckHSequence( m ) )	{
				Mobile source = Caster;

				SpellHelper.Turn( source, m );
				SpellHelper.CheckReflect( (int)this.Circle, ref source, ref m );

                //dano 3d10 + 10
                m.Poison = PoisonImpl.Lesser;

                m.FixedParticles(0x113A, 5, 25, 0, EffectLayer.Head);
                m.PlaySound( 0x1E5 );
			}

			FinishSequence();
		}

		private class InternalTarget : Target {
			private EnvenenarSpell m_Owner;

			public InternalTarget( EnvenenarSpell owner ) : base(12, false, TargetFlags.Harmful ) {
				m_Owner = owner;
			}

			protected override void OnTarget( Mobile from, object o ) {
				if ( o is Mobile ) {
					m_Owner.Target( (Mobile)o );
				}
			}

			protected override void OnTargetFinish( Mobile from ) {
				m_Owner.FinishSequence();
			}
		}
	}
}
