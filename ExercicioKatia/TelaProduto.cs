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
    public partial class TelaProduto : Form
    {
        MySqlConnection Conexao;

        public TelaProduto()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password=;database=bd_produto";

                Conexao = new MySqlConnection(data_source);

                string sql = "INSERT INTO produto (id_codigo, descricao, datadevalidade, preco, estoque) " +
                    "VALUES " +
                    "('" + txtCodigo.Text + "','" + txtDescricao.Text + "','" + txtData.Text + "'," +
                    "'" + txtPreco.Text + "','" + txtEstoque.Text + "')";


                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Produto inserido!");


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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password=;database=bd_produto";

                Conexao = new MySqlConnection(data_source);

                string sql = "UPDATE produto (id_codigo, descricao, datadevalidade, preco, estoque) " +
                    "VALUES " +
                    "('" + txtCodigo.Text + "','" + txtDescricao.Text + "','" + txtData.Text + "'," +
                    "'" + txtPreco.Text + "','" + txtEstoque.Text + "')";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Produto alterado!");


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
                string data_source = "datasource=localhost;username=root;password=;database=bd_produto";

                Conexao = new MySqlConnection(data_source);

                string sql = "DELETE produto (id_codigo, descricao, datadevalidade, preco, estoque) " +
                    "VALUES " +
                    "('" + txtCodigo.Text + "','" + txtDescricao.Text + "','" + txtData.Text + "'," +
                    "'" + txtPreco.Text + "','" + txtEstoque.Text + "')";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Produto deletado!");


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
                string data_source = "datasource=localhost;username=root;password=;database=bd_produto";

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * from produto";


                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                comando.ExecuteReader();



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
    }
}
