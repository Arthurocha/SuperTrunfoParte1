using SuperTrunfo.carta;
using System.Drawing.Text;
using static System.Net.Mime.MediaTypeNames;

namespace SuperTrunfo
{
    public partial class Form1 : Form
    {
        private List<Carta> cartas;
        private Jogador jogador1;
        private Jogador jogador2;
        public Form1()
        {
            InitializeComponent();
            GerarCartas();
            jogador1 = new Jogador();
            jogador2 = new Jogador();
            SortearCartas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void GerarCartas()
        {
            cartas = new List<Carta>()
            {
                new Carta()
                {
                    Nome = "Seiya de Pegaso",
                    Ataque = 80,
                    Defesa = 60,
                    Magia = 90
                },
                new Carta()
                {
                    Nome = "Bulbasauro",
                    Ataque = 70,
                    Defesa = 65,
                    Magia = 85
                },
                new Carta()
                {
                    Nome = "Lord Dath Vader",
                    Ataque = 88,
                    Defesa = 62,
                    Magia = 90
                },
                new Carta()
                {
                    Nome = "Bob Esponja",
                    Ataque = 82,
                    Defesa = 75,
                    Magia = 0
                }
            };
        }

        private void SortearCartas()
        {
            int numeroAleatorio = (int)new Random().NextInt64(0, cartas.Count);
            jogador1.cartas = new List<Carta>();
            jogador2.cartas = new List<Carta>();
            for (int i = 0; i < 2; i++)
            {
                jogador1.cartas.Add(cartas[numeroAleatorio]);
                cartas.RemoveAt(numeroAleatorio);
                numeroAleatorio = (int)new Random().NextInt64(0, cartas.Count);
                jogador2.cartas.Add(cartas[numeroAleatorio]);
                cartas.RemoveAt(numeroAleatorio);
                numeroAleatorio = (int)new Random().NextInt64(0, cartas.Count);
            }
        }

        private void BtnDistribuirCartas_Click(object sender, EventArgs e)
        {
            GerarCartas();
            SortearCartas();
            LstCartasJogador1.Items.Clear();
            LstCartasJogador2.Items.Clear();
            ExibirCartaJogador1();
            LblTotalCartasJogador1.Text = jogador1.cartas.Count.ToString();
            LblTotalCartasJogador2.Text = jogador2.cartas.Count.ToString();
            BtnDesafiar.Enabled = true;
        }

        private void BtnDesafiar_Click(object sender, EventArgs e)
        {
            if (RdoAtaque.Checked)
            {
                if (jogador1.cartas[0].Ataque > jogador2.cartas[0].Ataque)
                    jogador1.VencedorRodada = true;
                else
                    jogador2.VencedorRodada = true;
            }
            if (RdoDefesa.Checked)
            {
                if (jogador1.cartas[0].Defesa > jogador2.cartas[0].Defesa)
                    jogador1.VencedorRodada = true;
                else
                    jogador2.VencedorRodada = true; ;
            }
            if (RdoMagia.Checked)
            {
                if (jogador1.cartas[0].Magia > jogador2.cartas[0].Magia)
                    jogador1.VencedorRodada = true;
                else
                    jogador2.VencedorRodada = true;
            }
            FecharRodada();
        }

        private void BtnNovaRodada_Click(object sender, EventArgs e)
        {
            ExibirCartaJogador1();
            LstCartasJogador2.Items.Clear();
            BtnNovaRodada.Enabled = false;
            BtnDesafiar.Enabled = true;
        }

        private void ExibirCartaJogador1()
        {
            LstCartasJogador1.Items.Clear();
            LstCartasJogador1.Items.Add(jogador1.cartas[0].Nome);
            LstCartasJogador1.Items.Add("Ataque: " + jogador1.cartas[0].Ataque);
            LstCartasJogador1.Items.Add("Defesa: " + jogador1.cartas[0].Defesa);
            LstCartasJogador1.Items.Add("Magia: " + jogador1.cartas[0].Magia);
            LblTotalCartasJogador1.Text = jogador1.cartas.Count.ToString();
        }

        private void ExibirCartaJogador2()
        {
            LstCartasJogador2.Items.Clear();
            LstCartasJogador2.Items.Add(jogador2.cartas[0].Nome);
            LstCartasJogador2.Items.Add("Ataque: " + jogador2.cartas[0].Ataque);
            LstCartasJogador2.Items.Add("Defesa: " + jogador2.cartas[0].Defesa);
            LstCartasJogador2.Items.Add("Magia: " + jogador2.cartas[0].Magia);
            LblTotalCartasJogador2.Text = jogador2.cartas.Count.ToString();
        }

        private void FecharRodada()
        {
            ExibirCartaJogador2();
            AtualizarTotalCartas();
            jogador1.VencedorRodada = jogador2.VencedorRodada = false;
            BtnDesafiar.Enabled = false;
            BtnNovaRodada.Enabled = true;
            if (jogador1.cartas.Count == 0 || jogador2.cartas.Count == 0)
            {
                string vencedor = (jogador1.cartas.Count == 0 ? "Jogador 2" : "Jogador 1");
                BtnNovaRodada.Enabled = false;
                MessageBox.Show("O vencedor foi " + vencedor, "Fim de Jogo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AtualizarTotalCartas()
        {
            if (jogador1.VencedorRodada)
            {
                jogador1.cartas.Insert(jogador1.cartas.Count - 1, jogador2.cartas[0]);
                jogador2.cartas.RemoveAt(0);
                jogador1.cartas.Insert(jogador1.cartas.Count - 1, jogador1.cartas[0]);
                jogador1.cartas.RemoveAt(0);
            }
            else
            {
                jogador2.cartas.Insert(jogador2.cartas.Count - 1, jogador1.cartas[0]);
                jogador1.cartas.RemoveAt(0);
                jogador2.cartas.Insert(jogador2.cartas.Count - 1, jogador2.cartas[0]);
                jogador2.cartas.RemoveAt(0);
            }
            LblTotalCartasJogador1.Text = jogador1.cartas.Count.ToString();
            LblTotalCartasJogador2.Text = jogador2.cartas.Count.ToString();
        }


    }
}
