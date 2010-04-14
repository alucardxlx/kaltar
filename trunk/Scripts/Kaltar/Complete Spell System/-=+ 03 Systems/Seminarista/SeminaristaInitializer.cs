using System;
using Server;

namespace Server.ACC.CSS.Systems.Cleric {
	public class SeminaristaInitializer : BaseInitializer {
		
		public static void Configure() {
			Register( typeof( ToqueDaCuraSpell ),  "Toque da Cura", "O conjurador toca a pessoa curando seus ferimentos.", null, "Mana: 5; Skill: 0; Tithing: 5", 2295,  3500, School.Seminarista );
			Register( typeof( ToqueDeRegeneracaoSpell ),  "Toque da Regenera��o", "O conjurador toca a pessoa consedendo a habilidade de regenera��o.", null, "Mana: 15; Skill: 20; Tithing: 20", 2295,  3500, School.Seminarista );
			Register( typeof( ToqueDaResistenciaSpell ),  "Toque da Resist�ncia", "O conjurador toca o alvo consedendo resistencia aos elementos.", null, "Mana: 10; Skill: 20; Tithing: 20", 2295,  3500, School.Seminarista );
			Register( typeof( GloboDeLuzSpell ),  "Globo de Luz", "O conjurador cria um globo de luz para clariar sua vis�o em dias escuros.", null, "Mana: 20; Skill: 10; Tithing: 10", 2295,  3500, School.Seminarista );
			Register( typeof( RefeicaoSpell ),  "Refei��o", "O conjurador cria uma refei��o para se alimentar.", null, "Mana: 20; Skill: 10; Tithing: 5", 2295,  3500, School.Seminarista );
			
		}
	}
}
