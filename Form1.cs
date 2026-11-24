using Cadastro_de_Alunos___LTP_BD;
using System.Data;
using System.Data.OleDb;

namespace Cadastro_de_Alunos___LTP_BD
{
    public partial class Form1 : Form
    {

        private int idSelecionado = 0;

        public Form1()
        {
            InitializeComponent();
            cmbCurso.Items.Add("Engenharia de Software");
            cmbCurso.Items.Add("Engenharia da Computação");
            cmbCurso.Items.Add("Análise e Desenvolvimento de Sistemas");
            cmbCurso.Items.Add("Ciência da Computação");
            CarregarAlunos();
            CadastrarAluno();
            AlterarAluno();
            ExcluirAluno();
            LimparCampos();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void lblTitulo_Click(object sender, EventArgs e) { }

        private void CarregarAlunos()
        {
            try
            {
                using (OleDbConnection con = Conexao.Conectar())
                {
                    con.Open();

                    string sql = @"SELECT ID, Nome, CPF, DataNascimento, Email, Telefone, Turma, Curso FROM Alunos";

                    using (OleDbDataAdapter adaptador = new OleDbDataAdapter(sql, con))
                    {
                        DataTable tabela = new DataTable();

                        adaptador.Fill(tabela);

                        dgvAlunos.DataSource = tabela;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao consultar alunos: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void CadastrarAluno()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                    string.IsNullOrWhiteSpace(txtCPF.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefone.Text) ||
                    string.IsNullOrWhiteSpace(txtTurma.Text) ||
                    string.IsNullOrWhiteSpace(cmbCurso.Text))
                {
                    MessageBox.Show("Preencha todos os campos!");
                    return;
                }

                using (OleDbConnection con = Conexao.Conectar())
                {
                    con.Open();

                    string sql = @"INSERT INTO Alunos
                (Nome, CPF, DataNascimento, Email, Telefone, Turma, Curso)
                VALUES (?, ?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(sql, con))
                    {
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = txtNome.Text;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = txtCPF.Text;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = dtpNascimento.Value.Date;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = txtEmail.Text;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = txtTelefone.Text;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = txtTurma.Text;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = cmbCurso.Text;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Aluno cadastrado com sucesso!");

                CarregarAlunos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar aluno: " + ex.Message);
            }
        }
        private void AlterarAluno()
        {
            try
            {
                if (idSelecionado == 0)
                {
                    MessageBox.Show("Selecione um aluno na tabela!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                    string.IsNullOrWhiteSpace(txtCPF.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefone.Text) ||
                    string.IsNullOrWhiteSpace(txtTurma.Text) ||
                    string.IsNullOrWhiteSpace(cmbCurso.Text))
                {
                    MessageBox.Show("Preencha todos os campos!");
                    return;
                }

                using (OleDbConnection con = Conexao.Conectar())
                {
                    con.Open();

                    string sql = @"UPDATE Alunos SET
                Nome = ?, CPF = ?, DataNascimento = ?,
                Email = ?, Telefone = ?, Turma = ?, Curso = ?
                WHERE ID = ?";

                    using (OleDbCommand cmd = new OleDbCommand(sql, con))
                    {
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = txtNome.Text;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = txtCPF.Text;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = dtpNascimento.Value.Date;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = txtEmail.Text;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = txtTelefone.Text;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = txtTurma.Text;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = cmbCurso.Text;
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = idSelecionado;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Aluno alterado com sucesso!");

                CarregarAlunos();

                idSelecionado = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar aluno: " + ex.Message);
            }
        }

        private void ExcluirAluno()
        {
            try
            {
                if (idSelecionado == 0)
                {
                    MessageBox.Show("Selecione um aluno na tabela!");
                    return;
                }

                DialogResult resposta = MessageBox.Show(
                    "Tem certeza que deseja excluir este aluno?",
                    "Confirmar exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resposta == DialogResult.Yes)
                {
                    using (OleDbConnection con = Conexao.Conectar())
                    {
                        con.Open();

                        string sql = "DELETE FROM Alunos WHERE ID = ?";

                        using (OleDbCommand cmd = new OleDbCommand(sql, con))
                        {
                            cmd.Parameters.Add("?", OleDbType.Integer).Value = idSelecionado;

                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Aluno excluído com sucesso!");

                    CarregarAlunos();

                    idSelecionado = 0;

                    txtNome.Clear();
                    txtCPF.Clear();
                    txtEmail.Clear();
                    txtTelefone.Clear();
                    txtTurma.Clear();
                    cmbCurso.SelectedIndex = -1;
                    dtpNascimento.Value = DateTime.Today;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir aluno: " + ex.Message);
            }
        }


        private void LimparCampos()
        {
            txtNome.Clear();
            txtCPF.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtTurma.Clear();

            cmbCurso.SelectedIndex = -1;

            dtpNascimento.Value = DateTime.Today;

            idSelecionado = 0;

            dgvAlunos.ClearSelection();
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CarregarAlunos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarAluno();
        }

        private void dgvAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = dgvAlunos.Rows[e.RowIndex];

                idSelecionado = Convert.ToInt32(linha.Cells["ID"].Value);

                txtNome.Text = linha.Cells["Nome"].Value.ToString();
                txtCPF.Text = linha.Cells["CPF"].Value.ToString();

                dtpNascimento.Value = Convert.ToDateTime(linha.Cells["DataNascimento"].Value);

                txtEmail.Text = linha.Cells["Email"].Value.ToString();
                txtTelefone.Text = linha.Cells["Telefone"].Value.ToString();
                txtTurma.Text = linha.Cells["Turma"].Value.ToString();
                cmbCurso.Text = linha.Cells["Curso"].Value.ToString();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarAluno();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirAluno();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}