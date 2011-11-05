using System;
using Server;
using Server.Mobiles;
using Kaltar.Classes;

namespace Kaltar.Raca {
	
	public sealed class SkillCapTrabalho : HabilidadeRacial {
		
		private static SkillCapTrabalho instance = new SkillCapTrabalho();
		public static SkillCapTrabalho Instance {
			get {return instance;}
		}

        private SkillCapTrabalho()
        {
            id = (int)IdHabilidadeRacial.skillCapTrabalho;
            nome = "Habilidade de trabalho";
            descricao = "Voc� consegue aprender mais per�cias de trabalho do que as outras pessoas.";
            preRequisito = "Ra�a Humano";
            nivelMaximo = 5;
		}

        public override bool PossuiPreRequisitos(Jogador jogador)
        {
            return jogador.getSistemaRaca().getRaca() is Humano;
		}
	}
}
