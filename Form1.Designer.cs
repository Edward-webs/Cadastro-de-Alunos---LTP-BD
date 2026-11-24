namespace Cadastro_de_Alunos___LTP_BD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCadastrar = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            btnConsultar = new Button();
            btnLimpar = new Button();
            txtNome = new TextBox();
            txtCPF = new TextBox();
            dtpNascimento = new DateTimePicker();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            txtTurma = new TextBox();
            cmbCurso = new ComboBox();
            dgvAlunos = new DataGridView();
            lblNome = new Label();
            lblCpf = new Label();
            lblEmail = new Label();
            lblTelefone = new Label();
            lblDataNasc = new Label();
            lblTurma = new Label();
            lblCurso = new Label();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblAlunosCad = new Label();
            lblDados = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAlunos).BeginInit();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(353, 197);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(79, 40);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(618, 197);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(79, 40);
            btnAlterar.TabIndex = 1;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(480, 196);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(79, 40);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(893, 196);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(79, 40);
            btnConsultar.TabIndex = 3;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(756, 196);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(79, 40);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 101);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(288, 23);
            txtNome.TabIndex = 5;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(353, 101);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(288, 23);
            txtCPF.TabIndex = 6;
            // 
            // dtpNascimento
            // 
            dtpNascimento.Location = new Point(12, 157);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(288, 23);
            dtpNascimento.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(353, 157);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(288, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(684, 101);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(288, 23);
            txtTelefone.TabIndex = 9;
            // 
            // txtTurma
            // 
            txtTurma.Location = new Point(684, 160);
            txtTurma.Name = "txtTurma";
            txtTurma.Size = new Size(288, 23);
            txtTurma.TabIndex = 10;
            // 
            // cmbCurso
            // 
            cmbCurso.FormattingEnabled = true;
            cmbCurso.Location = new Point(12, 214);
            cmbCurso.Name = "cmbCurso";
            cmbCurso.Size = new Size(288, 23);
            cmbCurso.TabIndex = 11;
            // 
            // dgvAlunos
            // 
            dgvAlunos.AllowUserToAddRows = false;
            dgvAlunos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlunos.BackgroundColor = Color.White;
            dgvAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlunos.Location = new Point(12, 425);
            dgvAlunos.MultiSelect = false;
            dgvAlunos.Name = "dgvAlunos";
            dgvAlunos.ReadOnly = true;
            dgvAlunos.RowHeadersVisible = false;
            dgvAlunos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlunos.Size = new Size(960, 174);
            dgvAlunos.TabIndex = 12;
            dgvAlunos.CellContentClick += dgvAlunos_CellContentClick;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 83);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 13;
            lblNome.Text = "Nome:";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(353, 83);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(31, 15);
            lblCpf.TabIndex = 14;
            lblCpf.Text = "CPF:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(353, 139);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "Email:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(684, 83);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(55, 15);
            lblTelefone.TabIndex = 16;
            lblTelefone.Text = "Telefone:";
            // 
            // lblDataNasc
            // 
            lblDataNasc.AutoSize = true;
            lblDataNasc.Location = new Point(12, 139);
            lblDataNasc.Name = "lblDataNasc";
            lblDataNasc.Size = new Size(117, 15);
            lblDataNasc.TabIndex = 17;
            lblDataNasc.Text = "Data de Nascimento:";
            // 
            // lblTurma
            // 
            lblTurma.AutoSize = true;
            lblTurma.Location = new Point(684, 142);
            lblTurma.Name = "lblTurma";
            lblTurma.Size = new Size(45, 15);
            lblTurma.TabIndex = 18;
            lblTurma.Text = "Turma:";
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.Location = new Point(12, 196);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(41, 15);
            lblCurso.TabIndex = 19;
            lblCurso.Text = "Curso:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(344, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(248, 37);
            lblTitulo.TabIndex = 20;
            lblTitulo.Text = "Cadastro de Alunos";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.Location = new Point(258, 46);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(449, 30);
            lblSubtitulo.TabIndex = 21;
            lblSubtitulo.Text = "Gerenciamento de informações dos estudantes";
            // 
            // lblAlunosCad
            // 
            lblAlunosCad.AutoSize = true;
            lblAlunosCad.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlunosCad.Location = new Point(12, 346);
            lblAlunosCad.Name = "lblAlunosCad";
            lblAlunosCad.Size = new Size(223, 32);
            lblAlunosCad.TabIndex = 22;
            lblAlunosCad.Text = "Alunos Cadastrados";
            // 
            // lblDados
            // 
            lblDados.AutoSize = true;
            lblDados.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDados.Location = new Point(12, 387);
            lblDados.Name = "lblDados";
            lblDados.Size = new Size(276, 25);
            lblDados.TabIndex = 23;
            lblDados.Text = "ID | Nome | CPF | Turma | Curso";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
            Controls.Add(lblDados);
            Controls.Add(lblAlunosCad);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Controls.Add(lblCurso);
            Controls.Add(lblTurma);
            Controls.Add(lblDataNasc);
            Controls.Add(lblTelefone);
            Controls.Add(lblEmail);
            Controls.Add(lblCpf);
            Controls.Add(lblNome);
            Controls.Add(dgvAlunos);
            Controls.Add(cmbCurso);
            Controls.Add(txtTurma);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(dtpNascimento);
            Controls.Add(txtCPF);
            Controls.Add(txtNome);
            Controls.Add(btnLimpar);
            Controls.Add(btnConsultar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(btnCadastrar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Cadastro de Alunos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlunos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private Button btnAlterar;
        private Button btnExcluir;
        private Button btnConsultar;
        private Button btnLimpar;
        private TextBox txtNome;
        private TextBox txtCPF;
        private DateTimePicker dtpNascimento;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtTurma;
        private ComboBox cmbCurso;
        private DataGridView dgvAlunos;
        private Label lblNome;
        private Label lblCpf;
        private Label lblEmail;
        private Label lblTelefone;
        private Label lblDataNasc;
        private Label lblTurma;
        private Label lblCurso;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblAlunosCad;
        private Label lblDados;
    }
}
