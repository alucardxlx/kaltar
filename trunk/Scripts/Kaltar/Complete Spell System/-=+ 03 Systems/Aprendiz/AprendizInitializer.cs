using System;
using Server;

namespace Server.ACC.CSS.Systems.Aprendiz {
	public class AprendizInitializer : BaseInitializer {
		
		public static void Configure() {
			Register( typeof( FlechaMagicaSpell ),  "Flecha M�gica", "O conjurador lan�a uma flecha m�gica em dire��o ao alvo", null, "Mana: 10; Skill: 10", 2295,  3500, School.Aprendiz );
			Register( typeof( MaosFlamejantesSpell ),  "Ma�s Flamejantes", "O conjurador lan�a chamas em todos os inim�gos a sua frente", null, "Mana: 8; Skill: 15", 2295,  3500, School.Aprendiz );
		}
	}
}
