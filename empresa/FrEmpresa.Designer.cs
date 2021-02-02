namespace empresa
{
    partial class Empresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empresa));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSite = new System.Windows.Forms.Label();
            this.lblQtdFuncionario = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxSite = new System.Windows.Forms.TextBox();
            this.tbxQuantidadeFuncionario = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 73);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(12, 113);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(28, 13);
            this.lblSite.TabIndex = 1;
            this.lblSite.Text = "Site:";
            this.lblSite.Click += new System.EventHandler(this.lblSite_Click);
            // 
            // lblQtdFuncionario
            // 
            this.lblQtdFuncionario.AutoSize = true;
            this.lblQtdFuncionario.Location = new System.Drawing.Point(12, 150);
            this.lblQtdFuncionario.Name = "lblQtdFuncionario";
            this.lblQtdFuncionario.Size = new System.Drawing.Size(128, 13);
            this.lblQtdFuncionario.TabIndex = 2;
            this.lblQtdFuncionario.Text = "Quantidade Funcionarios:";
            this.lblQtdFuncionario.Click += new System.EventHandler(this.lblQtdFuncionario_Click);
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(56, 70);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(209, 20);
            this.tbxNome.TabIndex = 3;
            this.tbxNome.TextChanged += new System.EventHandler(this.tbxNome_TextChanged);
            // 
            // tbxSite
            // 
            this.tbxSite.Location = new System.Drawing.Point(56, 110);
            this.tbxSite.Name = "tbxSite";
            this.tbxSite.Size = new System.Drawing.Size(209, 20);
            this.tbxSite.TabIndex = 4;
            this.tbxSite.TextChanged += new System.EventHandler(this.tbxSite_TextChanged);
            // 
            // tbxQuantidadeFuncionario
            // 
            this.tbxQuantidadeFuncionario.Location = new System.Drawing.Point(146, 147);
            this.tbxQuantidadeFuncionario.Name = "tbxQuantidadeFuncionario";
            this.tbxQuantidadeFuncionario.Size = new System.Drawing.Size(119, 20);
            this.tbxQuantidadeFuncionario.TabIndex = 5;
            this.tbxQuantidadeFuncionario.TextChanged += new System.EventHandler(this.tbxQuantidadeFuncionario_TextChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(15, 187);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(190, 187);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 227);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.tbxQuantidadeFuncionario);
            this.Controls.Add(this.tbxSite);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.lblQtdFuncionario);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.lblNome);
            this.Name = "Empresa";
            this.Text = "Empresa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.Label lblQtdFuncionario;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxSite;
        private System.Windows.Forms.TextBox tbxQuantidadeFuncionario;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}