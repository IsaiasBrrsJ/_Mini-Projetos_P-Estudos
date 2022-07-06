using System;
using System.Collections.Generic;
using System.Text;

namespace JokenpoReaplicando
{
     class Game
    {   
        public string jogadaMaquina { get; private set; }
        public string jogadaUser { get; private set; }
        internal enum Resultado
        {
            Ganhar, Perder, Empatar
        }
        internal enum Opcoes
        {
            Pedra, Papel, Tesoura
        }

        public Resultado jogadas(int jogador)
        {
            var pc = JogadaDaMaquina();

            if (jogador == 1)
            { //converter a escolha do jogador pro enum;
                jogador = 0;
                jogadaUser = "Pedra";
            }
            else if (jogador == 2)
            {
                jogador = 1;
                jogadaUser = "Papel";
            }
            else
            {
                jogadaUser = "Tesoura";
                jogador = 2;
            }



                if (jogador == pc)
            {
                return Resultado.Empatar;
            }
            else if ((jogador == (int)Opcoes.Pedra && pc == (int)Opcoes.Tesoura) || (jogador == (int)Opcoes.Tesoura && pc == (int)Opcoes.Papel) ||
                (jogador ==(int)Opcoes.Papel && pc ==(int)Opcoes.Pedra))
            {
                return Resultado.Ganhar;
            }
            else
            {
                return Resultado.Perder;
            }
        }

        private int JogadaDaMaquina()
        {
            var pc = DateTime.Now.Millisecond;

            if(pc < 333)
            {
                jogadaMaquina = "Pedra";
                return 0;
            }
            else if(pc > 333 && pc < 667)
            {
                jogadaMaquina = "Papel";
                return 1;
            }
            else
            {
                jogadaMaquina = "Tesoura";
                return 2;
            }

        }
    }
}
