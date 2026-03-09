namespace VertexTelaLogin
{
    partial class TelaLogin
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
            txtUsuario = new TextBox();
            txtsenha = new TextBox();
            label4 = new Label();
            bntEntrar = new Button();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bodoni MT Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 9);
            label1.Name = "label1";
            label1.Size = new Size(236, 38);
            label1.TabIndex = 0;
            label1.Text = "Bem vindo ao Vertex";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(310, 127);
            label2.Name = "label2";
            label2.Size = new Size(143, 24);
            label2.TabIndex = 1;
            label2.Text = "Faça seu login.";
            label2.Click += label2_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(321, 164);
            txtUsuario.MaxLength = 20;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(182, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(321, 193);
            txtsenha.MaxLength = 8;
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(182, 23);
            txtsenha.TabIndex = 3;
            txtsenha.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label4.Location = new Point(649, 352);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 5;
            label4.Text = "Desenvoldido por:";
            label4.Click += label4_Click;
            // 
            // bntEntrar
            // 
            bntEntrar.BackColor = SystemColors.HotTrack;
            bntEntrar.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            bntEntrar.ForeColor = Color.White;
            bntEntrar.Location = new Point(353, 222);
            bntEntrar.Name = "bntEntrar";
            bntEntrar.Size = new Size(100, 39);
            bntEntrar.TabIndex = 7;
            bntEntrar.Text = "Entrar";
            bntEntrar.UseVisualStyleBackColor = false;
            bntEntrar.Click += bntEntrar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 408);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(0, 337);
            label6.Name = "label6";
            label6.Size = new Size(102, 30);
            label6.TabIndex = 7;
            label6.Text = "Desenvolvido por:\r\nCarlos Eduardo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 84);
            label5.Name = "label5";
            label5.Size = new Size(250, 56);
            label5.TabIndex = 6;
            label5.Text = "Sistema Gerenciador\r\nde Livros";
            label5.Click += label5_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.boneco_loging_Vertex;
            pictureBox1.Location = new Point(294, 164);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cadeado_login_Vertex;
            pictureBox2.Location = new Point(294, 193);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 408);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(bntEntrar);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(txtsenha);
            Name = "TelaLogin";
            Text = "telalogin";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtsenha;
        private Label label4;
        private Button bntEntrar;
        private Panel panel1;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
