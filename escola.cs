using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace escola
{
    public partial class escola : Form
    {
        public escola()
        {
            InitializeComponent();
        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                string curso = txtCurso.Text;
                string nascimento = txtNacimento.Text;
                string telefone = txtTelefone.Text;
                if (nome != "" && curso != "" && nascimento != "" && telefone != "")
                {
                    string conexaoB = "Server=localhost; Database=Escola; Uid=root; pwd='' ;";
                    MySqlConnection conexao = new MySqlConnection(conexaoB);

                    conexao.Open();

                    DateTime mysqlformat = Convert.ToDateTime(nascimento);// coverte a data para o formato do mysql
                    string data = mysqlformat.ToString("yyyy-MM-dd");

                    string cadastro = "INSERT INTO alunos (nome, curso, datanacimento, telefone) VALUES (@nome, @curso, @datanacimento, @telefone)";
                    MySqlCommand comando = new MySqlCommand(cadastro, conexao);
                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@curso", curso);
                    comando.Parameters.AddWithValue("@datanacimento", data);
                    comando.Parameters.AddWithValue("@telefone", telefone);

                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso!", "Suceso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNome.Clear();
                    txtCurso.Clear();
                    txtNacimento.Clear();
                    txtTelefone.Clear();
                    conexao.Close();

                }
                else
                {
                    MessageBox.Show("Preencha todos os campos coretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar o cadastro ", "Erro" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void escola_Load(object sender, EventArgs e)
        {
            try
            {
                string conexaoB = "Server=localhost; Database=Escola; Uid=root; pwd='' ;";
                MySqlConnection conexao = new MySqlConnection(conexaoB);

                conexao.Open();

                string listar = "SELECT * FROM alunos";
                MySqlDataAdapter adapter = new MySqlDataAdapter(listar, conexao);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridAlunos.DataSource = dataTable;
                dataGridAlunos.AllowUserToAddRows = false;
                dataGridAlunos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridAlunos.AutoResizeColumns();
                dataGridAlunos.ClearSelection();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os alunos!" + ex.Message);

            }


        }

        private void dataGridAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                string conexaoB = "Server=localhost; Database=Escola; Uid=root; pwd='' ;";
                MySqlConnection conexao = new MySqlConnection(conexaoB);

                conexao.Open();

                string listar = "SELECT * FROM alunos";
                MySqlDataAdapter adapter = new MySqlDataAdapter(listar, conexao);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridAlunos.DataSource = dataTable;
                dataGridAlunos.AllowUserToAddRows = false;
                dataGridAlunos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridAlunos.AutoResizeColumns();
                dataGridAlunos.ClearSelection();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os alunos!" + ex.Message);

            }

        }
        private int alunIDselecionado;
        private void dataGridAlunos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    alunIDselecionado = Convert.ToInt32(dataGridAlunos.Rows[e.RowIndex].Cells["id"].Value);
                    txtNome.Text = dataGridAlunos.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                    string datancaimento = dataGridAlunos.Rows[e.RowIndex].Cells["datanacimento"].Value.ToString();
                    txtNacimento.Text = DateTime.Parse(datancaimento).ToString("yyyy-MM-dd");
                    txtCurso.Text = dataGridAlunos.Rows[e.RowIndex].Cells["curso"].Value.ToString();
                    txtTelefone.Text = dataGridAlunos.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pegar os dados !" + ex.Message);

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                string curso = txtCurso.Text;
                string nascimento = txtNacimento.Text;
                string telefone = txtTelefone.Text;
                if (alunIDselecionado > 0)
                {
                    if (nome != "" && curso != "" && nascimento != "" && telefone != "")
                    {
                        string conexaoB = "Server=localhost; Database=Escola; Uid=root; pwd='' ;";
                        MySqlConnection conexao = new MySqlConnection(conexaoB);

                        conexao.Open();


                        string atualizaralunos = "UPDATE alunos SET nome = @nome, datanacimento = @datanacimento, curso = @curso, telefone = @telefone WHERE id = @id";
                        MySqlCommand comando = new MySqlCommand(atualizaralunos, conexao);
                        DateTime mysqlformat = Convert.ToDateTime(nascimento);// coverte a data para o formato do mysql
                        string data = mysqlformat.ToString("yyyy-MM-dd");
                        comando.Parameters.AddWithValue("@datanacimento", data);
                        comando.Parameters.AddWithValue("@nome", nome);
                        comando.Parameters.AddWithValue("@curso", curso);
                        comando.Parameters.AddWithValue("@telefone", telefone);
                        comando.Parameters.AddWithValue("@id", alunIDselecionado);

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Dados atualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtNome.Clear();
                        txtCurso.Clear();
                        txtNacimento.Clear();
                        txtTelefone.Clear();
                        conexao.Close();

                    }
                    else
                    {
                        MessageBox.Show("Selecione um registro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao liberar para edição ", "Erro" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {

                if (alunIDselecionado > 0)
                {
                    var resultado = MessageBox.Show("Deseja realmente excluir o registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        string conexaoB = "Server=localhost; Database=Escola; Uid=root; pwd='' ;";
                        MySqlConnection conexao = new MySqlConnection(conexaoB);

                        conexao.Open();


                        string deletaralunos = "DELETE  from alunos WHERE id = @id";
                        MySqlCommand comando = new MySqlCommand(deletaralunos, conexao);
                        comando.Parameters.AddWithValue("@id", alunIDselecionado);

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Cadrastro excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtNome.Clear();
                        txtCurso.Clear();
                        txtNacimento.Clear();
                        txtTelefone.Clear();
                        conexao.Close();
                    }
                    else
                    if (resultado == DialogResult.No)
                    {
                        MessageBox.Show("Exclusão cancelada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtNome.Clear();
                        txtCurso.Clear();
                        txtNacimento.Clear();
                        txtTelefone.Clear();
                    }


                }
                else
                {
                    MessageBox.Show("Selecione um registro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir! ", "Erro" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    alunIDselecionado = Convert.ToInt32(dataGridAlunos.Rows[e.RowIndex].Cells["id"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar o registro!" + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtCurso.Clear();
            txtNacimento.Clear();
            txtTelefone.Clear();
        }

        private void btnLimpar_BackColorChanged(object sender, EventArgs e)
        {

        }
    }
}