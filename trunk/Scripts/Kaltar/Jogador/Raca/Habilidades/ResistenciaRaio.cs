using System;
using Server;
using Server.Mobiles;
using Kaltar.Classes;
using Kaltar.Habilidades;

namespace Kaltar.Raca {
	
	public sealed class ResistenciaRaio : HabilidadeRacial {
		
		private static ResistenciaRaio instance = new ResistenciaRaio();
		public static ResistenciaRaio Instance {
			get {return instance;}
		}

        private ResistenciaRaio()
        {
            id = (int)IdHabilidadeRacial.resistenciaRaio;
            nome = "Resist�ncia Energia";
            descricao = "Voc� � mais resistente a energia.";
            preRequisito = "Ra�a Elfo Negro";
            nivelMaximo = 2;
		}

        public override bool PossuiPreRequisitos(Jogador jogador)
        {
            return jogador.getSistemaRaca().getRaca() is ElfoNegro;
		}


        /*
         * Bonus que a habilidade da no tipo de resist�ncia.
         */
        public override int resistenciaBonus(HabilidadeNode node, ResistanceType type)
        {
            if (ResistanceType.Energy.Equals(type))
            {
                return node.Nivel * 5;
            }
            return 0;
        }

        public override void aplicar(Jogador jogador, HabilidadeNode node, bool primeiraVez)
        {
            jogador.UpdateResistances();
        }
	}
}
