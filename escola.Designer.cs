namespace escola
{
    partial class escola
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNome = new TextBox();
            txtCurso = new TextBox();
            txtNacimento = new MaskedTextBox();
            txtTelefone = new MaskedTextBox();
            btnCadastra = new Button();
            btnListar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            dataGridAlunos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridAlunos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 41);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 158);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 1;
            label2.Text = "Data de Nacimento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(552, 158);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 2;
            label3.Text = "Curso:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(552, 41);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "Telefone:";
            // 
            // txtNome
            // 
            txtNome.AccessibleName = "";
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Location = new Point(35, 72);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome:";
            txtNome.Size = new Size(240, 26);
            txtNome.TabIndex = 1;
            // 
            // txtCurso
            // 
            txtCurso.Cursor = Cursors.IBeam;
            txtCurso.Location = new Point(448, 201);
            txtCurso.MaxLength = 100;
            txtCurso.Name = "txtCurso";
            txtCurso.PlaceholderText = "Curso:";
            txtCurso.Size = new Size(268, 26);
            txtCurso.TabIndex = 4;
            // 
            // txtNacimento
            // 
            txtNacimento.Cursor = Cursors.IBeam;
            txtNacimento.Location = new Point(35, 201);
            txtNacimento.Mask = "00/00/0000";
            txtNacimento.Name = "txtNacimento";
            txtNacimento.Size = new Size(240, 26);
            txtNacimento.TabIndex = 3;
            // 
            // txtTelefone
            // 
            txtTelefone.Cursor = Cursors.IBeam;
            txtTelefone.Location = new Point(448, 72);
            txtTelefone.Mask = "(00) 00000 - 0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(268, 26);
            txtTelefone.TabIndex = 2;
            // 
            // btnCadastra
            // 
            btnCadastra.Cursor = Cursors.Hand;
            btnCadastra.Location = new Point(35, 289);
            btnCadastra.Name = "btnCadastra";
            btnCadastra.Size = new Size(75, 30);
            btnCadastra.TabIndex = 5;
            btnCadastra.Text = "Cadastrar";
            btnCadastra.UseVisualStyleBackColor = true;
            btnCadastra.Click += btnCadastra_Click;
            // 
            // btnListar
            // 
            btnListar.Cursor = Cursors.Hand;
            btnListar.Location = new Point(200, 289);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 30);
            btnListar.TabIndex = 6;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Location = new Point(350, 289);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 30);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.Location = new Point(503, 289);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 30);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Cursor = Cursors.Hand;
            btnLimpar.Location = new Point(641, 289);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 30);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.BackColorChanged += btnLimpar_BackColorChanged;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // dataGridAlunos
            // 
            dataGridAlunos.AllowUserToAddRows = false;
            dataGridAlunos.AllowUserToDeleteRows = false;
            dataGridAlunos.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGridAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAlunos.Cursor = Cursors.Cross;
            dataGridAlunos.Location = new Point(35, 340);
            dataGridAlunos.Name = "dataGridAlunos";
            dataGridAlunos.ReadOnly = true;
            dataGridAlunos.RowHeadersVisible = false;
            dataGridAlunos.Size = new Size(681, 247);
            dataGridAlunos.TabIndex = 10;
            dataGridAlunos.CellClick += dataGridAlunos_CellClick;
            dataGridAlunos.CellContentClick += dataGridAlunos_CellContentClick;
            dataGridAlunos.CellDoubleClick += dataGridAlunos_CellDoubleClick;
            // 
            // escola
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 612);
            Controls.Add(dataGridAlunos);
            Controls.Add(btnLimpar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnListar);
            Controls.Add(btnCadastra);
            Controls.Add(txtTelefone);
            Controls.Add(txtNacimento);
            Controls.Add(txtCurso);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "escola";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            Load += escola_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridAlunos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private TextBox txtCurso;
        private MaskedTextBox txtNacimento;
        private MaskedTextBox txtTelefone;
        private Button btnCadastra;
        private Button btnListar;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnLimpar;
        private DataGridView dataGridAlunos;
    }
}
