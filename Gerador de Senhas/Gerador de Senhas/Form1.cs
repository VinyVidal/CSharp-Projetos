using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_Senhas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            qntdigitos.SelectedItem = "4";
            tipo.SelectedItem = "Apenas Números";
        }

        private void botaogerar_Click(object sender, EventArgs e)
        {
            Random randnum = new Random(); // Construção do objeto da classe Random
            int qdigitos = Convert.ToInt32(qntdigitos.SelectedItem);
            char[] digitos = new char[qdigitos];
            char aux; // Guarda o número aleatorio antes de passa-lo para o vetor 'digitos'

            // Se o tipo de senha selecionado for "Apenas Números"
            if (Convert.ToString(tipo.SelectedItem)=="Apenas Números")
            {
                for (int i = 0; i < qdigitos; i++)
                {
                    digitos[i] = Convert.ToChar(randnum.Next(48, 57));
                }
            }
            // Se o tipo de senha for "Apenas Caracteres"
            else if(Convert.ToString(tipo.SelectedItem) == "Apenas Caracteres")
            {
                int i = 0;
                while(i < qdigitos)
                {
                    aux = Convert.ToChar(randnum.Next(65, 122));
                    if((aux >= 65 && aux <= 90) || (aux >= 97 && aux <= 122))
                    {
                        digitos[i] = aux;
                        i++;
                    }
                }
            }
            // Senão o tipo selecionado será "Números e Caracteres", então...
            else if (Convert.ToString(tipo.SelectedItem)=="Números e Caracteres")
            {
                int i = 0;
                while(i<qdigitos)
                {
                    aux=Convert.ToChar(randnum.Next(48, 122));
                    if ((aux>=48 && aux<=57) || (aux>=65 && aux<=90) || (aux>=97 && aux<=122))
                    {
                        digitos[i] = aux;
                        i++;
                    }
                }
            }
            string senha = new string(digitos);
            CaixaSenhas.Items.Add(senha);
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string conteudo = "";
            int i = 0;
            if(CaixaSenhas.SelectedItems.Count > 0)
            {
                foreach(Object item in CaixaSenhas.SelectedItems)
                {
                    i++;
                    conteudo += item.ToString();
                    if(i < CaixaSenhas.SelectedItems.Count)
                    {
                        conteudo += Environment.NewLine;
                    }
                    
                }
                Clipboard.SetText(conteudo);
            }
            
        }

        private void limparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaixaSenhas.Items.Clear();
        }

        private void botaolimpar_Click(object sender, EventArgs e)
        {
            CaixaSenhas.Items.Clear();
        }

        private void SubMenu_Opening(object sender, CancelEventArgs e)
        {
            if(CaixaSenhas.SelectedItems.Count == 0)
            {
                copiarToolStripMenuItem.Visible = false;
                copiarToolStripMenuItem.Enabled = false;
            }
            else
            {
                copiarToolStripMenuItem.Visible = true;
                copiarToolStripMenuItem.Enabled = true;
            }

            if(CaixaSenhas.Items.Count == 0)
            {
                copiarTudoToolStripMenuItem.Visible = false;
                copiarTudoToolStripMenuItem.Enabled = false;
            }
            else
            {
                copiarTudoToolStripMenuItem.Visible = true;
                copiarTudoToolStripMenuItem.Enabled = true;
            }
        }

        private void copiarTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string conteudo = "";
            int i = 0;
            if (CaixaSenhas.Items.Count > 0)
            {
                foreach (Object item in CaixaSenhas.Items)
                {
                    i++;
                    conteudo += item.ToString();
                    if (i < CaixaSenhas.Items.Count)
                    {
                        conteudo += Environment.NewLine;
                    }

                }
                Clipboard.SetText(conteudo);
            }
        }
    }
}
