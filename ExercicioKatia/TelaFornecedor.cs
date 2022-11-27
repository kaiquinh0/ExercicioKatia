using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace ExercicioKatia
{
    public partial class TelaFornecedor : Form
    {
        MySqlConnection Conexao;

        public TelaFornecedor()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password=;database=bd_fornecedor";

                Conexao = new MySqlConnection(data_source);

                string sql = "INSERT INTO fornecedor (id_cnpj, razaosocial, endereco, email, nome fantasia, telefone, ie) " +
                    "VALUES " +
                    "('" + txtCnpj.Text + "','" + txtRazao.Text + "','" + txtEndereco.Text + "'," +
                    "'" + txtEmail.Text + "','" + txtNomefantasia.Text + "','" + txtTelefone.Text + "','" + txtIe.Text + "')";

                
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();
                
                comando.ExecuteReader();
                
                MessageBox.Show("Fornecedor inserido!");
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password=;database=bd_fornecedor";

                Conexao = new MySqlConnection(data_source);

                string sql = "UPDATE fornecedor (id_cnpj, razaosocial, endereco, email, nome fantasia, telefone, ie) " +
                    "VALUES " +
                    "('" + txtCnpj.Text + "','" + txtRazao.Text + "','" + txtEndereco.Text + "'," +
                    "'" + txtEmail.Text + "','" + txtNomefantasia.Text + "','" + txtTelefone.Text + "','" + txtIe.Text + "')";


                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Fornecedor alterado!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password=;database=bd_fornecedor";

                Conexao = new MySqlConnection(data_source);

                string sql = "DELETE fornecedor (id_cnpj, razaosocial, endereco, email, nome fantasia, telefone, ie) " +
                    "VALUES " +
                    "('" + txtCnpj.Text + "','" + txtRazao.Text + "','" + txtEndereco.Text + "'," +
                    "'" + txtEmail.Text + "','" + txtNomefantasia.Text + "','" + txtTelefone.Text + "','" + txtIe.Text + "')";


                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Fornecedor deletado!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password=;database=bd_fornecedor";

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * from fornecedor";

                
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();
                
                comando.ExecuteReader();
                
                MessageBox.Show("Fornecedor inserido!");
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}
