using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CadastroClientesProcedure
{
    public partial class Form1 : Form
    {
        BancoDeDados bd = new BancoDeDados("Server=(localdb)\\MSSQLLocalDB; Database=BD_CadClientes;");

        /* Qual a ação sendo realizada com o registro atual */
        enum EstadoRegistro
        {
            Vazio,
            Consultar,
            Novo,
            Editar
        }

        EstadoRegistro estado = EstadoRegistro.Vazio;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostraClientes();
            PreencheCampos(0);
        }

        /* Preenche o dada grid view com os registros dos clientes */
        private void MostraClientes()
        {
            List<Cliente> listaClientes = bd.ConsultarClientes();
            if (listaClientes != null)
            {
                dataGridViewClientes.Rows.Clear();
                foreach(Cliente c in listaClientes)
                {
                    dataGridViewClientes.Rows.Add(c.Id, c.Nome, c.Telefone, c.Email);

                }
                
            }
        }

        /* Preenche os campos com os dados do cliente na linha especificada e ativa os TextBoxes */
        private void PreencheCampos(int numLinha)
        {
            if (dataGridViewClientes.Rows[numLinha].Cells[0].Value != null)
            {
                estado = EstadoRegistro.Consultar;
                AtivaControles(estado);

                txtId.Text = dataGridViewClientes.Rows[numLinha].Cells["id"].Value.ToString();
                txtNome.Text = dataGridViewClientes.Rows[numLinha].Cells["nome"].Value.ToString();
                mtxtTelefone.Text = dataGridViewClientes.Rows[numLinha].Cells["telefone"].Value.ToString();
                txtEmail.Text = dataGridViewClientes.Rows[numLinha].Cells["email"].Value.ToString();

            }
            else
            {
                estado = EstadoRegistro.Vazio;
                AtivaControles(estado);

                LimpaCampos();
            }
        }

        /* Limpa todos os campos */
        private void LimpaCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            mtxtTelefone.Clear();
            txtEmail.Clear();
        }

        /* Ativa/Desativa os controles conforme o estado atual */
        private void AtivaControles(EstadoRegistro acao)
        {
            switch (acao)
            {
                case EstadoRegistro.Vazio:
                    //botoes
                    btnNovo.Enabled = true;
                    btnEditar.Enabled = false;
                    btnSalvar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnCancelar.Enabled = false;

                    //campos
                    txtId.Enabled = false;
                    txtNome.Enabled = false;
                    mtxtTelefone.Enabled = false;
                    txtEmail.Enabled = false;
                    break;

                case EstadoRegistro.Consultar:
                    //botoes
                    btnNovo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnExcluir.Enabled = true;
                    btnCancelar.Enabled = false;

                    //campos
                    txtId.Enabled = false;
                    txtNome.Enabled = false;
                    mtxtTelefone.Enabled = false;
                    txtEmail.Enabled = false;
                    break;

                case EstadoRegistro.Novo:
                    //botoes
                    btnNovo.Enabled = false;
                    btnEditar.Enabled = false;
                    btnSalvar.Enabled = true;
                    btnExcluir.Enabled = false;
                    btnCancelar.Enabled = true;

                    //campos
                    txtId.Enabled = false;
                    txtNome.Enabled = true;
                    mtxtTelefone.Enabled = true;
                    txtEmail.Enabled = true;
                    break;

                case EstadoRegistro.Editar:
                    //botoes
                    btnNovo.Enabled = false;
                    btnEditar.Enabled = false;
                    btnSalvar.Enabled = true;
                    btnExcluir.Enabled = false;
                    btnCancelar.Enabled = true;

                    //campos
                    txtId.Enabled = true;
                    txtNome.Enabled = true;
                    mtxtTelefone.Enabled = true;
                    txtEmail.Enabled = true;
                    break;
            }
        }

        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numLinha = e.RowIndex;
            if (numLinha >= 0)
            {
                PreencheCampos(numLinha);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            estado = EstadoRegistro.Novo;
            AtivaControles(estado);

            LimpaCampos();
            txtNome.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string msg;
            if(estado == EstadoRegistro.Novo)
            {
                msg = "Cancelar novo cadastro?";
                DialogResult res = MessageBox.Show(msg, "Cancelar", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {
                    estado = EstadoRegistro.Vazio;
                    AtivaControles(estado);

                    LimpaCampos();
                }
            }
            else
            {
                msg = "Cancelar edição?";
                DialogResult res = MessageBox.Show(msg, "Cancelar", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {
                    Cliente cAntigo = bd.ConsultarClientes(Convert.ToInt32(txtId.Text));
                    txtNome.Text = cAntigo.Nome;
                    mtxtTelefone.Text = cAntigo.Telefone;
                    txtEmail.Text = cAntigo.Email;

                    estado = EstadoRegistro.Consultar;
                    AtivaControles(estado);

                }
            }

            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            /* Caso o usuário esteja CRIANDO um novo registro */
            if(estado == EstadoRegistro.Novo)
            {
                if(txtNome.Text == "" || mtxtTelefone.Text == "")
                {
                    MessageBox.Show("Os campos Nome e Telefone DEVEM SER PREENCHIDOS!", "Aviso");
                }
                else
                {
                    Cliente c = new Cliente();
                    c.Nome = txtNome.Text;
                    c.Telefone = mtxtTelefone.Text;
                    if(txtEmail.Text == "")
                    {
                        c.Email = null;
                    }
                    else
                    {
                        c.Email = txtEmail.Text;
                    }
                    int linhasAfetadas = bd.CadastrarCliente(c);
                    if(linhasAfetadas > 0)
                    {
                        MostraClientes();
                        PreencheCampos(dataGridViewClientes.Rows.Count-1);
                        MessageBox.Show("Cadastro realizado com sucesso!", "Aviso");
                    }
                }
            }
            /* Caso o usuario esteja EDITANDO um registro */
            else
            {
                if (txtNome.Text == "" || mtxtTelefone.Text == "")
                {
                    MessageBox.Show("Os campos Nome e Telefone DEVEM SER PREENCHIDOS!", "Aviso");
                }
                else
                {
                    Cliente c = new Cliente();
                    c.Id = Convert.ToInt32(txtId.Text);
                    c.Nome = txtNome.Text;
                    c.Telefone = mtxtTelefone.Text;
                    if (txtEmail.Text == "")
                    {
                        c.Email = null;
                    }
                    else
                    {
                        c.Email = txtEmail.Text;
                    }

                    Cliente cAntigo = bd.ConsultarClientes(c.Id); // cAntigo é o cliente antes de qualquer edição
                    // Se nada foi alterado, não atualizar.
                    if (cAntigo.Nome == c.Nome &&
                        cAntigo.Telefone == c.Telefone &&
                        cAntigo.Email == c.Email)
                    {
                        estado = EstadoRegistro.Consultar;
                        AtivaControles(estado);
                    }
                    else
                    {
                        int linhasAfetadas = bd.AtualizarCliente(c);
                        if (linhasAfetadas > 0)
                        {
                            MostraClientes();
                            estado = EstadoRegistro.Consultar;
                            AtivaControles(estado);
                            MessageBox.Show("Registro atualizado com sucesso!", "Aviso");
                        }
                        else
                        {
                            MessageBox.Show("Registro não encontrado.", "Erro");
                        }
                    }
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente exluir o registro?", "Confirmar Exclusão", MessageBoxButtons.YesNo);

            if(resultado == DialogResult.Yes)
            {
                bd.ExcluirCliente(Convert.ToInt32(txtId.Text));

                dataGridViewClientes.Rows.Clear();
                MostraClientes();
                PreencheCampos(0);
                MessageBox.Show("Registro exluido com sucesso.", "Aviso");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            estado = EstadoRegistro.Editar;
            AtivaControles(estado);

            txtNome.Focus();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dataGridViewClientes.Rows.Clear();
            MostraClientes();
            PreencheCampos(0);
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisar.Text.Trim().Length > 0)
            {
                List<Cliente> listaClientes = bd.ConsultarClientes(txtPesquisar.Text.Trim());
                if (listaClientes != null)
                {
                    dataGridViewClientes.Rows.Clear();
                    foreach (Cliente c in listaClientes)
                    {
                        dataGridViewClientes.Rows.Add(c.Id, c.Nome, c.Telefone, c.Email);

                    }

                }
            }
            else
            {
                dataGridViewClientes.Rows.Clear();
                MostraClientes();
            }
        }
    }
}
