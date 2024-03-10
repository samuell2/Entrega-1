using JogoVelha.App;

namespace JogoVelha.Tests
{
    public class JogoVelhaTests
    {
        [Fact(DisplayName = "Jogador X vencedor")]
        [Trait("Categoria", "Jogo Da Velha - X Vencedor")]
        public void JogoVelha_JogadorXvencePartida()
        {
            //Arrange
            var jogoVelha = new JogoVelhaApp();

            //Act
            jogoVelha.IniciarJogo();
            bool c1 = cenario1();
            jogoVelha.IniciarJogo();
            bool c2 = cenario2();
            jogoVelha.IniciarJogo();
            bool c3 = cenario3();
            jogoVelha.IniciarJogo();
            bool c4 = cenario4();
            jogoVelha.IniciarJogo();
            bool c5 = cenario5();
            jogoVelha.IniciarJogo();
            bool c6 = cenario6();
            jogoVelha.IniciarJogo();
            bool c7 = cenario7();
            jogoVelha.IniciarJogo();
            bool c8 = cenario8();

            bool cenario1()
            {
                jogoVelha.RealizarJogada(jogoVelha.JogadorX, 0, 0);
                jogoVelha.RealizarJogada(jogoVelha.JogadorO, 1, 0);

                jogoVelha.RealizarJogada(jogoVelha.JogadorX, 0, 1);
                jogoVelha.RealizarJogada(jogoVelha.JogadorO, 1, 1);

                jogoVelha.RealizarJogada(jogoVelha.JogadorX, 0, 2);

                bool X = jogoVelha.ChecarVitoria(jogoVelha.Tabuleiro, Simbolo.X);
                bool O = jogoVelha.ChecarVitoria(jogoVelha.Tabuleiro, Simbolo.O);

                if (X & !O) return true;
                else return false;
            }
            bool cenario2()
            {
                jogoVelha.RealizarJogada(jogoVelha.JogadorX, 1, 0);
                jogoVelha.RealizarJogada(jogoVelha.JogadorO, 0, 0);

                jogoVelha.RealizarJogada(jogoVelha.JogadorX, 1, 1);
                jogoVelha.RealizarJogada(jogoVelha.JogadorO, 0, 1);

                jogoVelha.RealizarJogada(jogoVelha.JogadorX, 1, 2);

                bool X = jogoVelha.ChecarVitoria(jogoVelha.Tabuleiro, Simbolo.X);
                bool O = jogoVelha.ChecarVitoria(jogoVelha.Tabuleiro, Simbolo.O);

                if (X & !O) return true;
                else return false;
            }
            bool cenario3()
            {
                jogoVelha.RealizarJogada(jogoVelha.JogadorX, 2, 0);
                jogoVelha.RealizarJogada(jogoVelha.JogadorO, 0, 0);

                jogoVelha.RealizarJogada(jogoVelha.JogadorX, 2, 1);
                jogoVelha.RealizarJogada(jogoVelha.JogadorO, 0, 1);

                jogoVelha.RealizarJogada(jogoVelha.JogadorX, 2, 2);

                bool X = jogoVelha.ChecarVitoria(jogoVelha.Tabuleiro, Simbolo.X);
                bool O = jogoVelha.ChecarVitoria(jogoVelha.Tabuleiro, Simbolo.O);

                if (X & !O) return true;
                else return false;
            }
            bool cenario4()
            {
                jogoVelha.RealizarJogada(jogoVelha.JogadorX, 0, 0);
                jogoVelha.RealizarJogada(jogoVelha.JogadorO, 0, 1);

                jogoVelha.RealizarJogada(jogoVelha.JogadorX, 1, 0);
                jogoVelha.RealizarJogada(jogoVelha.JogadorO, 1, 1);

                jogoVelha.RealizarJogada(jogoVelha.JogadorX, 2, 0);

                bool X = jogoVelha.ChecarVitoria(jogoVelha.Tabuleiro, Simbolo.X);
                bool O = jogoVelha.ChecarVitoria(jogoVelha.Tabuleiro, Simbolo.O);

                if (X & !O) return true;
                else return false;
            }
            bool cenario5()
            {
                jogoVelha.RealizarJogada(jogoVelha.JogadorX, 0, 1);
                jogoVelha.RealizarJogada(jogoVelha.JogadorO, 0, 0);

                jogoVelha.RealizarJogada(jogoVelha.JogadorX, 1, 1);
                jogoVelha.RealizarJogada(jogoVelha.JogadorO, 1, 0);

                jogoVelha.RealizarJogada(jogoVelha.JogadorX, 2, 1);

                bool X = jogoVelha.ChecarVitoria(jogoVelha.Tabuleiro, Simbolo.X);
                bool O = jogoVelha.ChecarVitoria(jogoVelha.Tabuleiro, Simbolo.O);

                if (X & !O) return true;
                else return false;
            }
            bool cenario6()
            {
                jogoVelha.RealizarJogada(jogoVelha.JogadorX, 0, 2);
                jogoVelha.RealizarJogada(jogoVelha.JogadorO, 0, 0);

                jogoVelha.RealizarJogada(jogoVelha.JogadorX, 1, 2);
                jogoVelha.RealizarJogada(jogoVelha.JogadorO, 1, 0);

                jogoVelha.RealizarJogada(jogoVelha.JogadorX, 2, 2);

                bool X = jogoVelha.ChecarVitoria(jogoVelha.Tabuleiro, Simbolo.X);
                bool O = jogoVelha.ChecarVitoria(jogoVelha.Tabuleiro, Simbolo.O);

                if (X & !O) return true;
                else return false;
            }
            bool cenario7()
            {
                jogoVelha.RealizarJogada(jogoVelha.JogadorX, 0, 0);
                jogoVelha.RealizarJogada(jogoVelha.JogadorO, 0, 1);

                jogoVelha.RealizarJogada(jogoVelha.JogadorX, 1, 1);
                jogoVelha.RealizarJogada(jogoVelha.JogadorO, 1, 0);

                jogoVelha.RealizarJogada(jogoVelha.JogadorX, 2, 2);

                bool X = jogoVelha.ChecarVitoria(jogoVelha.Tabuleiro, Simbolo.X);
                bool O = jogoVelha.ChecarVitoria(jogoVelha.Tabuleiro, Simbolo.O);

                if (X & !O) return true;
                else return false;
            }
            bool cenario8()
            {
                jogoVelha.RealizarJogada(jogoVelha.JogadorX, 0, 2);
                jogoVelha.RealizarJogada(jogoVelha.JogadorO, 0, 1);

                jogoVelha.RealizarJogada(jogoVelha.JogadorX, 1, 1);
                jogoVelha.RealizarJogada(jogoVelha.JogadorO, 1, 0);

                jogoVelha.RealizarJogada(jogoVelha.JogadorX, 2, 0);

                bool X = jogoVelha.ChecarVitoria(jogoVelha.Tabuleiro, Simbolo.X);
                bool O = jogoVelha.ChecarVitoria(jogoVelha.Tabuleiro, Simbolo.O);

                if (X & !O) return true;
                else return false;
            }

            Assert.True(c1);
            Assert.True(c2);
            Assert.True(c3);
            Assert.True(c4);
            Assert.True(c5);
            Assert.True(c6);
            Assert.True(c7);
            Assert.True(c8);
        }

        [Fact(DisplayName = "Empate")]
        [Trait("Categoria", "Jogo Da Velha - Empate")]
        public void JogoVelha_PartidaEmpatada()
        {
            var jogoVelha = new JogoVelhaApp();
            Simbolo X = Simbolo.X;
            Simbolo O = Simbolo.O;
        }
    }
}