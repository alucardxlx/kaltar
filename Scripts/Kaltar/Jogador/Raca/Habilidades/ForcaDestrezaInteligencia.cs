using System;
using Server;
using Server.Mobiles;
using Kaltar.Classes;
using Kaltar.Habilidades;

namespace Kaltar.Raca {

    public sealed class ForcaDestrezaInteligencia : HabilidadeRacial {

        private static ForcaDestrezaInteligencia instance = new ForcaDestrezaInteligencia();
        public static ForcaDestrezaInteligencia Instance
        {
            get { return instance; }
        }

        private ForcaDestrezaInteligencia()
        {
            id = (int)IdHabilidadeRacial.forcaDestrezaInteligencia;
            nome = "For�a Destreza e Inteligencia";
            descricao = "Voc� possui mais for�a, destreza e intelig�ncia.";
            preRequisito = "Ra�a Humano";
            nivelMaximo = 2;
        }

        public override bool PossuiPreRequisitos(Jogador jogador)
        {
            return jogador.getSistemaRaca().getRaca() is Humano;
        }

        /*
         * Bonus que a habilidade da para a for�a.
         */
        public override int forcaBonus(HabilidadeNode node)
        {
            return node.Nivel;
        }

        /*
         * Bonus que a habilidade da para a destreza.
         */
        public override int destrezaBonus(HabilidadeNode node)
        {
            return node.Nivel;
        }

        /*
         * Bonus que a habilidade da para a intelig�ncia.
         */
        public override int inteligenciaBonus(HabilidadeNode node)
        {
            return node.Nivel;
        }

        public override void aplicar(Jogador jogador, HabilidadeNode node, bool primeiraVez)
        {
            int ponto = primeiraVez ? node.Nivel : node.Nivel - 1;

            jogador.RawStr += ponto;
            jogador.RawDex += ponto;
            jogador.RawInt += ponto;
        }
    }
}
