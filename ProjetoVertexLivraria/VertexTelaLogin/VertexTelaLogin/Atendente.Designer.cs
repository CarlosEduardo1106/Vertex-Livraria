namespace VertexTelaLogin
{
    partial class Atendente
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNome = new TextBox();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            gbPesquisa = new GroupBox();
            txtPesqAtendente = new TextBox();
            dgvAtendente = new DataGridView();
            btnNovo = new Button();
            btnGravar = new Button();
            btnAlterar = new Button();
            btnRemover = new Button();
            btnCancelar = new Button();
            gbPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAtendente).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(179, 12);
            label1.Name = "label1";
            label1.Size = new Size(165, 41);
            label1.TabIndex = 0;
            label1.Text = "Atendente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(40, 130);
            label2.Name = "label2";
            label2.Size = new Size(71, 23);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(41, 156);
            label3.Name = "label3";
            label3.Size = new Size(70, 23);
            label3.TabIndex = 2;
            label3.Text = "Login:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(40, 188);
            label4.Name = "label4";
            label4.Size = new Size(75, 23);
            label4.TabIndex = 3;
            label4.Text = "Senha:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(117, 133);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(209, 23);
            txtNome.TabIndex = 4;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(117, 162);
            txtLogin.MaxLength = 20;
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(146, 23);
            txtLogin.TabIndex = 5;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(117, 191);
            txtSenha.MaxLength = 8;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(146, 23);
            txtSenha.TabIndex = 6;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // gbPesquisa
            // 
            gbPesquisa.Controls.Add(txtPesqAtendente);
            gbPesquisa.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbPesquisa.ForeColor = SystemColors.Highlight;
            gbPesquisa.Location = new Point(46, 246);
            gbPesquisa.Name = "gbPesquisa";
            gbPesquisa.Size = new Size(217, 60);
            gbPesquisa.TabIndex = 7;
            gbPesquisa.TabStop = false;
            gbPesquisa.Text = "Pesquisar por atendente.";
            // 
            // txtPesqAtendente
            // 
            txtPesqAtendente.Location = new Point(6, 25);
            txtPesqAtendente.Name = "txtPesqAtendente";
            txtPesqAtendente.Size = new Size(211, 26);
            txtPesqAtendente.TabIndex = 8;
            // 
            // dgvAtendente
            // 
            dgvAtendente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtendente.Location = new Point(41, 309);
            dgvAtendente.Name = "dgvAtendente";
            dgvAtendente.Size = new Size(222, 66);
            dgvAtendente.TabIndex = 8;
            // 
            // btnNovo
            // 
            btnNovo.ForeColor = SystemColors.HotTrack;
            btnNovo.Location = new Point(337, 258);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 9;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnGravar
            // 
            btnGravar.ForeColor = SystemColors.HotTrack;
            btnGravar.Location = new Point(418, 258);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 10;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.ForeColor = SystemColors.HotTrack;
            btnAlterar.Location = new Point(337, 287);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 11;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            btnRemover.ForeColor = SystemColors.HotTrack;
            btnRemover.Location = new Point(418, 287);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 12;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.ForeColor = SystemColors.HotTrack;
            btnCancelar.Location = new Point(337, 316);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Atendente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCancelar);
            Controls.Add(btnRemover);
            Controls.Add(btnAlterar);
            Controls.Add(btnGravar);
            Controls.Add(btnNovo);
            Controls.Add(dgvAtendente);
            Controls.Add(gbPesquisa);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Atendente";
            Size = new Size(544, 390);
            Load += Atendente_Load;
            gbPesquisa.ResumeLayout(false);
            gbPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAtendente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private GroupBox gbPesquisa;
        private TextBox txtPesqAtendente;
        private DataGridView dgvAtendente;
        private Button btnNovo;
        private Button btnGravar;
        private Button btnAlterar;
        private Button btnRemover;
        private Button btnCancelar;
    }
}
