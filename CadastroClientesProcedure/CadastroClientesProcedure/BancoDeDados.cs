using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CadastroClientesProcedure
{
    class BancoDeDados
    {
        private SqlConnection Conexao = new SqlConnection();
        private SqlCommand Comando = new SqlCommand();

        public BancoDeDados(string strCon)
        {
            Conexao.ConnectionString = strCon;
            Comando.Connection = Conexao;
        }

        public int CadastrarCliente(Cliente c)
        {
            Comando.CommandText = "insert_Cliente";
            Comando.Parameters.AddWithValue("@nome", c.Nome);
            Comando.Parameters.AddWithValue("@telefone", c.Telefone);

            if(c.Email != "")
            {
                Comando.Parameters.AddWithValue("@email", c.Email);
            }
            else
            {
                Comando.Parameters.AddWithValue("@email", null);
            }

            Comando.CommandType = System.Data.CommandType.StoredProcedure;

            int linhasAfetadas;
            try
            {
                Conexao.Open();
                linhasAfetadas = Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Conexao.Close();
                MessageBox.Show(ex.Message, "Erro no banco de dados");
                return 0;
            }
            finally
            {
                Comando.Parameters.Clear();
            }
            Conexao.Close();

            return linhasAfetadas;
        }

        public int AtualizarCliente(Cliente c)
        {
            Comando.CommandText = "update_Cliente";
            Comando.Parameters.AddWithValue("@id", c.Id);
            Comando.Parameters.AddWithValue("@novoNome", c.Nome);
            Comando.Parameters.AddWithValue("@novoTelefone", c.Telefone);
            Comando.Parameters.AddWithValue("@novoEmail", c.Email);
            Comando.CommandType = System.Data.CommandType.StoredProcedure;

            int linhasAfetadas;
            try
            {
                Conexao.Open();
                linhasAfetadas = Comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Conexao.Close();
                MessageBox.Show(ex.Message, "Erro no banco de dados");
                return 0;
            }
            finally
            {
                Comando.Parameters.Clear();
            }
            Conexao.Close();

            return linhasAfetadas;
        }

        public int ExcluirCliente(int id)
        {
            Comando.CommandText = "delete_Cliente";
            Comando.Parameters.AddWithValue("@id", id);
            Comando.CommandType = System.Data.CommandType.StoredProcedure;

            int linhasAfetadas;
            try
            {
                Conexao.Open();
                linhasAfetadas = Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Conexao.Close();
                MessageBox.Show(ex.Message, "Erro no banco de dados");
                return 0;
            }
            finally
            {
                Comando.Parameters.Clear();
            }
            Conexao.Close();

            return linhasAfetadas;
        }

        public List<Cliente> ConsultarClientes()
        {
            Comando.CommandText = "selectAll_Clientes";
            Comando.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataReader leitor;
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                Conexao.Open();
                leitor = Comando.ExecuteReader();

                while (leitor.Read())
                {
                    Cliente c = new Cliente();
                    c.Id = Convert.ToInt32(leitor["idCliente"].ToString());
                    c.Nome = leitor["nomeCliente"].ToString();
                    c.Telefone = leitor["telefoneCliente"].ToString();
                    c.Email = leitor["emailCliente"].ToString();
                    clientes.Add(c);
                }
            }
            catch (Exception ex)
            {
                Conexao.Close();
                MessageBox.Show(ex.Message, "Erro no banco de dados");
                return null;
            }
            finally
            {
                Comando.Parameters.Clear();
            }

            Conexao.Close();

            return clientes;
        }
        public Cliente ConsultarClientes(int id)
        {

            Comando.CommandText = "selectById_Cliente";
            Comando.Parameters.AddWithValue("@id", id);
            Comando.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataReader leitor;
            Cliente c = new Cliente();
            try
            {
                Conexao.Open();
                leitor = Comando.ExecuteReader();

                while (leitor.Read())
                {
                    c.Id = Convert.ToInt32(leitor["idCliente"].ToString());
                    c.Nome = leitor["nomeCliente"].ToString();
                    c.Telefone = leitor["telefoneCliente"].ToString();
                    c.Email = leitor["emailCliente"].ToString();
                }
            }
            catch (Exception ex)
            {
                Conexao.Close();
                MessageBox.Show(ex.Message , "Erro no banco de dados");
                return null;
            }
            finally
            {
                Comando.Parameters.Clear();
            }

            Conexao.Close();

            return c;
        }
        public List<Cliente> ConsultarClientes(string nome)
        {

            Comando.CommandText = "selectByName_Cliente";
            Comando.Parameters.AddWithValue("@nome", nome);
            Comando.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataReader leitor;
            List<Cliente> listaClientes = new List<Cliente>();
            
            try
            {
                Conexao.Open();
                leitor = Comando.ExecuteReader();

                while (leitor.Read())
                {
                    Cliente c = new Cliente();
                    c.Id = Convert.ToInt32(leitor["idCliente"].ToString());
                    c.Nome = leitor["nomeCliente"].ToString();
                    c.Telefone = leitor["telefoneCliente"].ToString();
                    c.Email = leitor["emailCliente"].ToString();

                    listaClientes.Add(c);
                }
            }
            catch (Exception ex)
            {
                Conexao.Close();
                MessageBox.Show(ex.Message, "Erro no banco de dados");
                return null;
            }
            finally
            {
                Comando.Parameters.Clear();
            }

            Conexao.Close();

            return listaClientes;
        }
    }
}
