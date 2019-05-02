using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProgramarDesligamento
{
    public partial class frmPrincipal : Form
    {
        /* Variaveis globais */
        bool _pausou = false;
        bool _iniciou = false;
        double _tempoInical = 0; /* TEmpo inicialmente programado, em minutos */

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tudMinutos_ValueChanged(object sender, EventArgs e)
        {
            /* Caso o valor do minuto esteja maior que 59,
             * subtrair 60 minutos e adcionar 1 hora */
            if(tudMinutos.Value > 59)
            {
                tudMinutos.Value -= 60;
                tudHoras.Value += 1;
            }

        }

        /* Botão Iniciar Resumir */
        private void btnProgramar_Click(object sender, EventArgs e)
        {
            string metodoDesl = "";
            /* Caso o tempo seja diferente de zero */
            if (tudHoras.Value > 0 || tudMinutos.Value > 0 || (Convert.ToInt32(lblSegundos.Text) > 0))
            {
                /* Ajustando o tempo inical para as notificações */
                if (_iniciou)
                {
                    if (Convert.ToInt32(lblMinutos.Text) < tudMinutos.Value)
                    {
                        _tempoInical = 11;
                    }
                }
                /* Inicia o timer e desativa os componentes de personalização */
                timer1.Start();
                desativaControles();

                if(cmbboxMetodo.Text == "Desligar")
                {
                    metodoDesl = "encerrará";
                }
                else if(cmbboxMetodo.Text == "Reiniciar")
                {
                    metodoDesl = "reiniciará";
                }

                if (!_iniciou)
                {
                    _tempoInical = Convert.ToInt32(tudMinutos.Value) + (Convert.ToInt32(tudHoras.Value) * 60) + (Convert.ToDouble(lblSegundos.Text) / 60);
                    icone.Visible = true;
                    icone.ShowBalloonTip(3000, "Desligamento programado", "Desligamento agendado. O sistema " + metodoDesl + " em " + getTempoRestante() + ".", ToolTipIcon.Info);
                }

                icone.Text = "Programar Desligamento\nTempo restante: " + lblHoras.Text + ":" + lblMinutos.Text + ":" + lblSegundos.Text;

                /* Troca o texto do botão iniciar para resumir */
                if (!_iniciou)
                {
                    _iniciou = true;
                    btnProgramar.Text = "Resumir";
                }

                _pausou = false;
            }
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            /* Para o timer e reativa os componentes de personalização */
            _pausou = true;
            icone.Text = "Programar Desligamento\nTempo restante: " + lblHoras.Text + ":" + lblMinutos.Text + ":" + lblSegundos.Text + "\nPausado";
            timer1.Stop();
            ativaControles();
            btnCancelar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            ativaControles();
            dezMinutosToolStripMenuItem.Visible = false;
            dezMinutosToolStripMenuItem.Enabled = false;
            tudHoras.Value = 0;
            tudMinutos.Value = 0;
            lblSegundos.Text = "00";

            _iniciou = false;
            _pausou = false;
            btnProgramar.Text = "Iniciar";

            if (icone.Visible)
            {
                icone.ShowBalloonTip(3000, "Desligamento cancelado", "O desligamento do sistema foi abortado", ToolTipIcon.Error);
                cmsIcone.Enabled = false;
                icone.Text = "Programar Desligamento\nAbortado";
                timerCancelarEsconderIcone.Start();
            }
        }

        private void frmPrincipal_Resize(object sender, EventArgs e)
        {
        }

        /* Double Click */
        private void icone_Click(object sender, EventArgs e)
        {
            /* Ao clicar no icone de notificação, mostrar a tela e esconder o icone */
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void PausarResumirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_pausou)
            {
                btnProgramar_Click(sender, e);
            }
            else
            {
                btnPausar_Click(sender, e);
            }
        }

        private void CancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCancelar_Click(sender, e);

            if(!this.Visible)
            {
                this.Show();
            }

            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Focus();
            }
            else
            {
                this.Focus();
            }
        }

        private void dezMinutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(lblMinutos.Text);
            int hr = Convert.ToInt32(lblHoras.Text);
            min += 10;

            if(min > 59)
            {
                min -= 60;
                hr += 1;
                lblHoras.Text = hr.ToString("00");
            }

            lblMinutos.Text = min.ToString("00");
            _tempoInical = 11;

            icone.ShowBalloonTip(3000, "Programar Desligamento", "Desligamento adiado em 10 minutos", ToolTipIcon.Info);
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            /* Se o usuario tentar fechar a aplicação e o timer estiver ativo,
             * esconder a tela e mostra o icone de notificação */
            if (timer1.Enabled || _pausou)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int segundos = Convert.ToInt32(lblSegundos.Text);
            int minutos = Convert.ToInt32(lblMinutos.Text);
            int horas = Convert.ToInt32(lblHoras.Text);
            /* Subtrai 1 segundo */
            segundos -= 1;

            /* Se os segundos estiverem abaixo de zero */
            if(segundos < 0)
            {
                /* Define os segundos para 59 */
                segundos = 59;
                lblSegundos.Text = segundos.ToString();

                /* Se os minutos forem maior que 0, subtrair 1 minuto */
                if (minutos > 0)
                {
                    minutos -= 1;
                    lblMinutos.Text = minutos.ToString("00");
                }
                else
                {
                    /* Senão os minutos serão 59 e o programa irá tentar subtrair a hora */
                    minutos = 59;
                    lblMinutos.Text = minutos.ToString("00");

                    /* Caso a hora seja maior que 0, subtrair 1 hora, senão não faz nada */
                    if (horas > 0)
                    {
                        horas -= 1;
                        lblHoras.Text = horas.ToString("00");
                    }
                }
            }
            else
            {
                lblSegundos.Text = segundos.ToString("00");
            }

            /* Verificando se o tempo acabou (com o timer ainda ativo) */
            if(timer1.Enabled
                && horas == 0 && minutos == 0
                && lblSegundos.Text == "00")
            {
                timer1.Stop();
                desligarPC();
                icone.Visible = false;
                btnCancelar_Click(icone, e);
            }

            /* Atualizando o texto do icone */
            icone.Text = "Programar Desligamento\nTempo restante: " + lblHoras.Text + ":" + lblMinutos.Text + ":" + lblSegundos.Text;

            /* Notificações do tempo faltando */
            if(_tempoInical > 10 && horas == 0 && minutos == 10 && segundos == 0)
            {
                icone.ShowBalloonTip(3000, "Sistema prestes a encerrar", "Faltam 10 minutos para o desligamento do sistema.", ToolTipIcon.Warning);
            }

            if (_tempoInical > 5 && horas == 0 && minutos == 5 && segundos == 0)
            {
                icone.ShowBalloonTip(3000, "Sistema prestes a encerrar", "Faltam 5 minutos para o desligamento do sistema.", ToolTipIcon.Warning);
            }

            if (_tempoInical > 1 && horas == 0 && minutos == 1 && segundos == 0)
            {
                icone.ShowBalloonTip(3000, "Sistema prestes a encerrar", "O sistema será encerrado em 1 minuto.", ToolTipIcon.Warning);
            }

            if (horas == 0 && minutos == 0 && segundos == 10)
            {
                icone.ShowBalloonTip(3000, "Sistema quase encerrando", "O sistema será encerrado em 10 segundos.", ToolTipIcon.Warning);
            }
        }

        /* Desativa os controles do Form e ativa o botão de cancelar*/
        private void desativaControles()
        {
            btnProgramar.Enabled = false;

            /* Substituindo os NumericUpDown personalizados por labels para simular 
             uma 'desativação' */
            tudHoras.Visible = false;
            tudHoras.Enabled = false;
            lblHoras.Visible = true;
            tudMinutos.Visible = false;
            tudMinutos.Enabled = false;
            lblMinutos.Visible = true;

            lblHoras.Text = tudHoras.Value.ToString("00");
            lblMinutos.Text = tudMinutos.Value.ToString("00");

            btnCancelar.Enabled = true;
            btnPausar.Enabled = true;

            dezMinutosToolStripMenuItem.Visible = true;
            dezMinutosToolStripMenuItem.Enabled = true;
        }

        /* Ativa os controles e desativa o botão de cancelar */
        private void ativaControles()
        {
            btnProgramar.Enabled = true;

            /* Esondendo as labels e mostrando os NumericUpDown */
            lblHoras.Visible = false;
            tudHoras.Visible = true;
            tudHoras.Enabled = true;
            lblMinutos.Visible = false;
            tudMinutos.Visible = true;
            tudMinutos.Enabled = true;

            tudHoras.Value = Convert.ToInt32(lblHoras.Text);
            tudMinutos.Value = Convert.ToInt32(lblMinutos.Text);

            btnCancelar.Enabled = false;
            btnPausar.Enabled = false;

            dezMinutosToolStripMenuItem.Visible = true;
            dezMinutosToolStripMenuItem.Enabled = true;
        }

        private string getTempoRestante()
        {
            /* variavel que armazena o texto que será exibido na notificação que aparece 
             quando o desligamento é programado */
            string notificacao = "";

            if(tudHoras.Value > 0)
            {
                notificacao += tudHoras.Value.ToString() + " hora";
                if(tudHoras.Value > 1)
                {
                    notificacao += "s";
                }

                if(tudMinutos.Value > 0)
                {
                    notificacao += " e " + tudMinutos.Value.ToString() + " minuto";
                    if(tudMinutos.Value > 1)
                    {
                        notificacao += "s";
                    }
                }
            }
            else
            {
                notificacao += tudMinutos.Value.ToString() + " minuto";
                if(tudMinutos.Value > 1)
                {
                    notificacao += "s";
                }
            }

            return notificacao;
        }

        private void desligarPC()
        {
            /* Define os argumentos do processo shutdown */
            string args = "";
            string met = cmbboxMetodo.Text;

            if (met != "Desligar" && met != "Reiniciar")
            {
                cmbboxMetodo.Text = "Desligar";
                met = "Desligar";
            }

            switch (met)
            {
                case "Desligar":
                    args = "-s";
                    break;
                case "Reiniciar":
                    args = "-r";
                    break;
                default:
                    args = "-s";
                    break;
            }

            if (cboxForcar.Checked)
            {
                args += " -f";
            }

            args += " -t 1";

            ProcessStartInfo psi = new ProcessStartInfo("shutdown.exe", args);
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;

            /* Cria e executa o processo, desligando o computador */
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
        }

        private void timerCancelarEsconderIcone_Tick(object sender, EventArgs e)
        {
            icone.Visible = false;
            cmsIcone.Enabled = true;
            timerCancelarEsconderIcone.Stop();
        }
    }
}
