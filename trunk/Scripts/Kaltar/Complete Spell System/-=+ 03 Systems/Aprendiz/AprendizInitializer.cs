using System;
using Server;

namespace Server.ACC.CSS.Systems.Aprendiz {
    public class FeiticariaInitializer : BaseInitializer {

        public static void Configure()
        {
            Register(typeof(FlechaEnergiaSpell), "Flecha de Energia", "O conjurador lan�a uma flecha de energia em dire��o ao alvo", null, "Mana: 5; Skill: 10", 2244, 9350, School.Feiticaria);
            Register(typeof(FlechaDeGeloSpell), "Flecha de Gelo", "O conjurador lan�a uma flecha de gelo em dire��o ao alvo.", null, "Mana: 5; Skill: 10", 2244, 9350, School.Feiticaria);
            Register(typeof(FlechaDeFogoSpell), "Flecha de Fogo", "O conjurador lan�a uma flecha de fogo em dire��o ao alvo.", null, "Mana: 5; Skill: 10", 2244, 9350, School.Feiticaria);
            Register(typeof(MaosFlamejantesSpell), "M�os Flamejantes", "O conjurador lan�a chamas em todos os inim�gos a sua frente", null, "Mana: 8; Skill: 15", 2282, 9350, School.Feiticaria);
            Register(typeof(ChuvaDeRaiosSpell), "Chuva de Raios", "O conjurador lan�a uma chuva de raios em todos os inimigos ao redor", null, "Mana: 20; Skill: 20", 2288, 9350, School.Feiticaria);
            Register(typeof(ArmaduraArcanaSpell), "Armadura Arcana", "Uma energia m�gica protege o conjurador, consedendo resist�ncia a todos os tipos de dano.", null, "Mana: 20; Skill: 20", 2254, 9350, School.Feiticaria);
            Register(typeof(ManaParaVidaSpell), "Mana para Vida", "O conjurador converte parte da sua mana em pontos de vida.", null, "Mana: 10; Skill: 20", 2243, 9350, School.Feiticaria);

            Register(typeof(VisaoNoturnaSpell), "Vis�o Noturna",
                "O alvo consegue enchergar melhor no escuro.",
                null,
                "Mana: 10; Skill: 5",
                2245, 9350, School.Feiticaria);

            Register(typeof(EmpalarSpell), "Empalar",
                "O conjurador conjura uma armadilha de fincos sobre o alvo.",
                null,
                "Mana: 10; Skill: 5",
                2245, 9350, School.Feiticaria);

            Register(typeof(EnvenenarSpell), "Envenenar",
                "O conjurador envena o alvo.",
                null,
                "Mana: 10; Skill: 5",
                2245, 9350, School.Feiticaria);

            Register(typeof(AtearFogoSpell), "Atear fogo",
                "O conjurador ateia fogo em alguma coisa",
                null,
                "Mana: 10; Skill: 5",
                2245, 9350, School.Feiticaria);

            Register(typeof(CampoDeEnergiaSpell), "Campo de energia",
                "O conjurador ateiaconjura um campo de energia que espalha fagulhas aos inimigos por perto",
                null,
                "Mana: 10; Skill: 5",
                2245, 9350, School.Feiticaria);
            
            
        }
    }
}
