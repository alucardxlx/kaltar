﻿using System;
using System.Collections.Generic;
using System.Text;
using Server;
using Server.ACC.CM;
using Server.Commands;
using Server.Mobiles;

namespace Kaltar.Classes {

    public class ClasseModule : Module {

        #region atributos
        
        //armazena todos os talentos do jogadore
        private classe idClasse;

        #endregion

        #region propriedades

        public classe IdClasse { get { return idClasse; } set { idClasse = value; } }

        #endregion

        #region sobrecarga
        public override string Name() { return "Classe Module"; }

        public ClasseModule(Serial serial)
            : base(serial)
        {
            
        }

        public override void Append(Module mod, bool negatively)
        {

        }

        #endregion

        #region serialização

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);			//verso		

            writer.Write((int)idClasse);	//classe

            Console.WriteLine( "Serializando classe de id: {0}", idClasse);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int versao = reader.ReadInt();

            idClasse = (classe) reader.ReadInt();   //classe
        }
        #endregion
    }
        
}
