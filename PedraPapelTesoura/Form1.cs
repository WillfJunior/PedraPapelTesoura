using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedraPapelTesoura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void verificar()
        {
            
                if (jg == 3)
                {
                    lblResultado.Text = "Fim de jogo, jogador venceu!";
                lblResultado.ForeColor = Color.Green;
                btnPapel.Enabled = false;
                btnPedra.Enabled = false;
                btnTesoura.Enabled = false;
                btnJogar.Enabled = true;
                    
                }
                if (pc == 3)
                {
                    lblResultado.Text = "Fim de jogo, computador venceu!";
                lblResultado.ForeColor = Color.Red;
                btnPapel.Enabled = false;
                btnPedra.Enabled = false;
                btnTesoura.Enabled = false;
                btnJogar.Enabled = true;

            }
            
            
        }
        int jg = 0;
        int pc = 0;
        
        private void btnPedra_Click(object sender, EventArgs e)
        {
            ptbComputador.BackgroundImage = null;
            ptbJogador.BackgroundImage = null;
            ptbJogador.BackgroundImage = Properties.Resources.Pedratw1;
            Random rnd = new Random();
            int num;
            num = rnd.Next(1, 4);
            switch (num)
            {
                case 1:
                    ptbComputador.BackgroundImage = Properties.Resources.Pedratw1;
                    break;
                case 2:
                    ptbComputador.BackgroundImage = Properties.Resources.Papeltw1;
                    break;
                case 3:
                    ptbComputador.BackgroundImage = Properties.Resources.tesoura;
                    break;
                default:
                    ptbComputador.BackgroundImage = null;
                    break;
            }
            if (num == 1)
            {
                lblResultado.Text = "Duas Pedras.... Empate!";
                lblResultado.ForeColor = Color.Blue;
            }
            else if (num == 2)
            {
                pc += 1;
                lblPC.Text = pc.ToString();
                lblResultado.Text = "Pedra contra Papel... Papel vence!";
                lblResultado.ForeColor = Color.Red;
            }
            else
            {
                jg += 1;
                lblJG.Text = jg.ToString();
                lblResultado.Text = "Pedra contra Tesoura... Pedra Vence";
                lblResultado.ForeColor = Color.Green;
            }
            verificar();
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            ptbComputador.BackgroundImage = null;
            ptbJogador.BackgroundImage = null;
            ptbJogador.BackgroundImage = Properties.Resources.Papeltw1;
            Random rnd = new Random();
            int num;
            num = rnd.Next(1, 4);
            switch (num)
            {
                case 1:
                    ptbComputador.BackgroundImage = Properties.Resources.Pedratw1;
                    break;
                case 2:
                    ptbComputador.BackgroundImage = Properties.Resources.Papeltw1;
                    break;
                case 3:
                    ptbComputador.BackgroundImage = Properties.Resources.tesoura;
                    break;
                default:
                    ptbComputador.BackgroundImage = null;
                    break;
            }
            if (num == 1)
            {
                jg += 1;
                lblJG.Text = jg.ToString();
                lblResultado.Text = "Papel contra Pedra... Papel vence!";
                lblResultado.ForeColor = Color.Green;
            }
            else if (num == 2)
            {
                lblResultado.Text = "Dois Papeis... Empate!";
                lblResultado.ForeColor = Color.Blue;
            }
            else
            {
                pc += 1;
                lblPC.Text = pc.ToString();
                lblResultado.Text = "Papel contra Tesoura... Tesoura vence!";
                lblResultado.ForeColor = Color.Red;
            }
            verificar();

        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            ptbComputador.BackgroundImage = null;
            ptbJogador.BackgroundImage = null;
            ptbJogador.BackgroundImage = Properties.Resources.tesoura;
            Random rnd = new Random();
            int num;
            
            num = rnd.Next(1, 4);
            switch (num)
            {
                case 1:
                    ptbComputador.BackgroundImage = Properties.Resources.Pedratw1;
                    break;
                case 2:
                    ptbComputador.BackgroundImage = Properties.Resources.Papeltw1;
                    break;
                case 3:
                    ptbComputador.BackgroundImage = Properties.Resources.tesoura;
                    break;
                default:
                    ptbComputador.BackgroundImage = null;
                    break;
            }
            if (num == 1)
            {
                pc += 1;
                lblPC.Text = pc.ToString();
                lblResultado.Text = "Tesoura contra Pedra... Pedra vence!";
                lblResultado.ForeColor = Color.Red;
            }
            else if (num == 2)
            {
                jg += 1;
                lblJG.Text = jg.ToString();
                lblResultado.Text = "Tesoura contra Papel... Tesoura vence!";
                lblResultado.ForeColor = Color.Green;
            }
            else
            {
                lblResultado.Text = "Duas Tesouras... Empate!";
                lblResultado.ForeColor = Color.Blue;
            }
            verificar();

        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            jg = 0;
            pc = 0;
            lblJG.Text = "0";
            lblPC.Text = "0";
            lblResultado.Text = "";
            btnTesoura.Enabled = true;
            btnPedra.Enabled = true;
            btnPapel.Enabled = true;
            btnJogar.Enabled = false;
            ptbComputador.BackgroundImage = null;
            ptbJogador.BackgroundImage = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnJogar.Enabled = false;
        }
    }
}
